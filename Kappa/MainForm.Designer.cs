namespace Kappa
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.getAccButton = new System.Windows.Forms.Button();
            this.availableAccountsListBox = new System.Windows.Forms.ListBox();
            this.connectedAccountsListBox = new System.Windows.Forms.ListBox();
            this.connectAccButton = new System.Windows.Forms.Button();
            this.disconnectAccButton = new System.Windows.Forms.Button();
            this.channelsListBox = new System.Windows.Forms.ListBox();
            this.channelTextBox = new System.Windows.Forms.TextBox();
            this.addChannelButton = new System.Windows.Forms.Button();
            this.removeChannelButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.sendToSelectedButton = new System.Windows.Forms.Button();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.sleepSecondsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sendSelectedButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getAccButton
            // 
            this.getAccButton.Location = new System.Drawing.Point(12, 534);
            this.getAccButton.Name = "getAccButton";
            this.getAccButton.Size = new System.Drawing.Size(112, 23);
            this.getAccButton.TabIndex = 1;
            this.getAccButton.Text = "Get Accounts";
            this.getAccButton.UseVisualStyleBackColor = true;
            this.getAccButton.Click += new System.EventHandler(this.getAccButton_Click);
            // 
            // availableAccountsListBox
            // 
            this.availableAccountsListBox.FormattingEnabled = true;
            this.availableAccountsListBox.Location = new System.Drawing.Point(12, 355);
            this.availableAccountsListBox.Name = "availableAccountsListBox";
            this.availableAccountsListBox.Size = new System.Drawing.Size(152, 173);
            this.availableAccountsListBox.TabIndex = 2;
            // 
            // connectedAccountsListBox
            // 
            this.connectedAccountsListBox.FormattingEnabled = true;
            this.connectedAccountsListBox.Location = new System.Drawing.Point(251, 355);
            this.connectedAccountsListBox.Name = "connectedAccountsListBox";
            this.connectedAccountsListBox.Size = new System.Drawing.Size(152, 173);
            this.connectedAccountsListBox.TabIndex = 3;
            // 
            // connectAccButton
            // 
            this.connectAccButton.Location = new System.Drawing.Point(170, 380);
            this.connectAccButton.Name = "connectAccButton";
            this.connectAccButton.Size = new System.Drawing.Size(75, 23);
            this.connectAccButton.TabIndex = 4;
            this.connectAccButton.Text = ">>";
            this.connectAccButton.UseVisualStyleBackColor = true;
            this.connectAccButton.Click += new System.EventHandler(this.connectAccButton_Click);
            // 
            // disconnectAccButton
            // 
            this.disconnectAccButton.Location = new System.Drawing.Point(170, 477);
            this.disconnectAccButton.Name = "disconnectAccButton";
            this.disconnectAccButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectAccButton.TabIndex = 5;
            this.disconnectAccButton.Text = "<<";
            this.disconnectAccButton.UseVisualStyleBackColor = true;
            this.disconnectAccButton.Click += new System.EventHandler(this.disconnectAccButton_Click);
            // 
            // channelsListBox
            // 
            this.channelsListBox.FormattingEnabled = true;
            this.channelsListBox.Location = new System.Drawing.Point(252, 25);
            this.channelsListBox.Name = "channelsListBox";
            this.channelsListBox.Size = new System.Drawing.Size(151, 186);
            this.channelsListBox.TabIndex = 6;
            // 
            // channelTextBox
            // 
            this.channelTextBox.Location = new System.Drawing.Point(251, 269);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.Size = new System.Drawing.Size(151, 20);
            this.channelTextBox.TabIndex = 7;
            // 
            // addChannelButton
            // 
            this.addChannelButton.Location = new System.Drawing.Point(251, 295);
            this.addChannelButton.Name = "addChannelButton";
            this.addChannelButton.Size = new System.Drawing.Size(75, 23);
            this.addChannelButton.TabIndex = 8;
            this.addChannelButton.Text = "Add";
            this.addChannelButton.UseVisualStyleBackColor = true;
            this.addChannelButton.Click += new System.EventHandler(this.addChannelButton_Click);
            // 
            // removeChannelButton
            // 
            this.removeChannelButton.Location = new System.Drawing.Point(252, 218);
            this.removeChannelButton.Name = "removeChannelButton";
            this.removeChannelButton.Size = new System.Drawing.Size(75, 23);
            this.removeChannelButton.TabIndex = 9;
            this.removeChannelButton.Text = "Remove";
            this.removeChannelButton.UseVisualStyleBackColor = true;
            this.removeChannelButton.Click += new System.EventHandler(this.removeChannelButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(12, 44);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(232, 20);
            this.messageTextBox.TabIndex = 10;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(12, 12);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(53, 13);
            this.messageLabel.TabIndex = 11;
            this.messageLabel.Text = "Message:";
            // 
            // sendToSelectedButton
            // 
            this.sendToSelectedButton.Location = new System.Drawing.Point(12, 70);
            this.sendToSelectedButton.Name = "sendToSelectedButton";
            this.sendToSelectedButton.Size = new System.Drawing.Size(134, 23);
            this.sendToSelectedButton.TabIndex = 12;
            this.sendToSelectedButton.Text = "Send with all";
            this.sendToSelectedButton.UseVisualStyleBackColor = true;
            this.sendToSelectedButton.Click += new System.EventHandler(this.sendToSelectedButton_Click);
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Location = new System.Drawing.Point(15, 155);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(66, 20);
            this.secondsTextBox.TabIndex = 13;
            this.secondsTextBox.Text = "5";
            // 
            // sleepSecondsLabel
            // 
            this.sleepSecondsLabel.AutoSize = true;
            this.sleepSecondsLabel.Location = new System.Drawing.Point(15, 136);
            this.sleepSecondsLabel.Name = "sleepSecondsLabel";
            this.sleepSecondsLabel.Size = new System.Drawing.Size(85, 13);
            this.sleepSecondsLabel.TabIndex = 14;
            this.sleepSecondsLabel.Text = "Sleep for around";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "seconds";
            // 
            // sendSelectedButton
            // 
            this.sendSelectedButton.Location = new System.Drawing.Point(15, 100);
            this.sendSelectedButton.Name = "sendSelectedButton";
            this.sendSelectedButton.Size = new System.Drawing.Size(131, 23);
            this.sendSelectedButton.TabIndex = 16;
            this.sendSelectedButton.Text = "Send with selected";
            this.sendSelectedButton.UseVisualStyleBackColor = true;
            this.sendSelectedButton.Click += new System.EventHandler(this.sendSelectedButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Available accounts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Connected accounts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Connected channels";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "New channel";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 569);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sendSelectedButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sleepSecondsLabel);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.sendToSelectedButton);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.removeChannelButton);
            this.Controls.Add(this.addChannelButton);
            this.Controls.Add(this.channelTextBox);
            this.Controls.Add(this.channelsListBox);
            this.Controls.Add(this.disconnectAccButton);
            this.Controls.Add(this.connectAccButton);
            this.Controls.Add(this.connectedAccountsListBox);
            this.Controls.Add(this.availableAccountsListBox);
            this.Controls.Add(this.getAccButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Kappa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button getAccButton;
        private System.Windows.Forms.ListBox availableAccountsListBox;
        private System.Windows.Forms.ListBox connectedAccountsListBox;
        private System.Windows.Forms.Button connectAccButton;
        private System.Windows.Forms.Button disconnectAccButton;
        private System.Windows.Forms.ListBox channelsListBox;
        private System.Windows.Forms.TextBox channelTextBox;
        private System.Windows.Forms.Button addChannelButton;
        private System.Windows.Forms.Button removeChannelButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button sendToSelectedButton;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.Label sleepSecondsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendSelectedButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

