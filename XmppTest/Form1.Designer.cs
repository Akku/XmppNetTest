namespace Gtalk
{
    partial class FrmGtalk
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
            this.components = new System.ComponentModel.Container();
            this.jabberClient1 = new jabber.client.JabberClient(this.components);
            this.pnlCredentials = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnSignin = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlContact = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.rosterTree1 = new muzzle.RosterTree();
            this.lblPresence = new System.Windows.Forms.Label();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.textBoxNetworkHost = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxAddUsername = new System.Windows.Forms.TextBox();
            this.textBoxAddNickname = new System.Windows.Forms.TextBox();
            this.textBoxAddGroupname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlCredentials.SuspendLayout();
            this.pnlContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // jabberClient1
            // 
            this.jabberClient1.AutoReconnect = 30F;
            this.jabberClient1.AutoStartCompression = true;
            this.jabberClient1.AutoStartTLS = true;
            this.jabberClient1.InvokeControl = this;
            this.jabberClient1.KeepAlive = 30F;
            this.jabberClient1.LocalCertificate = null;
            this.jabberClient1.Password = null;
            this.jabberClient1.User = null;
            // 
            // pnlCredentials
            // 
            this.pnlCredentials.Controls.Add(this.checkBox1);
            this.pnlCredentials.Controls.Add(this.label4);
            this.pnlCredentials.Controls.Add(this.label3);
            this.pnlCredentials.Controls.Add(this.label2);
            this.pnlCredentials.Controls.Add(this.textBoxPort);
            this.pnlCredentials.Controls.Add(this.textBoxNetworkHost);
            this.pnlCredentials.Controls.Add(this.textBoxServerName);
            this.pnlCredentials.Controls.Add(this.label1);
            this.pnlCredentials.Controls.Add(this.txtPassword);
            this.pnlCredentials.Controls.Add(this.lblPassword);
            this.pnlCredentials.Controls.Add(this.txtUserName);
            this.pnlCredentials.Controls.Add(this.btnSignin);
            this.pnlCredentials.Controls.Add(this.lblUserName);
            this.pnlCredentials.Location = new System.Drawing.Point(3, 12);
            this.pnlCredentials.Name = "pnlCredentials";
            this.pnlCredentials.Size = new System.Drawing.Size(236, 389);
            this.pnlCredentials.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(94, 57);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(129, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 58);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(94, 31);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(129, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // btnSignin
            // 
            this.btnSignin.Location = new System.Drawing.Point(9, 85);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(214, 26);
            this.btnSignin.TabIndex = 7;
            this.btnSignin.Text = "Sign In";
            this.btnSignin.UseVisualStyleBackColor = true;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(3, 33);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(89, 20);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "User Name";
            // 
            // pnlContact
            // 
            this.pnlContact.Controls.Add(this.label7);
            this.pnlContact.Controls.Add(this.label6);
            this.pnlContact.Controls.Add(this.label5);
            this.pnlContact.Controls.Add(this.textBoxAddGroupname);
            this.pnlContact.Controls.Add(this.textBoxAddNickname);
            this.pnlContact.Controls.Add(this.textBoxAddUsername);
            this.pnlContact.Controls.Add(this.button1);
            this.pnlContact.Controls.Add(this.lblStatus);
            this.pnlContact.Controls.Add(this.lblUser);
            this.pnlContact.Controls.Add(this.rosterTree1);
            this.pnlContact.Controls.Add(this.lblPresence);
            this.pnlContact.Controls.Add(this.tbStatus);
            this.pnlContact.Controls.Add(this.btnSignOut);
            this.pnlContact.Location = new System.Drawing.Point(3, 3);
            this.pnlContact.Name = "pnlContact";
            this.pnlContact.Size = new System.Drawing.Size(258, 445);
            this.pnlContact.TabIndex = 6;
            this.pnlContact.Visible = false;
            this.pnlContact.Click += new System.EventHandler(this.pnlContact_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(10, 24);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(236, 20);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Double Click to enter your status message";
            this.lblStatus.DoubleClick += new System.EventHandler(this.lblStatus_DoubleClick);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(10, 8);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(33, 13);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "User";
            // 
            // rosterTree1
            // 
            this.rosterTree1.AllowDrop = true;
            this.rosterTree1.Client = this.jabberClient1;
            this.rosterTree1.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.rosterTree1.ImageIndex = 1;
            this.rosterTree1.Location = new System.Drawing.Point(0, 44);
            this.rosterTree1.Name = "rosterTree1";
            this.rosterTree1.PresenceManager = null;
            this.rosterTree1.RosterManager = null;
            this.rosterTree1.SelectedImageIndex = 0;
            this.rosterTree1.ShowLines = false;
            this.rosterTree1.ShowRootLines = false;
            this.rosterTree1.Size = new System.Drawing.Size(255, 280);
            this.rosterTree1.Sorted = true;
            this.rosterTree1.StatusColor = System.Drawing.Color.Teal;
            this.rosterTree1.TabIndex = 5;
            this.rosterTree1.Click += new System.EventHandler(this.rosterTree1_Click);
            // 
            // lblPresence
            // 
            this.lblPresence.AutoSize = true;
            this.lblPresence.Location = new System.Drawing.Point(163, 8);
            this.lblPresence.Name = "lblPresence";
            this.lblPresence.Size = new System.Drawing.Size(37, 13);
            this.lblPresence.TabIndex = 4;
            this.lblPresence.Text = "Offline";
            // 
            // tbStatus
            // 
            this.tbStatus.Location = new System.Drawing.Point(10, 24);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(236, 20);
            this.tbStatus.TabIndex = 3;
            this.tbStatus.Visible = false;
            this.tbStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbStatus_KeyDown);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(0, 419);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(75, 23);
            this.btnSignOut.TabIndex = 0;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "...using these values:";
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(94, 142);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(129, 20);
            this.textBoxServerName.TabIndex = 11;
            this.textBoxServerName.Text = "productive2";
            // 
            // textBoxNetworkHost
            // 
            this.textBoxNetworkHost.Location = new System.Drawing.Point(94, 168);
            this.textBoxNetworkHost.Name = "textBoxNetworkHost";
            this.textBoxNetworkHost.Size = new System.Drawing.Size(129, 20);
            this.textBoxNetworkHost.TabIndex = 12;
            this.textBoxNetworkHost.Text = "abelssoft.dyndns.org";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(94, 194);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(129, 20);
            this.textBoxPort.TabIndex = 13;
            this.textBoxPort.Text = "5222";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Server Name";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Network Host";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Port";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 231);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(154, 17);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Use SSL (needs port 5223)";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxAddUsername
            // 
            this.textBoxAddUsername.Location = new System.Drawing.Point(3, 345);
            this.textBoxAddUsername.Name = "textBoxAddUsername";
            this.textBoxAddUsername.Size = new System.Drawing.Size(92, 20);
            this.textBoxAddUsername.TabIndex = 9;
            // 
            // textBoxAddNickname
            // 
            this.textBoxAddNickname.Location = new System.Drawing.Point(101, 345);
            this.textBoxAddNickname.Name = "textBoxAddNickname";
            this.textBoxAddNickname.Size = new System.Drawing.Size(92, 20);
            this.textBoxAddNickname.TabIndex = 10;
            // 
            // textBoxAddGroupname
            // 
            this.textBoxAddGroupname.Location = new System.Drawing.Point(101, 371);
            this.textBoxAddGroupname.Name = "textBoxAddGroupname";
            this.textBoxAddGroupname.Size = new System.Drawing.Size(92, 20);
            this.textBoxAddGroupname.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Groupname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(98, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Your Nickname for the user";
            // 
            // FrmGtalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 447);
            this.Controls.Add(this.pnlContact);
            this.Controls.Add(this.pnlCredentials);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmGtalk";
            this.Text = "Gtalk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlCredentials.ResumeLayout(false);
            this.pnlCredentials.PerformLayout();
            this.pnlContact.ResumeLayout(false);
            this.pnlContact.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCredentials;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel pnlContact;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Label lblPresence;
        private System.Windows.Forms.TextBox tbStatus;
        private muzzle.RosterTree rosterTree1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblStatus;
        private jabber.client.JabberClient jabberClient1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxNetworkHost;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAddGroupname;
        private System.Windows.Forms.TextBox textBoxAddNickname;
        private System.Windows.Forms.TextBox textBoxAddUsername;
        private System.Windows.Forms.Button button1;
    }
}

