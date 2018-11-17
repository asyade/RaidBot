using Raidbot.Protocol.Messages;
using RaidBot.Engine.Dispatcher;
using RaidBot.Protocol.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidBot.Engine.Bot.Frames
{
    public class CharacterSelectionFrame: Frame
    {
        public static UInt32 PREDICATE = SelectedServerDataMessage.Id;

        public CharacterSelectionFrame(Brain brain): base(brain)
        {
        }

        [MessageHandlerAttribut(typeof(SelectedServerDataExtendedMessage))]
        private void HandleSelectedServerDataExtendedMessage(SelectedServerDataExtendedMessage message)
        {
        }
    }
}
