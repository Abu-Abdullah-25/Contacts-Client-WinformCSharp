namespace ContactApiClient
{
    partial class ctrlContactCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlContactCard));
            groupBox1 = new GroupBox();
            llEditContactInfo = new LinkLabel();
            pbPersonImage = new PictureBox();
            lblCountry = new Label();
            lblDateOfBirth = new Label();
            lblAddress = new Label();
            lblPhone = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblContactID = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(llEditContactInfo);
            groupBox1.Controls.Add(pbPersonImage);
            groupBox1.Controls.Add(lblCountry);
            groupBox1.Controls.Add(lblDateOfBirth);
            groupBox1.Controls.Add(lblAddress);
            groupBox1.Controls.Add(lblPhone);
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(lblEmail);
            groupBox1.Controls.Add(lblContactID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(9, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 358);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Contact Information";
            // 
            // llEditContactInfo
            // 
            llEditContactInfo.AutoSize = true;
            llEditContactInfo.Location = new Point(349, 85);
            llEditContactInfo.Name = "llEditContactInfo";
            llEditContactInfo.Size = new Size(96, 15);
            llEditContactInfo.TabIndex = 17;
            llEditContactInfo.TabStop = true;
            llEditContactInfo.Text = "Edit Contact Info";
            llEditContactInfo.LinkClicked += llEditContactInfo_LinkClicked;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BorderStyle = BorderStyle.FixedSingle;
            pbPersonImage.Image = (Image)resources.GetObject("pbPersonImage.Image");
            pbPersonImage.Location = new Point(329, 124);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(138, 159);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 16;
            pbPersonImage.TabStop = false;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountry.ForeColor = Color.FromArgb(23, 24, 27);
            lblCountry.Location = new Point(120, 302);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(33, 18);
            lblCountry.TabIndex = 15;
            lblCountry.Text = "[???]";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateOfBirth.ForeColor = Color.FromArgb(23, 24, 27);
            lblDateOfBirth.Location = new Point(120, 265);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(33, 18);
            lblDateOfBirth.TabIndex = 14;
            lblDateOfBirth.Text = "[???]";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddress.ForeColor = Color.FromArgb(23, 24, 27);
            lblAddress.Location = new Point(122, 228);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(33, 18);
            lblAddress.TabIndex = 13;
            lblAddress.Text = "[???]";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPhone.ForeColor = Color.FromArgb(23, 24, 27);
            lblPhone.Location = new Point(122, 191);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(33, 18);
            lblPhone.TabIndex = 12;
            lblPhone.Text = "[???]";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(23, 24, 27);
            lblName.Location = new Point(122, 111);
            lblName.Name = "lblName";
            lblName.Size = new Size(33, 18);
            lblName.TabIndex = 11;
            lblName.Text = "[???]";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(23, 24, 27);
            lblEmail.Location = new Point(122, 152);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(33, 18);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "[???]";
            // 
            // lblContactID
            // 
            lblContactID.AutoSize = true;
            lblContactID.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContactID.ForeColor = Color.FromArgb(192, 0, 0);
            lblContactID.Location = new Point(122, 67);
            lblContactID.Name = "lblContactID";
            lblContactID.Size = new Size(31, 18);
            lblContactID.TabIndex = 9;
            lblContactID.Text = "N/A";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(24, 299);
            label7.Name = "label7";
            label7.Size = new Size(60, 18);
            label7.TabIndex = 6;
            label7.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 264);
            label6.Name = "label6";
            label6.Size = new Size(85, 18);
            label6.TabIndex = 5;
            label6.Text = "DateOfBirth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 227);
            label5.Name = "label5";
            label5.Size = new Size(59, 18);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 111);
            label4.Name = "label4";
            label4.Size = new Size(44, 18);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 152);
            label3.Name = "label3";
            label3.Size = new Size(43, 18);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 190);
            label2.Name = "label2";
            label2.Size = new Size(48, 18);
            label2.TabIndex = 1;
            label2.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 67);
            label1.Name = "label1";
            label1.Size = new Size(76, 18);
            label1.TabIndex = 0;
            label1.Text = "Contact ID";
            // 
            // ctrlContactCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ctrlContactCard";
            Size = new Size(497, 374);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblPhone;
        private Label lblName;
        private Label lblEmail;
        private Label lblContactID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel llEditContactInfo;
        private PictureBox pbPersonImage;
        private Label lblCountry;
        private Label lblDateOfBirth;
        private Label lblAddress;
    }
}
