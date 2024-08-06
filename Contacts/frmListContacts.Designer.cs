namespace ContactApiClient
{
    partial class frmListContacts
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
            components = new System.ComponentModel.Container();
            dgvContacts = new DataGridView();
            cmsContacts = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            addNewContactToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            lblRecordsCount = new Label();
            txtFilterValue = new TextBox();
            label3 = new Label();
            btnAddNewContact = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            cmsContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnAddNewContact).BeginInit();
            SuspendLayout();
            // 
            // dgvContacts
            // 
            dgvContacts.AllowUserToAddRows = false;
            dgvContacts.AllowUserToDeleteRows = false;
            dgvContacts.AllowUserToResizeColumns = false;
            dgvContacts.AllowUserToResizeRows = false;
            dgvContacts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvContacts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContacts.Location = new Point(23, 155);
            dgvContacts.Name = "dgvContacts";
            dgvContacts.Size = new Size(689, 286);
            dgvContacts.TabIndex = 0;
            // 
            // cmsContacts
            // 
            cmsContacts.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, addNewContactToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            cmsContacts.Name = "cmsContacts";
            cmsContacts.Size = new Size(169, 92);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(168, 22);
            showDetailsToolStripMenuItem.Text = "&Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // addNewContactToolStripMenuItem
            // 
            addNewContactToolStripMenuItem.Name = "addNewContactToolStripMenuItem";
            addNewContactToolStripMenuItem.Size = new Size(168, 22);
            addNewContactToolStripMenuItem.Text = "&Add New Contact";
            addNewContactToolStripMenuItem.Click += addNewContactToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(168, 22);
            editToolStripMenuItem.Text = "&Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(168, 22);
            deleteToolStripMenuItem.Text = "&Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(27, 127);
            label1.Name = "label1";
            label1.Size = new Size(79, 22);
            label1.TabIndex = 1;
            label1.Text = "FilterBy :";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "None", "Contact ID", "FirstName", "LastName", "Phone", "Email" });
            comboBox1.Location = new Point(111, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(21, 444);
            label2.Name = "label2";
            label2.Size = new Size(91, 22);
            label2.TabIndex = 3;
            label2.Text = "#Records :";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecordsCount.ForeColor = Color.Silver;
            lblRecordsCount.Location = new Point(111, 444);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(19, 22);
            lblRecordsCount.TabIndex = 4;
            lblRecordsCount.Text = "0";
            // 
            // txtFilterValue
            // 
            txtFilterValue.Location = new Point(295, 127);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(165, 23);
            txtFilterValue.TabIndex = 5;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            txtFilterValue.KeyPress += txtFilterValue_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(275, 19);
            label3.Name = "label3";
            label3.Size = new Size(184, 27);
            label3.TabIndex = 7;
            label3.Text = "Manage Contacts";
            // 
            // btnAddNewContact
            // 
            btnAddNewContact.Image = Properties.Resources.Add_Person_72;
            btnAddNewContact.Location = new Point(629, 83);
            btnAddNewContact.Name = "btnAddNewContact";
            btnAddNewContact.Size = new Size(83, 66);
            btnAddNewContact.SizeMode = PictureBoxSizeMode.Zoom;
            btnAddNewContact.TabIndex = 8;
            btnAddNewContact.TabStop = false;
            // 
            // frmListContacts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 38);
            ClientSize = new Size(734, 471);
            ContextMenuStrip = cmsContacts;
            Controls.Add(btnAddNewContact);
            Controls.Add(label3);
            Controls.Add(txtFilterValue);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(dgvContacts);
            Name = "frmListContacts";
            Text = "frmListContacts";
            Load += frmListContacts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
            cmsContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnAddNewContact).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvContacts;
        private ContextMenuStrip cmsContacts;
        private ToolStripMenuItem showDetailsToolStripMenuItem;
        private ToolStripMenuItem addNewContactToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label lblRecordsCount;
        private TextBox txtFilterValue;
        private Label label3;
        private PictureBox btnAddNewContact;
    }
}