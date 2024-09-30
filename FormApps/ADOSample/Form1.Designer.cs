namespace ADOSample {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label genderLabel;
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.booksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.booksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.tableAdapterManager = new ADOSample.infosys202402DataSetTableAdapters.TableAdapterManager();
            this.booksTableAdapter = new ADOSample.infosys202402DataSetTableAdapters.BooksTableAdapter();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.infosys202402DataSet = new ADOSample.infosys202402DataSet();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter = new ADOSample.infosys202402DataSetTableAdapters.AuthorsTableAdapter();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingNavigator)).BeginInit();
            this.booksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202402DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AutoGenerateColumns = false;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.publishedYearDataGridViewTextBoxColumn,
            this.authorIdDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn});
            this.booksDataGridView.DataSource = this.booksBindingSource;
            this.booksDataGridView.Location = new System.Drawing.Point(12, 28);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.RowTemplate.Height = 21;
            this.booksDataGridView.Size = new System.Drawing.Size(779, 230);
            this.booksDataGridView.TabIndex = 1;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // booksBindingNavigatorSaveItem
            // 
            this.booksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.booksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("booksBindingNavigatorSaveItem.Image")));
            this.booksBindingNavigatorSaveItem.Name = "booksBindingNavigatorSaveItem";
            this.booksBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.booksBindingNavigatorSaveItem.Text = "データの保存";
            this.booksBindingNavigatorSaveItem.Click += new System.EventHandler(this.booksBindingNavigatorSaveItem_Click);
            // 
            // booksBindingNavigator
            // 
            this.booksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.booksBindingNavigator.BindingSource = this.booksBindingSource;
            this.booksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.booksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.booksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.booksBindingNavigatorSaveItem});
            this.booksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.booksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.booksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.booksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.booksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.booksBindingNavigator.Name = "booksBindingNavigator";
            this.booksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.booksBindingNavigator.Size = new System.Drawing.Size(811, 25);
            this.booksBindingNavigator.TabIndex = 0;
            this.booksBindingNavigator.Text = "bindingNavigator1";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorsTableAdapter = this.authorsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.UpdateOrder = ADOSample.infosys202402DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.infosys202402DataSet;
            // 
            // infosys202402DataSet
            // 
            this.infosys202402DataSet.DataSetName = "infosys202402DataSet";
            this.infosys202402DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // publishedYearDataGridViewTextBoxColumn
            // 
            this.publishedYearDataGridViewTextBoxColumn.DataPropertyName = "PublishedYear";
            this.publishedYearDataGridViewTextBoxColumn.HeaderText = "PublishedYear";
            this.publishedYearDataGridViewTextBoxColumn.Name = "publishedYearDataGridViewTextBoxColumn";
            // 
            // authorIdDataGridViewTextBoxColumn
            // 
            this.authorIdDataGridViewTextBoxColumn.DataPropertyName = "Author_Id";
            this.authorIdDataGridViewTextBoxColumn.HeaderText = "Author_Id";
            this.authorIdDataGridViewTextBoxColumn.Name = "authorIdDataGridViewTextBoxColumn";
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.infosys202402DataSet;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(142, 348);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(16, 12);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(198, 345);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 19);
            this.idTextBox.TabIndex = 3;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(142, 373);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(36, 12);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(198, 370);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 19);
            this.nameTextBox.TabIndex = 5;
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(142, 399);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(50, 12);
            birthdayLabel.TabIndex = 6;
            birthdayLabel.Text = "Birthday:";
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(198, 395);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.birthdayDateTimePicker.TabIndex = 7;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(142, 423);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(43, 12);
            genderLabel.TabIndex = 8;
            genderLabel.Text = "Gender:";
            // 
            // genderTextBox
            // 
            this.genderTextBox.Location = new System.Drawing.Point(198, 420);
            this.genderTextBox.Name = "genderTextBox";
            this.genderTextBox.Size = new System.Drawing.Size(200, 19);
            this.genderTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 459);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderTextBox);
            this.Controls.Add(this.booksDataGridView);
            this.Controls.Add(this.booksBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingNavigator)).EndInit();
            this.booksBindingNavigator.ResumeLayout(false);
            this.booksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202402DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private infosys202402DataSet infosys202402DataSet;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton booksBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator booksBindingNavigator;
        private infosys202402DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private infosys202402DataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private infosys202402DataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox genderTextBox;
    }
}

