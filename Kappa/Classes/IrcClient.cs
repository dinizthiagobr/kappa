/*
* Thiago Diniz Maia
* dinizthiagobr@gmail.com
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Kappa.Classes
{
    class IrcClient
    {
        private TcpClient tcpClient;
        private StreamReader inputStream;
        private StreamWriter outputStream;
        
        public IrcClient(string ip, int port, string userName, string password)
        {
            tcpClient = new TcpClient(ip, port);
            inputStream = new StreamReader(tcpClient.GetStream());
            outputStream = new StreamWriter(tcpClient.GetStream());

            outputStream.WriteLine("PASS " + password);
            outputStream.WriteLine("NICK " + userName);
            outputStream.WriteLine("USER " + userName + " 8 * :" + userName);
            outputStream.Flush();
        }    

        public void joinRoom(string channel)
        {
            outputStream.WriteLine("JOIN #" + channel);
            outputStream.Flush();
        }

        public void leaveRoom(string channel)
        {
            outputStream.WriteLine("PART #" + channel);
            outputStream.Flush();
        }

        public void sendIrcMessage(string message)
        {
            outputStream.WriteLine(message);
            outputStream.Flush();
        }

        public void sendChatMessage(string userName, string channel, string message)
        {
            sendIrcMessage(":" + userName + "!" + userName + "@" + userName + ".tmi.twitch.tv PRIVMSG #" + channel + " :" + message);
        }
    }
}
