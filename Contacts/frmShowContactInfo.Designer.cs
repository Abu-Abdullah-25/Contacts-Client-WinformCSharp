namespace ContactApiClient
{
    partial class frmShowContactInfo
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
            ctrlContactCard1 = new ctrlContactCard();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // ctrlContactCard1
            // 
            ctrlContactCard1.Location = new Point(12, 63);
            ctrlContactCard1.Name = "ctrlContactCard1";
            ctrlContactCard1.Size = new Size(614, 347);
            ctrlContactCard1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 64, 64);
            label1.Location = new Point(252, 18);
            label1.Name = "label1";
            label1.Size = new Size(147, 24);
            label1.TabIndex = 1;
            label1.Text = "Contact Details";
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(506, 421);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(109, 36);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "iconButton1";
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // frmShowContactInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 465);
            Controls.Add(iconButton1);
            Controls.Add(label1);
            Controls.Add(ctrlContactCard1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmShowContactInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Show Contact Info";
       
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlContactCard ctrlContactCard1;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}