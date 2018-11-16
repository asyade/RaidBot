using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaidBot.Engine.Bot
{
    public class BotConfig
    {
        public String Username { get; set; }
        public String Password { get; set; }
        
        public BotConfig(String username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
