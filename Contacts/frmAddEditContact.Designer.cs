namespace ContactApiClient
{
    partial class frmAddEditContact
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
            txtFirstName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtLastName = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            txtAddress = new TextBox();
            label6 = new Label();
            label7 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            cbCountries = new ComboBox();
            lblTitle = new Label();
            btnSave = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            pbPersonImage = new PictureBox();
            llOpenFileDialog = new LinkLabel();
            openFileDialog1 = new OpenFileDialog();
            llRemoveImage = new LinkLabel();
            label8 = new Label();
            lblContactID = new Label();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(171, 86);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(207, 23);
            txtFirstName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(64, 84);
            label1.Name = "label1";
            label1.Size = new Size(81, 22);
            label1.TabIndex = 1;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(64, 125);
            label2.Name = "label2";
            label2.Size = new Size(78, 22);
            label2.TabIndex = 3;
            label2.Text = "LastName";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(171, 127);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(207, 23);
            txtLastName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(64, 172);
            label3.Name = "label3";
            label3.Size = new Size(49, 22);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(171, 174);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(207, 23);
            txtEmail.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Silver;
            label4.Location = new Point(64, 222);
            label4.Name = "label4";
            label4.Size = new Size(53, 22);
            label4.TabIndex = 7;
            label4.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(171, 224);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(207, 23);
            txtPhone.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(64, 269);
            label5.Name = "label5";
            label5.Size = new Size(95, 22);
            label5.TabIndex = 9;
            label5.Text = "DateOfBirth";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(171, 367);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(207, 71);
            txtAddress.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(64, 322);
            label6.Name = "label6";
            label6.Size = new Size(65, 22);
            label6.TabIndex = 10;
            label6.Text = "Country";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(64, 368);
            label7.Name = "label7";
            label7.Size = new Size(64, 22);
            label7.TabIndex = 11;
            label7.Text = "Address";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(171, 272);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(207, 23);
            dtpDateOfBirth.TabIndex = 12;
            // 
            // cbCountries
            // 
            cbCountries.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCountries.FormattingEnabled = true;
            cbCountries.Location = new Point(171, 321);
            cbCountries.Name = "cbCountries";
            cbCountries.Size = new Size(207, 23);
            cbCountries.TabIndex = 13;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(224, 224, 224);
            lblTitle.Location = new Point(308, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(178, 27);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Add New Contact";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(24, 23, 27);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Silver;
            btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnSave.IconColor = Color.DarkSlateGray;
            btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSave.IconSize = 40;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(237, 453);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 45);
            btnSave.TabIndex = 15;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(24, 23, 27);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Silver;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            btnClose.IconColor = Color.DarkSlateGray;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 40;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(404, 453);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(110, 45);
            btnClose.TabIndex = 16;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleLeft;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BorderStyle = BorderStyle.FixedSingle;
            pbPersonImage.Location = new Point(562, 111);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(156, 180);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 17;
            pbPersonImage.TabStop = false;
            // 
            // llOpenFileDialog
            // 
            llOpenFileDialog.AutoSize = true;
            llOpenFileDialog.LinkColor = Color.FromArgb(128, 128, 255);
            llOpenFileDialog.Location = new Point(556, 82);
            llOpenFileDialog.Name = "llOpenFileDialog";
            llOpenFileDialog.Size = new Size(59, 15);
            llOpenFileDialog.TabIndex = 18;
            llOpenFileDialog.TabStop = true;
            llOpenFileDialog.Text = "Set Image";
            llOpenFileDialog.LinkClicked += llOpenFileDialog_LinkClicked;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // llRemoveImage
            // 
            llRemoveImage.AutoSize = true;
            llRemoveImage.LinkColor = Color.FromArgb(128, 128, 255);
            llRemoveImage.Location = new Point(642, 82);
            llRemoveImage.Name = "llRemoveImage";
            llRemoveImage.Size = new Size(86, 15);
            llRemoveImage.TabIndex = 19;
            llRemoveImage.TabStop = true;
            llRemoveImage.Text = "Remove Image";
            llRemoveImage.Visible = false;
            llRemoveImage.LinkClicked += llRemoveImage_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(64, 56);
            label8.Name = "label8";
            label8.Size = new Size(79, 22);
            label8.TabIndex = 20;
            label8.Text = "ContactID";
            // 
            // lblContactID
            // 
            lblContactID.AutoSize = true;
            lblContactID.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContactID.ForeColor = Color.Brown;
            lblContactID.Location = new Point(171, 56);
            lblContactID.Name = "lblContactID";
            lblContactID.Size = new Size(40, 22);
            lblContactID.TabIndex = 21;
            lblContactID.Text = "[???]";
            // 
            // frmAddEditContact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 38);
            ClientSize = new Size(750, 510);
            Controls.Add(lblContactID);
            Controls.Add(label8);
            Controls.Add(llRemoveImage);
            Controls.Add(llOpenFileDialog);
            Controls.Add(pbPersonImage);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(lblTitle);
            Controls.Add(cbCountries);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtLastName);
            Controls.Add(label1);
            Controls.Add(txtFirstName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmAddEditContact";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddEditContact";
            Load += frmAddEditContact_Load;
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private Label label1;
        private Label label2;
        private TextBox txtLastName;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtAddress;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cbCountries;
        private Label lblTitle;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnClose;
        private PictureBox pbPersonImage;
        private LinkLabel llOpenFileDialog;
        private OpenFileDialog openFileDialog1;
        private LinkLabel llRemoveImage;
        private Label label8;
        private Label lblContactID;
    }
}