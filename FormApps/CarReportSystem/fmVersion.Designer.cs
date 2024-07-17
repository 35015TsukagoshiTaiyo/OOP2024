namespace CarReportSystem {
    partial class fmVersion {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btVersionOK = new Button();
            lbTitle = new Label();
            lbVersion = new Label();
            lbCopyRight = new Label();
            lbCompany = new Label();
            SuspendLayout();
            // 
            // btVersionOK
            // 
            btVersionOK.Location = new Point(312, 183);
            btVersionOK.Name = "btVersionOK";
            btVersionOK.Size = new Size(76, 25);
            btVersionOK.TabIndex = 0;
            btVersionOK.Text = "OK";
            btVersionOK.UseVisualStyleBackColor = true;
            btVersionOK.Click += btVersionOK_Click;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Yu Gothic UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 128);
            lbTitle.Location = new Point(92, 26);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(196, 32);
            lbTitle.TabIndex = 1;
            lbTitle.Text = "カーレポートシステム";
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbVersion.Location = new Point(22, 83);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(81, 25);
            lbVersion.TabIndex = 2;
            lbVersion.Text = "Ver.0.0.1";
            // 
            // lbCopyRight
            // 
            lbCopyRight.AutoSize = true;
            lbCopyRight.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbCopyRight.Location = new Point(22, 135);
            lbCopyRight.Name = "lbCopyRight";
            lbCopyRight.Size = new Size(69, 25);
            lbCopyRight.TabIndex = 3;
            lbCopyRight.Text = "著作権";
            // 
            // lbCompany
            // 
            lbCompany.AutoSize = true;
            lbCompany.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbCompany.Location = new Point(235, 135);
            lbCompany.Name = "lbCompany";
            lbCompany.Size = new Size(69, 25);
            lbCompany.TabIndex = 4;
            lbCompany.Text = "会社名";
            // 
            // fmVersion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 220);
            Controls.Add(lbCompany);
            Controls.Add(lbCopyRight);
            Controls.Add(lbVersion);
            Controls.Add(lbTitle);
            Controls.Add(btVersionOK);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "fmVersion";
            Text = "fmVersion";
            Load += fmVersion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVersionOK;
        private Label lbTitle;
        private Label lbVersion;
        private Label lbCopyRight;
        private Label lbCompany;
    }
}