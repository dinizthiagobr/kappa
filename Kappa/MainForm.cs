/*
* Thiago Diniz Maia
* dinizthiagobr@gmail.com
*/

using Kappa.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kappa
{
    public partial class MainForm : Form
    {
        private List<Account> availableAccounts;
        private List<Account> connectedAccounts;

        public MainForm()
        {
            InitializeComponent();
            connectedAccounts = new List<Account>();
            availableAccounts = new List<Account>();

            availableAccountsListBox.DisplayMember = "userName";
            connectedAccountsListBox.DisplayMember = "userName";
        }

        private void getAccButton_Click(object sender, EventArgs e)
        {
            availableAccountsListBox.Items.Clear();

            List<string> lines = Utils.readLines("Accounts.txt");

            foreach (string acc in lines)
            {
                string[] accDetails = acc.Split(';');
                Account newAccount = new Account(accDetails[0], accDetails[2], accDetails[1]);
                availableAccounts.Add(newAccount);
                         
                availableAccountsListBox.Items.Add(newAccount);
            }
        }

        private void connectAccButton_Click(object sender, EventArgs e)
        {
            Account account = (Account)availableAccountsListBox.SelectedItem;
            if (account == null)
                return;

            account.connect();

            availableAccounts.Remove(account);
            connectedAccounts.Add(account);

            connectedAccountsListBox.Items.Add(account);
            availableAccountsListBox.Items.Remove(account);
        }

        private void disconnectAccButton_Click(object sender, EventArgs e)
        {
            Account account = (Account)connectedAccountsListBox.SelectedItem;
            if (account == null)
                return;

            account.disconnect();
            
            connectedAccounts.Remove(account);
            availableAccounts.Add(account);

            availableAccountsListBox.Items.Add(account);
            connectedAccountsListBox.Items.Remove(account);
        }

        private void addChannelButton_Click(object sender, EventArgs e)
        {
            string newChannel = channelTextBox.Text;

            if (string.IsNullOrEmpty(newChannel))
            {
                return;
            }

            channelsListBox.Items.Add(newChannel);
            
            foreach(Account acc in connectedAccounts)
            {
                acc.joinChat(newChannel);
            }
        }

        private void removeChannelButton_Click(object sender, EventArgs e)
        {
            string newChannel = (string)channelsListBox.SelectedItem;

            if (string.IsNullOrEmpty(newChannel))
            {
                return;
            }

            channelsListBox.Items.Remove(newChannel);

            foreach (Account acc in connectedAccounts)
            {
                acc.leaveChat(newChannel);
            }
        }

        private void sendToSelectedButton_Click(object sender, EventArgs e)
        {
            string channel = (string)channelsListBox.SelectedItem;
            string message = (string)messageTextBox.Text;

            if (string.IsNullOrEmpty(channel) || string.IsNullOrEmpty(message))
            {
                return;
            }

            foreach (Account acc in connectedAccounts)
            {
                acc.sendMessage(channel, message);

                Random random = new Random();
                int seconds = Int32.Parse(secondsTextBox.Text);
                int sleepSec = random.Next(seconds - 3, seconds + 3);
                System.Threading.Thread.Sleep(sleepSec * 1000);
            }
        }

        private void sendSelectedButton_Click(object sender, EventArgs e)
        {
            string channel = (string)channelsListBox.SelectedItem;
            string message = (string)messageTextBox.Text;

            Account account = (Account)connectedAccountsListBox.SelectedItem;
            if (account == null)
                return;

            account.sendMessage(channel, message);
        }
    }
}
