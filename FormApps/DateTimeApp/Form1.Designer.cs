namespace DateTimeApp {
    partial class nudDay {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            dtpBirthday = new DateTimePicker();
            btDateCount = new Button();
            tbDisp = new TextBox();
            numericUpDown1 = new NumericUpDown();
            btDayBefore = new Button();
            btDayAfter = new Button();
            btAge = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(79, 48);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpBirthday
            // 
            dtpBirthday.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpBirthday.Location = new Point(169, 43);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 39);
            dtpBirthday.TabIndex = 1;
            // 
            // btDateCount
            // 
            btDateCount.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDateCount.Location = new Point(169, 126);
            btDateCount.Name = "btDateCount";
            btDateCount.Size = new Size(200, 68);
            btDateCount.TabIndex = 2;
            btDateCount.Text = "今日までの日数";
            btDateCount.UseVisualStyleBackColor = true;
            btDateCount.Click += btDateCount_Click;
            // 
            // tbDisp
            // 
            tbDisp.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbDisp.Location = new Point(36, 347);
            tbDisp.Name = "tbDisp";
            tbDisp.Size = new Size(333, 39);
            tbDisp.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            numericUpDown1.Location = new Point(79, 245);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 46);
            numericUpDown1.TabIndex = 4;
            // 
            // btDayBefore
            // 
            btDayBefore.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDayBefore.Location = new Point(250, 215);
            btDayBefore.Name = "btDayBefore";
            btDayBefore.Size = new Size(119, 46);
            btDayBefore.TabIndex = 5;
            btDayBefore.Text = "日前";
            btDayBefore.UseVisualStyleBackColor = true;
            btDayBefore.Click += btDayBefore_Click;
            // 
            // btDayAfter
            // 
            btDayAfter.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDayAfter.Location = new Point(250, 280);
            btDayAfter.Name = "btDayAfter";
            btDayAfter.Size = new Size(119, 46);
            btDayAfter.TabIndex = 5;
            btDayAfter.Text = "日後";
            btDayAfter.UseVisualStyleBackColor = true;
            btDayAfter.Click += btDayAfter_Click;
            // 
            // btAge
            // 
            btAge.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btAge.Location = new Point(387, 215);
            btAge.Name = "btAge";
            btAge.Size = new Size(109, 46);
            btAge.TabIndex = 6;
            btAge.Text = "年齢";
            btAge.UseVisualStyleBackColor = true;
            btAge.Click += btAge_Click;
            // 
            // nudDay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 439);
            Controls.Add(btAge);
            Controls.Add(btDayAfter);
            Controls.Add(btDayBefore);
            Controls.Add(numericUpDown1);
            Controls.Add(tbDisp);
            Controls.Add(btDateCount);
            Controls.Add(dtpBirthday);
            Controls.Add(label1);
            Name = "nudDay";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpBirthday;
        private Button btDateCount;
        private TextBox tbDisp;
        private NumericUpDown numericUpDown1;
        private Button btDayBefore;
        private Button btDayAfter;
        private Button btAge;
    }
}
