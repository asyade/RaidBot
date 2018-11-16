using RaidBot.Engine.Dispatcher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidBot.Engine.Bot.Frames
{
    public abstract class Frame: MessagesHandler
    {
        public Brain Brain { get; }

        public Frame(Brain brain)
        {
            Brain = brain;
            brain.Dispatcher.Register(this);
        }

        ~Frame()
        {
            this.Brain.Dispatcher.UnRegister(this);
        }
    }
}
