using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiscordRPC;
using Newtonsoft.Json.Bson;
namespace Fortnite_Information_Tool.Discord
{
    class DiscordRPC
    {
        private DiscordRpcClient _Client;
        public void Connect()
        {
            _Client = new DiscordRpcClient("1018603046969802772");
            _Client.Initialize();

            _Client.SetPresence(new RichPresence()
            {
                Details = "🖥 Build | v2.0 (REL)",
                State = $"👨‍💻 Created by Kyro",
                Assets = new Assets()
                {
                    LargeImageKey = "fortnite_f_lettermark_logo_1_",
                    LargeImageText = "Fortnite Information Tool",
                }
            });
        }
    }
}