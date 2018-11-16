using RaidBot.Engine.Dispatcher;
using RaidBot.Protocol.Messages;
using System;
using RaidBot.Engine.Utility.Security;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaidBot.Protocol.Enums;
using System.Security.Cryptography;
using System.IO;

namespace RaidBot.Engine.Bot.Frames
{
    public class AuthFrame: Frame
    {
        public static UInt32 PREDICATE = HelloConnect.Id;
        ProtocolRequired mProtocolRequired;
        HelloConnect mHelloConnect;
        Brain mBrain;

        public AuthFrame(Brain brain): base(brain)
        {
            mBrain = brain;
        }

        [MessageHandlerAttribut(typeof(ProtocolRequired))]
        private void HandleProtocolRequired(ProtocolRequired msg)
        {
            Console.WriteLine("Required version " + msg.requiredVersion);
            mProtocolRequired = msg;
        }

        [MessageHandlerAttribut(typeof(HelloConnect))]
        private void HandleHelloConnect(HelloConnect msg)
        {
            Console.WriteLine("Salt " + msg.salt + " key len " + msg.key.Length);
            foreach (sbyte b in msg.key)
                Console.Write(b + ", ");
            mHelloConnect = msg;
            SendCredentials();
        }
        
        [MessageHandlerAttribut(typeof(IdentificationFailedMessage))]
        private void HandleIdentificationFailedMessage(IdentificationFailedMessage msg)
        {
            Console.WriteLine("Identification failed, reason : " + (IdentificationFailureReasonEnum)msg.reason);
        }

        [MessageHandlerAttribut(typeof(IdentificationFailedBannedMessage))]
        private void HandleIdentificationBannedMessage(IdentificationFailedBannedMessage msg)
        {
            Console.WriteLine("Banned !");
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        [MessageHandlerAttribut(typeof(IdentificationFailedForBadVersionMessage))]
        private void HandleIdentificationFailedForBadVersion(IdentificationFailedForBadVersionMessage msg)
        {
            Console.WriteLine("Bad version !");
        }

        private void SendCredentials()
        {
            while (this.mHelloConnect.salt.Length < 32)
                this.mHelloConnect.salt += ' ';
            String hash = CreateMD5(this.Brain.Config.Password);
            Console.WriteLine("Encodede : " + hash + "|" + Brain.Config.Password + this.mHelloConnect.salt);
            sbyte[] creds = Cryptography.Encrypt(this.mHelloConnect.key, this.mHelloConnect.salt, this.mBrain.Config.Username, hash);
            mBrain.SendMessage(new IdentificationMessage(true, false, false, new Protocol.Types.VersionExtended(2, 48, 17, 96720011, 1, 0, 1, 1), "fr", creds, 0, 0, new ushort[] { }));
            Console.WriteLine("Send IdentificationMessage ...");
            mBrain.SendMessage(new ClientKeyMessage("FMHb8I6QyPGS3z413D#01")); // TODO have to be generated
            Console.WriteLine("Send ClientKeyMessage ...");
        }
    }
}
