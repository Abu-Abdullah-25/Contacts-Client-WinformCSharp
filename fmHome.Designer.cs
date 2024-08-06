namespace ContactApiClient
{
    partial class fmHome
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
            lblTitle = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Teal;
            lblTitle.Location = new Point(314, 208);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(113, 27);
            lblTitle.TabIndex = 15;
            lblTitle.Text = "Main Form";
            // 
            // fmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(35, 36, 38);
            ClientSize = new Size(740, 478);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "fmHome";
            Text = "fmHome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
    }
}