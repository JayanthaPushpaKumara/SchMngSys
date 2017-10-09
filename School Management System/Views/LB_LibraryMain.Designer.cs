namespace School_Management_System
{
    partial class LibraryMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryMain));
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.btnLending = new MetroFramework.Controls.MetroButton();
            this.btnReturn = new MetroFramework.Controls.MetroButton();
            this.btnFine = new MetroFramework.Controls.MetroButton();
            this.btnBook = new MetroFramework.Controls.MetroButton();
            this.btnUser = new MetroFramework.Controls.MetroButton();
            this.btnSettings = new MetroFramework.Controls.MetroButton();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.btnFront = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Cyan;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.DisplayFocus = true;
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegister.Location = new System.Drawing.Point(47, 121);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(108, 73);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register new\r\nstudent";
            this.btnRegister.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnRegister.UseCustomBackColor = true;
            this.btnRegister.UseSelectable = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLending
            // 
            this.btnLending.BackColor = System.Drawing.Color.Cyan;
            this.btnLending.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLending.Location = new System.Drawing.Point(235, 121);
            this.btnLending.Name = "btnLending";
            this.btnLending.Size = new System.Drawing.Size(108, 73);
            this.btnLending.TabIndex = 1;
            this.btnLending.Text = "Lending Book";
            this.btnLending.UseCustomBackColor = true;
            this.btnLending.UseSelectable = true;
            this.btnLending.Click += new System.EventHandler(this.btnLending_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Cyan;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Location = new System.Drawing.Point(419, 121);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(108, 73);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return Book";
            this.btnReturn.UseCustomBackColor = true;
            this.btnReturn.UseSelectable = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnFine
            // 
            this.btnFine.BackColor = System.Drawing.Color.Cyan;
            this.btnFine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFine.Location = new System.Drawing.Point(597, 121);
            this.btnFine.Name = "btnFine";
            this.btnFine.Size = new System.Drawing.Size(108, 73);
            this.btnFine.TabIndex = 3;
            this.btnFine.Text = "Fine";
            this.btnFine.UseCustomBackColor = true;
            this.btnFine.UseSelectable = true;
            this.btnFine.Click += new System.EventHandler(this.btnFine_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.Cyan;
            this.btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook.Location = new System.Drawing.Point(47, 254);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(108, 73);
            this.btnBook.TabIndex = 5;
            this.btnBook.Text = "Book";
            this.btnBook.UseCustomBackColor = true;
            this.btnBook.UseSelectable = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Cyan;
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUser.Location = new System.Drawing.Point(235, 254);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(108, 73);
            this.btnUser.TabIndex = 6;
            this.btnUser.Text = "User";
            this.btnUser.UseCustomBackColor = true;
            this.btnUser.UseCustomForeColor = true;
            this.btnUser.UseSelectable = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Cyan;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.Location = new System.Drawing.Point(419, 254);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(108, 73);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseCustomBackColor = true;
            this.btnSettings.UseSelectable = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(116, 48);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.settingsToolStripMenuItem.Text = "settings";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutToolStripMenuItem.Text = "log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(747, 15);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 43);
            this.btnExit.TabIndex = 9;
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.metroButton9_Click);
            // 
            // btnFront
            // 
            this.btnFront.AutoSize = true;
            this.btnFront.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFront.BackgroundImage")));
            this.btnFront.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFront.Location = new System.Drawing.Point(709, 365);
            this.btnFront.Name = "btnFront";
            this.btnFront.Size = new System.Drawing.Size(80, 60);
            this.btnFront.TabIndex = 24;
            this.btnFront.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnFront.UseSelectable = true;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Location = new System.Drawing.Point(26, 365);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 60);
            this.btnBack.TabIndex = 23;
            this.btnBack.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LibraryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnFront);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnFine);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLending);
            this.Controls.Add(this.btnRegister);
            this.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Movable = false;
            this.Name = "LibraryMain";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Library System";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnRegister;
        private MetroFramework.Controls.MetroButton btnLending;
        private MetroFramework.Controls.MetroButton btnReturn;
        private MetroFramework.Controls.MetroButton btnFine;
        private MetroFramework.Controls.MetroButton btnBook;
        private MetroFramework.Controls.MetroButton btnUser;
        private MetroFramework.Controls.MetroButton btnSettings;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroButton btnFront;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}