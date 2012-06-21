using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using jabber.client;
using System.Threading;
using jabber.connection;
using jabber.protocol.client;
using jabber.protocol.iq;
using jabber;
using jabber.protocol;


namespace Gtalk
{
    public partial class FrmGtalk : Form
    {
        static ManualResetEvent done = new ManualResetEvent(false);
        string User, Pwd;
        const string TARGET = "";
        FrmChat[] frmChat = new FrmChat[500];
        RosterManager rm;
        PresenceManager pm;
        int chatCount = -1;
        Hashtable chatIndex = new Hashtable();
        private string Server;

        public FrmGtalk()
        {
            InitializeComponent();

            jabberClient1.OnMessage += new MessageHandler(jabberClient1_OnMessage);
            jabberClient1.OnDisconnect += new bedrock.ObjectHandler(jabberClient1_OnDisconnect);
            jabberClient1.OnError += new bedrock.ExceptionHandler(jabberClient1_OnError);
            jabberClient1.OnAuthError += new jabber.protocol.ProtocolHandler(jabberClient1_OnAuthError);

        }

        void jabberClient1_OnAuthError(object sender, System.Xml.XmlElement rp)
        {

            Console.WriteLine("OnAuthError");
            if (rp.Name == "failure")
            {
                MessageBox.Show("Invalid User Name or Password","Error!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                pnlCredentials.Enabled = true;
                txtUserName.SelectAll();
                txtUserName.Focus();
            }
        }

        void jabberClient1_OnError(object sender, Exception ex)
        {

            Console.WriteLine("OnError: " + ex.Message);
            MessageBox.Show(ex.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            pnlCredentials.Enabled = true;
            txtUserName.SelectAll();
            txtUserName.Focus();
        }

        void jabberClient1_OnDisconnect(object sender)
        {

            Console.WriteLine("OnDisconnect");
            pnlContact.Visible = false;
            pnlCredentials.Enabled = true;
            pnlCredentials.Visible = true;
            txtUserName.Focus();
        }

        private void jabberClient1_OnMessage(object sender, jabber.protocol.client.Message msg)
        {
            Console.WriteLine("OnMessage " + msg.Body);
            frmChat[(int)chatIndex[msg.From.Bare]].ReceiveFlag = true;
            string receivedMsg = msg.From.User + " Says : " + msg.Body + "\n";
            frmChat[(int)chatIndex[msg.From.Bare]].AppendConversation(receivedMsg);
            frmChat[(int)chatIndex[msg.From.Bare]].Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Load");
            txtUserName.Text = "";
            txtUserName.SelectAll();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {

            Console.WriteLine("ClickedSignIn");
            User = txtUserName.Text;
            Pwd = txtPassword.Text;
            Server = textBoxServerName.Text;
            pnlCredentials.Enabled = false;
            jabberClient1.User = User;
            //jabberClient1.Server = "gmail.com";

            jabberClient1.Server = textBoxServerName.Text; // this needs to be the server's name shown in the openfire GUI
            jabberClient1.NetworkHost = textBoxNetworkHost.Text; // this needs to be where the server is located
            // MacBook Air Local: jabberClient1.NetworkHost = "192.168.111.44";
//            jabberClient1.NetworkHost = "192.168.111.11";
            jabberClient1.Password = Pwd;
            jabberClient1.AutoRoster = true;
            jabberClient1.AutoStartTLS = true;
            jabberClient1.SSL = checkBox1.Checked;
            jabberClient1.Port = 5222;
            int port = 0;
            if (int.TryParse(textBoxPort.Text, out port))
                jabberClient1.Port = port;

            rm = new RosterManager();
            rm.Stream = jabberClient1;
            rm.AutoSubscribe = true;
            rm.OnSubscription += new SubscriptionHandler(rm_OnSubscription);
            rm.OnUnsubscription += new UnsubscriptionHandler(rm_OnUnsubscription);
            rm.AutoAllow = jabber.client.AutoSubscriptionHanding.AllowAll;
            rm.OnRosterBegin += new bedrock.ObjectHandler(rm_OnRosterBegin);
            rm.OnRosterEnd += new bedrock.ObjectHandler(rm_OnRosterEnd);
            rm.OnRosterItem += new RosterItemHandler(rm_OnRosterItem);
            

            pm = new PresenceManager();
            pm.Stream = jabberClient1;

            rosterTree1.RosterManager = rm;
            rosterTree1.PresenceManager = pm;
            rosterTree1.DoubleClick += new EventHandler(rosterTree1_DoubleClick);

            jabberClient1.Connect();
            jabberClient1.OnAuthenticate += new bedrock.ObjectHandler(jabberClient1_OnAuthenticate);
            lblUser.Text = jabberClient1.User;
        }

        void rm_OnUnsubscription(RosterManager manager, Presence pres, ref bool remove)
        {
            throw new NotImplementedException();
        }

        void rm_OnSubscription(RosterManager manager, Item ri, Presence pres)
        {
            Console.WriteLine("On Subscription: JID: " + ri.JID + " Nick:" + ri.Nickname);
            Console.WriteLine("on: " + pres.ReceivedTime);
        }

        void rm_OnRosterItem(object sender, Item ri)
        {

            Console.WriteLine("OnRosterItem");
            try
            {
                chatIndex.Add(ri.JID.Bare, ++chatCount);
                InitializeFrmChat(ri.JID.Bare, ri.Nickname);
            }
            catch {}
        }

        void rosterTree1_DoubleClick(object sender, EventArgs e)
        {
            muzzle.RosterTree.ItemNode selectedNode = rosterTree1.SelectedNode as muzzle.RosterTree.ItemNode;
            if( selectedNode != null)
                frmChat[(int)chatIndex[selectedNode.JID.Bare]].Show();
        }


        void rm_OnRosterBegin(object sender)
        {

            Console.WriteLine("OnRosterBegin");
            frmChat = new FrmChat[500];
            chatIndex = new Hashtable();
            rosterTree1.BeginUpdate();
        }

        void rm_OnRosterEnd(object sender)
        {

            Console.WriteLine("OnRosterEnd");
            RosterManager rm1 = (RosterManager)sender;
            
            done.Set();
            rosterTree1.EndUpdate();
            jabberClient1.Presence(jabber.protocol.client.PresenceType.available, tbStatus.Text, null, 0);
            lblPresence.Text = "Available";
            rosterTree1.ExpandAll();
        }

        void jabberClient1_OnAuthenticate(object sender)
        {

            Console.WriteLine("OnAuthenticate");
            pnlCredentials.Visible = false;
            pnlContact.Visible = true;
            done.Set();
            tbStatus.Text = "";
            txtPassword.Text = "";

            jabberClient1.GetRoster();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {

            Console.WriteLine("SignOutClick");
            jabberClient1.Close(true);
        }

        private void InitializeFrmChat(string targetId,string nickName)
        {
            Console.WriteLine("InitializingChat");
            frmChat[chatCount] = new FrmChat();
            frmChat[chatCount].MailId = targetId;
            frmChat[chatCount].JabberClint = jabberClient1;
            if (nickName != null)
                frmChat[chatCount].Text = nickName;
            else
                frmChat[chatCount].Text = (targetId.Split('@'))[0];
            frmChat[chatCount].JabberClint.OnMessage += new MessageHandler(frmChat[chatCount]._jabberClient_OnMessage);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSignin.PerformClick();
                pnlCredentials.Enabled = false;
            }
        }

        private void lblStatus_DoubleClick(object sender, EventArgs e)
        {
            lblStatus.Visible = false;
            tbStatus.Visible = true;
            if (tbStatus.Text.Length > 0)
                tbStatus.Select(0, tbStatus.Text.Length);
        }

        private void tbStatus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tbStatus.Visible = false;
                lblStatus.Visible = true;
                lblStatus.Text = tbStatus.Text;
                jabberClient1.Presence(jabber.protocol.client.PresenceType.available, tbStatus.Text, null, 0);
            }
        }

        private void pnlContact_Click(object sender, EventArgs e)
        {
            ResetStatusMessage();
        }

        private void ResetStatusMessage()
        {
            tbStatus.Visible = false;
            lblStatus.Visible = true;
            tbStatus.Text = lblStatus.Text;
        }

        private void rosterTree1_Click(object sender, EventArgs e)
        {
            if (tbStatus.Visible)
            {
                ResetStatusMessage();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAddUsername.Text))
                MessageBox.Show("Username may not be empty");
            try
            {
                var u = textBoxAddUsername.Text;
                var jid = new JID(u, Server, null);
                var nick = textBoxAddNickname.Text;
                if (string.IsNullOrEmpty(nick))
                    nick = null;
                var group = textBoxAddGroupname.Text;
                if (!string.IsNullOrEmpty(group))
                {
                    rosterTree1.AddGroup(group);
                    jabberClient1.Subscribe(jid, nick, new string[] { group });
                }
                else
                    jabberClient1.Subscribe(jid, nick, null);

                jabberClient1.GetRoster();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message + ex.StackTrace);
                MessageBox.Show("Exception: " + ex.Message + ex.StackTrace);
            }
            
        }

    }
}