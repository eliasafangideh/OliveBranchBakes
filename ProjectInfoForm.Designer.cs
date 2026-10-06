namespace OliveBranchBakes
{
    partial class ProjectInfoForm
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
            lblInfo = new Label();
            SuspendLayout();
            // 
            // lblInfo
            // 
            lblInfo.Font = new Font("Segoe UI", 12F);
            lblInfo.Location = new Point(328, 92);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(700, 350);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "label1";

            // 
            // ProjectInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(lblInfo);
            Name = "ProjectInfoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Olive Branch Bakes-Phase 1";
            ResumeLayout(false);
        }

        #endregion

        private Label lblInfo;
    }
}
