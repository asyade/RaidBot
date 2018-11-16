using RaidBot.Data.IO.D2P.Map;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaidBot.Common.Default.Loging;
using System.IO;
using System.IO.Compression;
using RaidBot.Common.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RaidBot.Data.MapData
{
    public class MapDataAdapter
    {
        private static Map map;
        public static Map GetMap(int id  )
        {
            string[] directories = Directory.GetDirectories(DataSetting.Default.D2PFolderPath);
            

            foreach(string dir in directories)
            {
               if(File.Exists(GetPath(id,dir)))
               {

                   FileInfo file = new FileInfo(GetPath(id, dir));
                  if (IsFileLocked(file)) 
                  {
                      return map;
                  }
                   BinaryFormatter formatter = new BinaryFormatter();
                   map = ((Map)formatter.Deserialize(File.Open(GetPath(id, dir), FileMode.Open)));
                   return map;
               }
            }

            Logger.Default.Log("Map id : "+id.ToString()+"not found",LogLevelEnum.Error);
            return new Map();
        }

        private static string GetPath(int id, string path)
        {
            return string.Format("{0}\\{1}.rmf",path,id);
        }
        private static bool IsFileLocked(FileInfo file)//http://stackoverflow.com/questions/876473/is-there-a-way-to-check-if-a-file-is-in-use
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            }
            catch (IOException)
            {
                //the file is unavailable because it is:
                //still being written to
                //or being processed by another thread
                //or does not exist (has already been processed)
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            //file is not locked
            return false;
        }
    }
}