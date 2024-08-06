namespace ContactApiClient
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnExit = new FontAwesome.Sharp.IconButton();
            panelManageContactsSubMenu = new Panel();
            btnListContacts = new FontAwesome.Sharp.IconButton();
            btnAddNewContact = new FontAwesome.Sharp.IconButton();
            btnManageContactsMenu = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            btnHome = new FontAwesome.Sharp.IconButton();
            panelChildForm = new Panel();
            panel1.SuspendLayout();
            panelManageContactsSubMenu.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 23, 27);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(panelManageContactsSubMenu);
            panel1.Controls.Add(btnManageContactsMenu);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 517);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.Maroon;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            btnExit.IconColor = Color.Maroon;
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 40;
            btnExit.Location = new Point(0, 482);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(169, 35);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panelManageContactsSubMenu
            // 
            panelManageContactsSubMenu.BackColor = Color.FromArgb(38, 40, 49);
            panelManageContactsSubMenu.Controls.Add(btnListContacts);
            panelManageContactsSubMenu.Controls.Add(btnAddNewContact);
            panelManageContactsSubMenu.Dock = DockStyle.Top;
            panelManageContactsSubMenu.Location = new Point(0, 152);
            panelManageContactsSubMenu.Name = "panelManageContactsSubMenu";
            panelManageContactsSubMenu.Size = new Size(169, 164);
            panelManageContactsSubMenu.TabIndex = 3;
            // 
            // btnListContacts
            // 
            btnListContacts.Dock = DockStyle.Top;
            btnListContacts.FlatAppearance.BorderSize = 0;
            btnListContacts.FlatStyle = FlatStyle.Flat;
            btnListContacts.ForeColor = Color.Silver;
            btnListContacts.IconChar = FontAwesome.Sharp.IconChar.Users;
            btnListContacts.IconColor = Color.DarkSlateGray;
            btnListContacts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnListContacts.IconSize = 40;
            btnListContacts.ImageAlign = ContentAlignment.MiddleLeft;
            btnListContacts.Location = new Point(0, 37);
            btnListContacts.Name = "btnListContacts";
            btnListContacts.Padding = new Padding(12, 0, 0, 0);
            btnListContacts.Size = new Size(169, 37);
            btnListContacts.TabIndex = 3;
            btnListContacts.Text = "List Contacts";
            btnListContacts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnListContacts.UseVisualStyleBackColor = true;
            btnListContacts.Click += btnListContact_Click;
            // 
            // btnAddNewContact
            // 
            btnAddNewContact.Dock = DockStyle.Top;
            btnAddNewContact.FlatAppearance.BorderSize = 0;
            btnAddNewContact.FlatStyle = FlatStyle.Flat;
            btnAddNewContact.ForeColor = Color.Silver;
            btnAddNewContact.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            btnAddNewContact.IconColor = Color.DarkSlateGray;
            btnAddNewContact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAddNewContact.IconSize = 40;
            btnAddNewContact.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNewContact.Location = new Point(0, 0);
            btnAddNewContact.Name = "btnAddNewContact";
            btnAddNewContact.Padding = new Padding(12, 0, 0, 0);
            btnAddNewContact.Size = new Size(169, 37);
            btnAddNewContact.TabIndex = 6;
            btnAddNewContact.Text = "Add New Contact";
            btnAddNewContact.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddNewContact.UseVisualStyleBackColor = true;
            btnAddNewContact.Click += btnAddNewContact_Click;
            // 
            // btnManageContactsMenu
            // 
            btnManageContactsMenu.Dock = DockStyle.Top;
            btnManageContactsMenu.FlatAppearance.BorderSize = 0;
            btnManageContactsMenu.FlatStyle = FlatStyle.Flat;
            btnManageContactsMenu.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageContactsMenu.ForeColor = Color.Silver;
            btnManageContactsMenu.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            btnManageContactsMenu.IconColor = Color.FromArgb(0, 64, 64);
            btnManageContactsMenu.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnManageContactsMenu.IconSize = 40;
            btnManageContactsMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageContactsMenu.Location = new Point(0, 111);
            btnManageContactsMenu.Name = "btnManageContactsMenu";
            btnManageContactsMenu.Size = new Size(169, 41);
            btnManageContactsMenu.TabIndex = 2;
            btnManageContactsMenu.Text = "Manage Contacts";
            btnManageContactsMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnManageContactsMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnManageContactsMenu.UseVisualStyleBackColor = true;
            btnManageContactsMenu.Click += btnManageContactsMenu_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnHome);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(169, 111);
            panel2.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.Archive;
            btnHome.IconColor = Color.Teal;
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(169, 108);
            btnHome.TabIndex = 0;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(35, 36, 38);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(169, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(756, 517);
            panelChildForm.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(925, 517);
            Controls.Add(panelChildForm);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            panel1.ResumeLayout(false);
            panelManageContactsSubMenu.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelChildForm;
        private Panel panelManageContactsSubMenu;
        private FontAwesome.Sharp.IconButton btnManageContactsMenu;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnAddNewContact;
        private FontAwesome.Sharp.IconButton btnListContacts;
    }
}
