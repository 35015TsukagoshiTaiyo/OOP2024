using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //カーレポート管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //コンストラクタ
        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReports;
        }

        //追加ボタン
        private void btAddReport_Click(object sender, EventArgs e) {
            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                //MessageBox.Show("記録者と車名を入力してください。","エラー",
                //                 MessageBoxButtons.OK,MessageBoxIcon.Error);
                tlssMassageArea.Text = "記録者と車名を入力してください。";
                return;
            }
            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            listCarReports.Add(carReport);
            setCbAuthor(cbAuthor.Text);
            setCbCarName(cbCarName.Text);

            inputItemsAllClear(); //入力項目をすべてクリア

        }

        //入力項目をすべてクリア
        private void inputItemsAllClear() {
            //dgvCarReport.ClearSelection(); //セレクションを外す1
            dgvCarReport.CurrentCell = null; //セレクションを外す2
            dtpDate.Value = DateTime.Now;
            cbAuthor.Text = "";
            setRadioButtonMaker(CarReport.MakerGroup.その他);
            cbCarName.Text = "";
            tbReport.Text = "";
            pbPicture.Image = null;
        }

        //記録者の履歴をコンボボックスへ登録(重複なし)
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }
        }

        //車名の履歴をコンボボックスへ登録(重複なし)
        private void setCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName)) {
                cbCarName.Items.Add(carName);
            }
        }

        //選択されているメーカー名を列挙型で返す
        private CarReport.MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked) {
                return CarReport.MakerGroup.トヨタ;
            } else if (rbNissan.Checked) {
                return CarReport.MakerGroup.日産;
            } else if (rbHonda.Checked) {
                return CarReport.MakerGroup.ホンダ;
            } else if (rbSubaru.Checked) {
                return CarReport.MakerGroup.スバル;
            } else if (rbImport.Checked) {
                return CarReport.MakerGroup.輸入車;
            } else {
                return CarReport.MakerGroup.その他;
            }
        }

        //指定したメーカーのラジオボタンをセット
        private void setRadioButtonMaker(CarReport.MakerGroup targetMaker) {
            switch (targetMaker) {
                case CarReport.MakerGroup.なし:
                    rbAllClear();
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImport.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
            }
        }

        private void rbAllClear() {
            rbNissan.Checked = false;
            rbToyota.Checked = false;
            rbHonda.Checked = false;
            rbSubaru.Checked = false;
            rbImport.Checked = false;
            rbOther.Checked = false;
        }

        //開くボタンで画像の追加
        private void btPicOpen_Click(object sender, EventArgs e) {
            try {
                if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
                    pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
                tlssMassageArea.Text = "";
            }
            catch (Exception) {
                tlssMassageArea.Text = "画像ファイルが選択されていません。";
            }

        }

        //削除ボタンで画像の削除
        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //最初に実行される
        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReport.Columns["Picture"].Visible = false; //画像列の非表示

            //交互に色を設定（データグリッドビュー）
            dgvCarReport.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvCarReport.AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite;
        }

        //一覧のクリックした行を表示
        private void dgvCarReport_Click(object sender, EventArgs e) {
            //if ((dgvCarReport.CurrentRow == null) || 
            //    (!dgvCarReport.CurrentRow.Selected)) return;
            if (dgvCarReport.CurrentRow == null) return;

            dtpDate.Value = (DateTime)dgvCarReport.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvCarReport.CurrentRow.Cells["Author"].Value;
            setRadioButtonMaker((CarReport.MakerGroup)dgvCarReport.CurrentRow.Cells["Maker"].Value);
            cbCarName.Text = (string)dgvCarReport.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (string)dgvCarReport.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgvCarReport.CurrentRow.Cells["Picture"].Value;
        }

        //削除ボタン
        private void btDeleteReport_Click(object sender, EventArgs e) {
            //if ((dgvCarReport.CurrentRow == null) || 
            //    (!dgvCarReport.CurrentRow.Selected)) return;
            if (dgvCarReport.CurrentRow == null) {
                tlssMassageArea.Text = "データが選択されていないか存在しません。";
                return;
            }

            //リストの削除
            listCarReports.RemoveAt(dgvCarReport.CurrentRow.Index);

            inputItemsAllClear(); //入力項目をすべてクリア
        }

        //修正ボタン
        private void btModifyReport_Click(object sender, EventArgs e) {
            if (dgvCarReport.CurrentRow == null) {
                tlssMassageArea.Text = "データが選択されていないか存在しません。";
                return;
            }
            //修正時に記録者・車名のみ入力不可
            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                tlssMassageArea.Text = "記録者と車名を入力してください。";
                return;
            }

            listCarReports[dgvCarReport.CurrentRow.Index].Date = dtpDate.Value;
            listCarReports[dgvCarReport.CurrentRow.Index].Author = cbAuthor.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Maker = GetRadioButtonMaker();
            listCarReports[dgvCarReport.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Report = tbReport.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Picture = pbPicture.Image;

            dgvCarReport.Refresh(); //データグリッドビューの更新
            inputItemsAllClear(); //入力項目をすべてクリア
        }

        //記録者のテキストが編集されたら
        private void cbAuthor_TextChanged(object sender, EventArgs e) {
            tlssMassageArea.Text = "";
        }

        //車名のテキストが編集されたら
        private void cbCarName_TextChanged(object sender, EventArgs e) {
            tlssMassageArea.Text = "";
        }

        //ファイルセーブ処理
        private void ReportSaveFIle() {
            if (sfdReportFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリー形式でシリアル化
#pragma warning disable SYSLIB0011 // 型またはメンバーが旧型式です
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // 型またはメンバーが旧型式です
                    using (FileStream fs = File.Open(sfdReportFileSave.FileName,
                                                            FileMode.CreateNew)) {
                        bf.Serialize(fs, listCarReports);
                    }
                }
                catch (Exception) {
                    tlssMassageArea.Text = "書き込みエラー";
                }
            }
        }

        //ファイルオープン処理
        private void ReportOpenFile() {
            if (ofdReportFIleOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //逆シリアル化でバイナリ形式を取り込む
#pragma warning disable SYSLIB0011 // 型またはメンバーが旧型式です
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // 型またはメンバーが旧型式です
                    using (FileStream fs = File.Open(ofdReportFIleOpen.FileName,
                                                     FileMode.Open, FileAccess.Read)) {
                        listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReport.DataSource = listCarReports;

                        //記録者と車名の履歴をコンボボックスへ登録(重複なし)
                        foreach (var carReport in listCarReports) {
                            setCbAuthor(carReport.Author);
                            setCbCarName(carReport.CarName);
                        }
                        tlssMassageArea.Text = "";
                    }
                }
                catch (Exception ex) {
                    tlssMassageArea.Text = "正しい形式のファイルを選択してください。";
                }
                dgvCarReport.CurrentCell = null; //セレクションを外す
            }
        }

        //クリアボタン
        private void btInputItemsClear_Click(object sender, EventArgs e) {
            inputItemsAllClear();
        }

        private void 開くToolStripMenuItem_Click(object sender, EventArgs e) {
            ReportOpenFile(); //ファイルオープン処理
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            ReportSaveFIle(); //ファイルセーブ処理
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show("本当に終了しますか？", "確認",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
