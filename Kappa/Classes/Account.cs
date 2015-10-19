/*
* Thiago Diniz Maia
* dinizthiagobr@gmail.com
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kappa.Classes
{
    class Account
    {
        public string userName { set; get; }
        private string oauth;
        private string password;
        private IrcClient irc;

        public Account(string _userName, string _oauth, string _password)
        {
            userName = _userName;
            oauth = _oauth;
            password = _password;        
        }

        public void connect()
        {
            irc = new IrcClient("irc.twitch.tv", 6667, userName, oauth);
        }

        public void disconnect()
        {
            irc = null;
        }

        public void joinChat(string channel)
        {            
            irc.joinRoom(channel);
        }

        public void leaveChat(string channel)
        {
            irc.leaveRoom(channel);
        }

        public void sendMessage(string channel, string message)
        {
            irc.sendChatMessage(userName, channel, message);
        }
    }
}
