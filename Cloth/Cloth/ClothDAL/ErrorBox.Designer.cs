namespace ClothDAL
{
    partial class ErrorBox
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
            this.lbl_errorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_errorMsg
            // 
            this.lbl_errorMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_errorMsg.AutoSize = true;
            this.lbl_errorMsg.Location = new System.Drawing.Point(63, 34);
            this.lbl_errorMsg.Name = "lbl_errorMsg";
            this.lbl_errorMsg.Size = new System.Drawing.Size(23, 12);
            this.lbl_errorMsg.TabIndex = 0;
            this.lbl_errorMsg.Text = "lbl";
            // 
            // ErrorBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 174);
            this.Controls.Add(this.lbl_errorMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorBox";
            this.Text = "ErrorBox";
            this.Load += new System.EventHandler(this.ErrorBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_errorMsg;
    }
}