namespace CarReportSystem {
    partial class Form1 {
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
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            cbAuthor = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            cbCarName = new ComboBox();
            groupBox1 = new GroupBox();
            rbOther = new RadioButton();
            rbImport = new RadioButton();
            rbSubaru = new RadioButton();
            rbHonda = new RadioButton();
            rbNissan = new RadioButton();
            rbToyota = new RadioButton();
            tbReport = new TextBox();
            label6 = new Label();
            btPicOpen = new Button();
            btPicDelete = new Button();
            pbPicture = new PictureBox();
            btAddReport = new Button();
            btModifyReport = new Button();
            btDeleteReport = new Button();
            label7 = new Label();
            dgvCarReport = new DataGridView();
            ofdPicFileOpen = new OpenFileDialog();
            ssMassageArea = new StatusStrip();
            tlssMassageArea = new ToolStripStatusLabel();
            sfdReportFileSave = new SaveFileDialog();
            ofdReportFIleOpen = new OpenFileDialog();
            btInputItemsClear = new Button();
            menuStrip1 = new MenuStrip();
            ファイルToolStripMenuItem = new ToolStripMenuItem();
            開くToolStripMenuItem = new ToolStripMenuItem();
            保存ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            色設定ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            cdColor = new ColorDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).BeginInit();
            ssMassageArea.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 0;
            label1.Text = "日付：";
            // 
            // dtpDate
            // 
            dtpDate.CalendarFont = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(102, 31);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 33);
            dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(8, 76);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 0;
            label2.Text = "記録者：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(14, 123);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 0;
            label3.Text = "メーカー：";
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(102, 73);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(244, 33);
            cbAuthor.TabIndex = 2;
            cbAuthor.TextChanged += cbAuthor_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(27, 167);
            label4.Name = "label4";
            label4.Size = new Size(69, 25);
            label4.TabIndex = 0;
            label4.Text = "車名：";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(10, 218);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 0;
            label5.Text = "レポート：";
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(102, 167);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(244, 33);
            cbCarName.TabIndex = 2;
            cbCarName.TextChanged += cbCarName_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbImport);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Location = new Point(102, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 39);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Checked = true;
            rbOther.Location = new Point(299, 17);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(56, 19);
            rbOther.TabIndex = 0;
            rbOther.TabStop = true;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            rbImport.AutoSize = true;
            rbImport.Location = new Point(232, 17);
            rbImport.Name = "rbImport";
            rbImport.Size = new Size(61, 19);
            rbImport.TabIndex = 0;
            rbImport.Text = "輸入車";
            rbImport.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Location = new Point(177, 17);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(54, 19);
            rbSubaru.TabIndex = 0;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Location = new Point(122, 17);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(53, 19);
            rbHonda.TabIndex = 0;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Location = new Point(67, 17);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(49, 19);
            rbNissan.TabIndex = 0;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Location = new Point(11, 17);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(50, 19);
            rbToyota.TabIndex = 0;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // tbReport
            // 
            tbReport.Location = new Point(102, 218);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(391, 113);
            tbReport.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(499, 39);
            label6.Name = "label6";
            label6.Size = new Size(69, 25);
            label6.TabIndex = 0;
            label6.Text = "画像：";
            // 
            // btPicOpen
            // 
            btPicOpen.BackColor = Color.AliceBlue;
            btPicOpen.Location = new Point(574, 39);
            btPicOpen.Name = "btPicOpen";
            btPicOpen.Size = new Size(88, 25);
            btPicOpen.TabIndex = 5;
            btPicOpen.Text = "開く…";
            btPicOpen.UseVisualStyleBackColor = false;
            btPicOpen.Click += btPicOpen_Click;
            // 
            // btPicDelete
            // 
            btPicDelete.BackColor = SystemColors.ActiveCaption;
            btPicDelete.Location = new Point(668, 39);
            btPicDelete.Name = "btPicDelete";
            btPicDelete.Size = new Size(88, 25);
            btPicDelete.TabIndex = 5;
            btPicDelete.Text = "削除";
            btPicDelete.UseVisualStyleBackColor = false;
            btPicDelete.Click += btPicDelete_Click;
            // 
            // pbPicture
            // 
            pbPicture.BackColor = Color.White;
            pbPicture.Location = new Point(513, 71);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(243, 205);
            pbPicture.SizeMode = PictureBoxSizeMode.Zoom;
            pbPicture.TabIndex = 6;
            pbPicture.TabStop = false;
            // 
            // btAddReport
            // 
            btAddReport.BackColor = Color.Azure;
            btAddReport.Font = new Font("Yu Gothic UI", 12F);
            btAddReport.Location = new Point(496, 293);
            btAddReport.Name = "btAddReport";
            btAddReport.Size = new Size(66, 38);
            btAddReport.TabIndex = 5;
            btAddReport.Text = "追加";
            btAddReport.UseVisualStyleBackColor = false;
            btAddReport.Click += btAddReport_Click;
            // 
            // btModifyReport
            // 
            btModifyReport.BackColor = Color.Azure;
            btModifyReport.Font = new Font("Yu Gothic UI", 12F);
            btModifyReport.Location = new Point(568, 293);
            btModifyReport.Name = "btModifyReport";
            btModifyReport.Size = new Size(66, 38);
            btModifyReport.TabIndex = 5;
            btModifyReport.Text = "修正";
            btModifyReport.UseVisualStyleBackColor = false;
            btModifyReport.Click += btModifyReport_Click;
            // 
            // btDeleteReport
            // 
            btDeleteReport.BackColor = SystemColors.ActiveCaption;
            btDeleteReport.Font = new Font("Yu Gothic UI", 12F);
            btDeleteReport.Location = new Point(712, 293);
            btDeleteReport.Name = "btDeleteReport";
            btDeleteReport.Size = new Size(66, 38);
            btDeleteReport.TabIndex = 5;
            btDeleteReport.Text = "削除";
            btDeleteReport.UseVisualStyleBackColor = false;
            btDeleteReport.Click += btDeleteReport_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(27, 348);
            label7.Name = "label7";
            label7.Size = new Size(69, 25);
            label7.TabIndex = 0;
            label7.Text = "一覧：";
            // 
            // dgvCarReport
            // 
            dgvCarReport.AllowUserToAddRows = false;
            dgvCarReport.AllowUserToDeleteRows = false;
            dgvCarReport.AllowUserToResizeRows = false;
            dgvCarReport.BackgroundColor = Color.White;
            dgvCarReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarReport.Location = new Point(102, 348);
            dgvCarReport.MultiSelect = false;
            dgvCarReport.Name = "dgvCarReport";
            dgvCarReport.ReadOnly = true;
            dgvCarReport.RowHeadersVisible = false;
            dgvCarReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarReport.Size = new Size(654, 160);
            dgvCarReport.TabIndex = 7;
            dgvCarReport.Click += dgvCarReport_Click;
            // 
            // ofdPicFileOpen
            // 
            ofdPicFileOpen.FileName = "openFileDialog1";
            // 
            // ssMassageArea
            // 
            ssMassageArea.BackColor = Color.White;
            ssMassageArea.Items.AddRange(new ToolStripItem[] { tlssMassageArea });
            ssMassageArea.Location = new Point(0, 522);
            ssMassageArea.Name = "ssMassageArea";
            ssMassageArea.Size = new Size(784, 22);
            ssMassageArea.SizingGrip = false;
            ssMassageArea.TabIndex = 8;
            ssMassageArea.Text = "statusStrip1";
            // 
            // tlssMassageArea
            // 
            tlssMassageArea.Name = "tlssMassageArea";
            tlssMassageArea.Size = new Size(0, 17);
            // 
            // ofdReportFIleOpen
            // 
            ofdReportFIleOpen.FileName = "openFileDialog1";
            // 
            // btInputItemsClear
            // 
            btInputItemsClear.BackColor = Color.Azure;
            btInputItemsClear.Font = new Font("Yu Gothic UI", 12F);
            btInputItemsClear.ForeColor = SystemColors.ActiveCaptionText;
            btInputItemsClear.Location = new Point(640, 293);
            btInputItemsClear.Name = "btInputItemsClear";
            btInputItemsClear.Size = new Size(66, 38);
            btInputItemsClear.TabIndex = 5;
            btInputItemsClear.Text = "クリア";
            btInputItemsClear.UseVisualStyleBackColor = false;
            btInputItemsClear.Click += btInputItemsClear_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(784, 24);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            ファイルToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 開くToolStripMenuItem, 保存ToolStripMenuItem, toolStripSeparator1, 色設定ToolStripMenuItem, toolStripSeparator2, 終了ToolStripMenuItem });
            ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            ファイルToolStripMenuItem.Size = new Size(67, 20);
            ファイルToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くToolStripMenuItem
            // 
            開くToolStripMenuItem.Name = "開くToolStripMenuItem";
            開くToolStripMenuItem.Size = new Size(119, 22);
            開くToolStripMenuItem.Text = "開く…";
            開くToolStripMenuItem.Click += 開くToolStripMenuItem_Click;
            // 
            // 保存ToolStripMenuItem
            // 
            保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            保存ToolStripMenuItem.Size = new Size(119, 22);
            保存ToolStripMenuItem.Text = "保存…";
            保存ToolStripMenuItem.Click += 保存ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(116, 6);
            // 
            // 色設定ToolStripMenuItem
            // 
            色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            色設定ToolStripMenuItem.Size = new Size(119, 22);
            色設定ToolStripMenuItem.Text = "色設定…";
            色設定ToolStripMenuItem.Click += 色設定ToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(116, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.Size = new Size(119, 22);
            終了ToolStripMenuItem.Text = "終了";
            終了ToolStripMenuItem.Click += 終了ToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(784, 544);
            Controls.Add(ssMassageArea);
            Controls.Add(menuStrip1);
            Controls.Add(dgvCarReport);
            Controls.Add(pbPicture);
            Controls.Add(btInputItemsClear);
            Controls.Add(btDeleteReport);
            Controls.Add(btModifyReport);
            Controls.Add(btAddReport);
            Controls.Add(btPicDelete);
            Controls.Add(btPicOpen);
            Controls.Add(tbReport);
            Controls.Add(groupBox1);
            Controls.Add(cbCarName);
            Controls.Add(cbAuthor);
            Controls.Add(dtpDate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "試乗レポート管理システム";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarReport).EndInit();
            ssMassageArea.ResumeLayout(false);
            ssMassageArea.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label2;
        private Label label3;
        private ComboBox cbAuthor;
        private Label label4;
        private Label label5;
        private ComboBox cbCarName;
        private GroupBox groupBox1;
        private RadioButton rbOther;
        private RadioButton rbImport;
        private RadioButton rbSubaru;
        private RadioButton rbHonda;
        private RadioButton rbNissan;
        private RadioButton rbToyota;
        private TextBox tbReport;
        private Label label6;
        private Button btPicOpen;
        private Button btPicDelete;
        private PictureBox pbPicture;
        private Button btAddReport;
        private Button btModifyReport;
        private Button btDeleteReport;
        private Label label7;
        private DataGridView dgvCarReport;
        private OpenFileDialog ofdPicFileOpen;
        private StatusStrip ssMassageArea;
        private ToolStripStatusLabel tlssMassageArea;
        private SaveFileDialog sfdReportFileSave;
        private OpenFileDialog ofdReportFIleOpen;
        private Button btInputItemsClear;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルToolStripMenuItem;
        private ToolStripMenuItem 開くToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 色設定ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem 終了ToolStripMenuItem;
        private ColorDialog cdColor;
    }
}
