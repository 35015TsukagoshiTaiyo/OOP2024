using System.Windows.Forms;

namespace RssReader {
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
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.cbRssUrl = new System.Windows.Forms.ComboBox();
            this.tbFavorite = new System.Windows.Forms.TextBox();
            this.btFavorite = new System.Windows.Forms.Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btGet.Location = new System.Drawing.Point(912, 27);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(86, 27);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 16;
            this.lbRssTitle.Location = new System.Drawing.Point(12, 131);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(310, 564);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // cbRssUrl
            // 
            this.cbRssUrl.BackColor = System.Drawing.Color.White;
            this.cbRssUrl.Font = new System.Drawing.Font("HGS創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbRssUrl.FormattingEnabled = true;
            this.cbRssUrl.Location = new System.Drawing.Point(328, 27);
            this.cbRssUrl.Name = "cbRssUrl";
            this.cbRssUrl.Size = new System.Drawing.Size(560, 27);
            this.cbRssUrl.TabIndex = 5;
            // 
            // tbFavorite
            // 
            this.tbFavorite.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFavorite.Location = new System.Drawing.Point(328, 79);
            this.tbFavorite.Name = "tbFavorite";
            this.tbFavorite.Size = new System.Drawing.Size(319, 26);
            this.tbFavorite.TabIndex = 6;
            // 
            // btFavorite
            // 
            this.btFavorite.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btFavorite.Location = new System.Drawing.Point(669, 79);
            this.btFavorite.Name = "btFavorite";
            this.btFavorite.Size = new System.Drawing.Size(123, 26);
            this.btFavorite.TabIndex = 7;
            this.btFavorite.Text = "お気に入り";
            this.btFavorite.UseVisualStyleBackColor = true;
            this.btFavorite.Click += new System.EventHandler(this.btFavorite_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(328, 131);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(802, 564);
            this.webView21.TabIndex = 8;
            this.webView21.ZoomFactor = 1D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "URLまたはお気に入り名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "お気に入り追加又は削除：";
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDelete.Location = new System.Drawing.Point(797, 78);
            this.btDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(123, 26);
            this.btDelete.TabIndex = 11;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::RssReader.Properties.Resources.white_00114;
            this.ClientSize = new System.Drawing.Size(1145, 703);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.btFavorite);
            this.Controls.Add(this.tbFavorite);
            this.Controls.Add(this.cbRssUrl);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.ComboBox cbRssUrl;
        private System.Windows.Forms.TextBox tbFavorite;
        private System.Windows.Forms.Button btFavorite;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Button btDelete;
    }
}

