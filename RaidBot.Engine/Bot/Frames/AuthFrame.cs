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
using Raidbot.Protocol.Messages;

namespace RaidBot.Engine.Bot.Frames
{
    public class AuthFrame: Frame
    {
        public static UInt32 PREDICATE = HelloConnectMessage.Id;
        ProtocolRequired mProtocolRequired;
        HelloConnectMessage mHelloConnect;
        Brain mBrain;

        public AuthFrame(Brain brain): base(brain)
        {
            mBrain = brain;
        }

        [MessageHandlerAttribut(typeof(ProtocolRequired))]
        private void HandleProtocolRequired(ProtocolRequired msg)
        {
            Console.WriteLine("Required version " + msg.RequiredVersion);
            mProtocolRequired = msg;
        }

        [MessageHandlerAttribut(typeof(HelloConnectMessage))]
        private void HandleHelloConnect(HelloConnectMessage msg)
        {
            Console.WriteLine("Waiting id");
            mHelloConnect = msg;
            this.Brain.Bypass.AuthentificationLoaded += Bypass_AuthentificationLoaded;
            this.Brain.Bypass.RequestAuthentificationMessage(msg.Salt, msg.Key);
        }

        private void Bypass_AuthentificationLoaded(object sender, Daemon.Daemon.IdentificationLoadedEventArgs e)
        {
            Console.WriteLine("Mine|" + e.Salt + "|" + mHelloConnect.Salt + "|");
            if (e.Salt != mHelloConnect.Salt)
            {
                Console.WriteLine("Wrong identification messge");
                return;
            }
            this.Brain.Bypass.AuthentificationLoaded -= Bypass_AuthentificationLoaded;
            Console.WriteLine("Send the identification msg to server");
            Brain.SendMessage(e.Msg);
        }

        [MessageHandlerAttribut(typeof(IdentificationFailedMessage))]
        private void HandleIdentificationFailedMessage(IdentificationFailedMessage msg)
        {
            Console.WriteLine("Identification failed, reason : " + (IdentificationFailureReasonEnum)msg.Reason);
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
    }
}
