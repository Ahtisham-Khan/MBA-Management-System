namespace MBAManagementSystem
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.msAll = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsall = new System.Windows.Forms.ToolStrip();
            this.tsbLogin = new System.Windows.Forms.ToolStripButton();
            this.tsbLogout = new System.Windows.Forms.ToolStripSplitButton();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msAll.SuspendLayout();
            this.tsall.SuspendLayout();
            this.SuspendLayout();
            // 
            // msAll
            // 
            this.msAll.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.purchasingToolStripMenuItem,
            this.sellingToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.msAll.Location = new System.Drawing.Point(0, 0);
            this.msAll.Name = "msAll";
            this.msAll.Size = new System.Drawing.Size(889, 24);
            this.msAll.TabIndex = 0;
            this.msAll.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // purchasingToolStripMenuItem
            // 
            this.purchasingToolStripMenuItem.Name = "purchasingToolStripMenuItem";
            this.purchasingToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.purchasingToolStripMenuItem.Text = "Purchases";
            this.purchasingToolStripMenuItem.Click += new System.EventHandler(this.purchasingToolStripMenuItem_Click);
            // 
            // sellingToolStripMenuItem
            // 
            this.sellingToolStripMenuItem.Name = "sellingToolStripMenuItem";
            this.sellingToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.sellingToolStripMenuItem.Text = "Sales";
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userSettingsToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // userSettingsToolStripMenuItem
            // 
            this.userSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserTypeToolStripMenuItem,
            this.addUsersToolStripMenuItem});
            this.userSettingsToolStripMenuItem.Name = "userSettingsToolStripMenuItem";
            this.userSettingsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.userSettingsToolStripMenuItem.Text = "User Settings";
            // 
            // addUserTypeToolStripMenuItem
            // 
            this.addUserTypeToolStripMenuItem.Name = "addUserTypeToolStripMenuItem";
            this.addUserTypeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addUserTypeToolStripMenuItem.Text = "User Types";
            this.addUserTypeToolStripMenuItem.Click += new System.EventHandler(this.addUserTypeToolStripMenuItem_Click);
            // 
            // addUsersToolStripMenuItem
            // 
            this.addUsersToolStripMenuItem.Name = "addUsersToolStripMenuItem";
            this.addUsersToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.addUsersToolStripMenuItem.Text = "Add Users";
            this.addUsersToolStripMenuItem.Click += new System.EventHandler(this.addUsersToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // tsall
            // 
            this.tsall.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsall.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLogin,
            this.tsbLogout});
            this.tsall.Location = new System.Drawing.Point(0, 24);
            this.tsall.Name = "tsall";
            this.tsall.Size = new System.Drawing.Size(889, 46);
            this.tsall.TabIndex = 1;
            this.tsall.Text = "toolStrip1";
            // 
            // tsbLogin
            // 
            this.tsbLogin.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbLogin.Image = ((System.Drawing.Image)(resources.GetObject("tsbLogin.Image")));
            this.tsbLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLogin.Name = "tsbLogin";
            this.tsbLogin.Size = new System.Drawing.Size(41, 43);
            this.tsbLogin.Text = "Login";
            this.tsbLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLogin.Click += new System.EventHandler(this.tsbLogin_Click);
            // 
            // tsbLogout
            // 
            this.tsbLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbLogout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem});
            this.tsbLogout.Image = ((System.Drawing.Image)(resources.GetObject("tsbLogout.Image")));
            this.tsbLogout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLogout.Name = "tsbLogout";
            this.tsbLogout.Size = new System.Drawing.Size(61, 43);
            this.tsbLogout.Text = "Logout";
            this.tsbLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbLogout.Visible = false;
            this.tsbLogout.ButtonClick += new System.EventHandler(this.tsbLogout_ButtonClick);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.changePasswordToolStripMenuItem.Text = "Update Profile";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 466);
            this.Controls.Add(this.tsall);
            this.Controls.Add(this.msAll);
            this.MainMenuStrip = this.msAll;
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ahtisham Business Associates Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.msAll.ResumeLayout(false);
            this.msAll.PerformLayout();
            this.tsall.ResumeLayout(false);
            this.tsall.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsall;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUsersToolStripMenuItem;
        public System.Windows.Forms.ToolStripButton tsbLogin;
        public System.Windows.Forms.ToolStripSplitButton tsbLogout;
        public System.Windows.Forms.MenuStrip msAll;
    }
}