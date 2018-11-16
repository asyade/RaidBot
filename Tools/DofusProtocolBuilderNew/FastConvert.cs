using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DofusProtocolBuilder
{
    public class FastConvert
    {
        public NetworkClass Parsed { get; set; }

        static Regex SerializeFncReg = new Regex(@"^(\s*)public(\s*)function(\s*)serializeAs_([A-z]*)\(output:ICustomDataOutput\)*");
        static Regex PrimitiveWriteCall = new Regex(@"^(\s*)output.write([A-z]*)\(this.([A-z]*)\);");
        static Regex ArraySizeWriteCall = new Regex(@"^(\s*)output.write([A-z]*)\(this.([A-z]*).length\);");
        static Regex ArraySerializeCall = new Regex(@"^\s*\(this.[A-z]*\[_*[A-Za-z0-9]*] as ([A-z]*)\).([A-z]*)\([A-z]*\);");
        static Regex ArrySerializePrimitiveCall = new Regex(@"^(\s*)output.write([A-z]*)\(this.([A-z]*)\[[A-z0-9]*\]\);");
        static Regex ArraySerializeIdCall = new Regex(@"^(\s*)output.writeShort\(\(this.[A-z]*");
        static Regex BooleanByteCall = new Regex(@"^\s*_box0 = BooleanByteWrapper.setFlag\(_box0,([0-9]*),this.([A-z]*)\);");
        static Regex ClassDeclaration = new Regex(@"^\s*public class ([A-z]*) extends ([A-z]*)\s*implements [A-z]*");
        static Regex ClassDeclarationSimple = new Regex(@"^\s*public class ([A-z]*)\s*implements [A-z]*");
        static Regex ProtocolId = new Regex(@"^\s*public static const protocolId:uint = ([0-9]*);");
        static Regex SerializeObject = new Regex(@"^\s*this.([A-z]*).serializeAs_([A-z]*)\(output\);");

        public FastConvert(String content)
        {
            Parsed = new NetworkClass();
            String[] lines = content.Split('\n');
            int open = 0;
            int close = 0;
            bool readingDeserialize = false;
            String bloc = "";
            foreach (String line in lines)
            {
                if (readingDeserialize)
                {
                    if (line.Trim() == "{")
                        open++;
                    if (line.Trim() == "}")
                        close++;
                    bloc += line + "\n";
                    if (open == close)
                        break;
                }
                else if (SerializeFncReg.IsMatch(line))
                {
                    readingDeserialize = true;
                }
                else if (ClassDeclaration.IsMatch(line))
                {
                    Match m = ClassDeclaration.Match(line);
                    Parsed.Name = m.Groups[1].Value;
                    Parsed.Parent = m.Groups[2].Value;
                }
                else if (ClassDeclarationSimple.IsMatch(line))
                {
                    Match m = ClassDeclarationSimple.Match(line);
                    Parsed.Name = m.Groups[1].Value;
                }
                else if (ProtocolId.IsMatch(line))
                {
                    Match m = ProtocolId.Match(line);
                    Parsed.Id = int.Parse(m.Groups[1].Value);
                }
            }
            bool useBw = false;
            Parsed.Fields = ParseDeserializeBloc(bloc, out useBw);
            Parsed.UseByteWrapper = useBw;
            foreach (NetworkClassField field in Parsed.Fields)
            {
                field.ConvertNames();
            }
        }


        private List<NetworkClassField> ParseDeserializeBloc(String bloc, out bool useBool)
        {
            useBool = false;
            List<NetworkClassField> Fields = new List<NetworkClassField>();
            String[] lines = bloc.Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                String line = lines[i];
                if (PrimitiveWriteCall.IsMatch(line))
                {
                    Match m = PrimitiveWriteCall.Match(line);
                    Fields.Add(new NetworkClassField(m.Groups[3].Value, m.Groups[2].Value));
                    //Console.WriteLine(m.Groups[3].Value + " : " + m.Groups[2].Value);
                }
                else if (SerializeObject.IsMatch(line))
                {
                    Match m = SerializeObject.Match(line);
                    Fields.Add(new NetworkClassField(m.Groups[1].Value, m.Groups[2].Value));
                }
                else if (ArraySizeWriteCall.IsMatch(line))
                {
                    Match m = ArraySizeWriteCall.Match(line);
                    NetworkClassField field = new NetworkClassField(m.Groups[3].Value);
                    field.ArrayMethode = m.Groups[2].Value;
                    field.IsGenericArray = false;
                    field.IsArray = true;
                    i += 2;
                    int open = 0;
                    int close = 0;
                    for (; i < lines.Length; i++)
                    {
                        line = lines[i];
                        if (line.Trim() == "{")
                            open++;
                        if (line.Trim() == "}")
                            close++;
                        if (ArraySerializeIdCall.IsMatch(line))
                            field.IsGenericArray = true;
                        else if (ArraySerializeCall.IsMatch(line))
                        {
                            Match m2 = ArraySerializeCall.Match(line);
                            field.Methode = m2.Groups[1].Value;
                        }
                        else if (ArrySerializePrimitiveCall.IsMatch(line))
                        {
                            Match m2 = ArrySerializePrimitiveCall.Match(line);
                            field.Methode = m2.Groups[2].Value;
                        }
                        if (close == open)
                            break;
                    }
                    //Console.WriteLine(field.Name + "[" + field.Methode + "] " + (field.IsGenericArray ? "Generic" : "") + " size methode " + field.ArrayMethode);
                    Fields.Add(field);
                }
                else if (BooleanByteCall.IsMatch(line))
                {
                    Match m2 = BooleanByteCall.Match(line);
                    Fields.Add(new NetworkClassField(m2.Groups[2].Value, int.Parse(m2.Groups[1].Value)));
                    useBool = true;

                    //Console.WriteLine(m2.Groups[2].Value + " : bool -> " + m2.Groups[1].Value);
                }
            }
            return Fields;
        }

        public class NetworkClass
        {
            public List<NetworkClassField> Fields;
            public String Name { get; set; }
            public String Parent { get; set; }
            public bool UseByteWrapper { get; set; }
            public int Id { get; set; }
            public NetworkClass()
            {
                UseByteWrapper = false;
                Id = 0;
                Name = "";
                Parent = "";
                Fields = new List<NetworkClassField>();
            }

            override public String ToString()
            {
                StringBuilder o = new StringBuilder();
                o.AppendLine("using System;");
                o.AppendLine("using System.Collections.Generic;");
                o.AppendLine("using System.Linq;");
                o.AppendLine("using RaidBot.Protocol.Types;");
                o.AppendLine("using RaidBot.Common.IO;");
                o.AppendLine("\nnamespace Raidbot.Protocol.Messages\n{");
                o.AppendLine("public class " + Name + (Parent != null ? " : " + Parent : "") + "\n{");
                o.AppendLine("\n\tpublic const uint Id = " + Id + ";\n\tpublic override uint MessageId { get { return Id; } }\n");

                foreach (NetworkClassField field in this.Fields)
                {
                    if (field.IsArray)
                        o.AppendFormat("\tpublic {1}[] {0} {{ get; set; }}\n", field.Name, field.Type);
                    else
                        o.AppendFormat("\tpublic {1} {0} {{ get; set; }}\n", field.Name, field.Type);
                }

                o.AppendLine("\n\tpublic override void Serialize(ICustomDataWriter writer)\n\t{");
                if (Parent != "NetworkMessage" && Parent != "NetworkType")
                    o.AppendFormat("\t\tbase.Serialize(writer)");
                if (UseByteWrapper)
                {
                    o.AppendLine("\t\tbyte box = 0;");
                }
                foreach (NetworkClassField field in this.Fields)
                {
                    if (!field.IsArray && !field.IsBoolean)
                    {
                        if (field.IsObject)
                            o.AppendFormat("\t\tthis.{0}.Serialize(writer);\n", field.Type, field.Name);
                        else
                            o.AppendFormat("\t\twriter.Write{0}(this.{1});\n", field.Type, field.Name);
                    }
                    else if (field.IsBoolean)
                        o.AppendFormat("\t\tbox = BooleanByteWrapper.SetFlag(box, {0}, {1});\n", field.BooleanIndex, field.Name);
                    else if (field.IsArray)
                    {
                        String indexName = field.Name + "Index";
                        o.AppendFormat("\t\twriter.Write{0}(this.{1}.length);\n", field.ArrayMethode, field.Name);
                        o.AppendFormat("\t\tforeach ({0} item in this.{1})\n\t\t{{\n", field.Type, field.Name);
                        if (field.IsGenericArray)
                            o.AppendFormat("\t\t\twriter.WriteShort(item.MessageId);\n");
                        if (field.IsObject)
                            o.AppendFormat("\t\t\titem.Serialize(writer);\n");
                        else
                            o.AppendFormat("\t\t\twriter.Write{0}(item);\n", field.Type, field.Name);
                        o.AppendLine("\t\t}");
                    }
                }

                o.AppendLine("\t}\n}\n}");
                return (o.ToString());
            }
        }

        public class NetworkClassField
        {
            public string Name { get; set; }
            public string Methode { get; set; }
            public string ArrayMethode { get; set; }
            public bool IsArray { get; set; }
            public bool IsObject { get; set; }
            public bool IsGenericArray { get; set; }
            public bool IsBoolean { get; set; }
            public int BooleanIndex { get; set; }
            public String Type { get; set; }

            public NetworkClassField(String name, String methode)
            {
                Name = name;
                Methode = methode;
                IsArray = false;
                IsBoolean = false;
                IsObject = false;
            }

            public NetworkClassField(String name, int pos)
            {
                Name = name;
                IsBoolean = true;
                IsArray = false;
                IsObject = false;
                BooleanIndex = pos;
            }

            public NetworkClassField(String name)
            {
                Name = name;
                IsArray = true;
                IsBoolean = false;
            }

            static string UppercaseFirst(string s)
            {
                if (string.IsNullOrEmpty(s))
                {
                    return string.Empty;
                }
                char[] a = s.ToCharArray();
                a[0] = char.ToUpper(a[0]);
                return new string(a);
            }

            public void ConvertNames()
            {
                Name = UppercaseFirst(Name);
                this.IsObject = false;
                if (this.IsBoolean)
                {
                    this.Type = "bool";
                    return;
                }
                switch (Methode.ToLower())
                {
                    case "short":
                    case "varshort":
                        Type = "short";
                        break;
                    case "int":
                    case "varint":
                        Type = "int";
                        break;
                    case "long":
                    case "varlong":
                        Type = "long";
                        break;
                    case "utf":
                        Type = "String";
                        break;
                    case "byte":
                        Type = "byte";
                        break;
                    case "boolean":
                        Type = "bool";
                        break;
                    default:
                        this.IsObject = true;
                        Type = Methode;
                        break;
                }
            }
        }
    }
}
