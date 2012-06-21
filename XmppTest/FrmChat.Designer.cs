namespace Gtalk
{
    partial class FrmChat
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.converToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.rtbSendMessage = new System.Windows.Forms.RichTextBox();
            this.rtbConversation = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.converToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // converToolStripMenuItem
            // 
            this.converToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.converToolStripMenuItem.Name = "converToolStripMenuItem";
            this.converToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.converToolStripMenuItem.Text = "Conversation";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 203);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(292, 53);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // rtbSendMessage
            // 
            this.rtbSendMessage.Location = new System.Drawing.Point(0, 213);
            this.rtbSendMessage.Name = "rtbSendMessage";
            this.rtbSendMessage.Size = new System.Drawing.Size(292, 41);
            this.rtbSendMessage.TabIndex = 6;
            this.rtbSendMessage.Text = "";
            this.rtbSendMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbSendMessage_KeyDown);
            // 
            // rtbConversation
            // 
            this.rtbConversation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtbConversation.Location = new System.Drawing.Point(0, 27);
            this.rtbConversation.Name = "rtbConversation";
            this.rtbConversation.ReadOnly = true;
            this.rtbConversation.Size = new System.Drawing.Size(292, 184);
            this.rtbConversation.TabIndex = 7;
            this.rtbConversation.Text = "";
            // 
            // FrmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 256);
            this.Controls.Add(this.rtbConversation);
            this.Controls.Add(this.rtbSendMessage);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmChat";
            this.Text = "Chat";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmChat_FormClosing);
            this.Load += new System.EventHandler(this.FrmChat_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolStripMenuItem converToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbSendMessage;
        private System.Windows.Forms.RichTextBox rtbConversation;
    }
}