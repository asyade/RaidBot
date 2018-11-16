using RaidBot.Common.Default.Loging;
using RaidBot.Common.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using RaidBot.Protocol.Messages;
using RaidBot.Engine.Bot;

namespace RaidBot.Engine.Dispatcher
{
    public class Dispatcher 
    {
        private List<IMessagesHandler> MessagessHandlers;
        public Dispatcher()
        {
            MessagessHandlers = new List<IMessagesHandler>();
        }

        public event EventHandler<MessageInitializedEventArgs> MessageInitialized;
        private void OnMessageInitialized(NetworkMessage message , Brain mHost)
        {
            Console.WriteLine("Receive : " + message.GetType().Name);
            if (MessageInitialized != null)
            {
                MessageInitialized(this, new MessageInitializedEventArgs(message , mHost));
            }
        }
       
        public bool DispatchMessage(NetworkMessage message, Brain mHost)
        {
            bool isInitialized = false;
            bool retVal = true;
           foreach(var handler in MessagessHandlers)
           {
               if (handler.ContainsType(message.GetType()))
               {
                   if(!isInitialized)
                   {
                       message.Deserialize(new CustomDataReader(message.Data));
                       isInitialized = true;
                       OnMessageInitialized(message , mHost);
                   }
                   if(retVal==true)
                   {
                       retVal = handler.DispatchMessage(message);
                   }
                   else
                   {
                       handler.DispatchMessage(message);
                   }
               }
           }
            return retVal;
        }

        public void Register(IMessagesHandler handler)
        {
            MessagessHandlers.Add(handler);
        }

        public void UnRegister(IMessagesHandler handler)
        {
            if (MessagessHandlers.Contains(handler))
                MessagessHandlers.Remove(handler);
        }
    }
}