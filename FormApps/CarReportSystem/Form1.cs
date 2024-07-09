using System.ComponentModel;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //�J�[���|�[�g�Ǘ��p���X�g
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReports;
        }

        //�ǉ��{�^��
        private void btAddReport_Click(object sender, EventArgs e) {
            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                //MessageBox.Show("�L�^�҂ƎԖ�����͂��Ă��������B","�G���[",
                //                 MessageBoxButtons.OK,MessageBoxIcon.Error);
                tlssMassageArea.Text = "�L�^�҂ƎԖ�����͂��Ă��������B";
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

            inputItemsAllClear(); //���͍��ڂ����ׂăN���A

        }

        //���͍��ڂ����ׂăN���A
        private void inputItemsAllClear() {
            //dgvCarReport.ClearSelection(); //�Z���N�V�������O��1
            dgvCarReport.CurrentCell = null; //�Z���N�V�������O��2
            dtpDate.Value = DateTime.Now;
            cbAuthor.Text = "";
            setRadioButtonMaker(CarReport.MakerGroup.���̑�);
            cbCarName.Text = "";
            tbReport.Text = "";
            pbPicture.Image = null;
        }

        //�L�^�҂̗������R���{�{�b�N�X�֓o�^(�d���Ȃ�)
        private void setCbAuthor(string author) {
            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
            }
        }

        //�Ԗ��̗������R���{�{�b�N�X�֓o�^(�d���Ȃ�)
        private void setCbCarName(string carName) {
            if (!cbCarName.Items.Contains(carName)) {
                cbCarName.Items.Add(carName);
            }
        }

        //�I������Ă��郁�[�J�[����񋓌^�ŕԂ�
        private CarReport.MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked) {
                return CarReport.MakerGroup.�g���^;
            } else if (rbNissan.Checked) {
                return CarReport.MakerGroup.���Y;
            } else if (rbHonda.Checked) {
                return CarReport.MakerGroup.�z���_;
            } else if (rbSubaru.Checked) {
                return CarReport.MakerGroup.�X�o��;
            } else if (rbImport.Checked) {
                return CarReport.MakerGroup.�A����;
            } else {
                return CarReport.MakerGroup.���̑�;
            }
        }

        //�w�肵�����[�J�[�̃��W�I�{�^�����Z�b�g
        private void setRadioButtonMaker(CarReport.MakerGroup targetMaker) {
            switch (targetMaker) {
                case CarReport.MakerGroup.�Ȃ�:
                    rbAllClear();
                    break;
                case CarReport.MakerGroup.���Y:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.�g���^:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.�z���_:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.�X�o��:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.�A����:
                    rbImport.Checked = true;
                    break;
                case CarReport.MakerGroup.���̑�:
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

        //�J���{�^���ŉ摜�̒ǉ�
        private void btPicOpen_Click(object sender, EventArgs e) {
            try {
                if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
                    pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
                tlssMassageArea.Text = "";
            }
            catch (Exception) {
                tlssMassageArea.Text = "�摜�t�@�C�����I������Ă��܂���B";
            }

        }

        //�폜�{�^���ŉ摜�̍폜
        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //�ŏ��Ɏ��s�����
        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReport.Columns["Picture"].Visible = false; //�摜��̔�\��

            //���݂ɐF��ݒ�i�f�[�^�O���b�h�r���[�j
            dgvCarReport.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvCarReport.AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite;
        }

        //�ꗗ�̃N���b�N�����s��\��
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

        //�폜�{�^��
        private void btDeleteReport_Click(object sender, EventArgs e) {
            //if ((dgvCarReport.CurrentRow == null) || 
            //    (!dgvCarReport.CurrentRow.Selected)) return;
            if (dgvCarReport.CurrentRow == null) {
                tlssMassageArea.Text = "�f�[�^���I������Ă��Ȃ������݂��܂���B";
                return;
            }

            //���X�g�̍폜
            listCarReports.RemoveAt(dgvCarReport.CurrentRow.Index);

            inputItemsAllClear(); //���͍��ڂ����ׂăN���A
        }

        //�C���{�^��
        private void btModifyReport_Click(object sender, EventArgs e) {
            if (dgvCarReport.CurrentRow == null) {
                tlssMassageArea.Text = "�f�[�^���I������Ă��Ȃ������݂��܂���B";
                return;
            }
            //�C�����ɋL�^�ҁE�Ԗ��̂ݓ��͕s��
            if (cbAuthor.Text == "" || cbCarName.Text == "") {
                tlssMassageArea.Text = "�L�^�҂ƎԖ�����͂��Ă��������B";
                return;
            }

            listCarReports[dgvCarReport.CurrentRow.Index].Date = dtpDate.Value;
            listCarReports[dgvCarReport.CurrentRow.Index].Author = cbAuthor.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Maker = GetRadioButtonMaker();
            listCarReports[dgvCarReport.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Report = tbReport.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Picture = pbPicture.Image;

            dgvCarReport.Refresh(); //�f�[�^�O���b�h�r���[�̍X�V
            inputItemsAllClear(); //���͍��ڂ����ׂăN���A
        }

        //�L�^�҂̃e�L�X�g���ҏW���ꂽ��
        private void cbAuthor_TextChanged(object sender, EventArgs e) {
            tlssMassageArea.Text = "";
        }

        //�Ԗ��̃e�L�X�g���ҏW���ꂽ��
        private void cbCarName_TextChanged(object sender, EventArgs e) {
            tlssMassageArea.Text = "";
        }

        //�t�@�C���Z�[�u����
        private void ReportSaveFIle() {
            if (sfdReportFileSave.ShowDialog() == DialogResult.OK) {
                try {
                    //�o�C�i���[�`���ŃV���A����
#pragma warning disable SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    using (FileStream fs = File.Open(sfdReportFileSave.FileName,
                                                            FileMode.CreateNew)) {
                        bf.Serialize(fs, listCarReports);
                    }
                }
                catch (Exception) {
                    tlssMassageArea.Text = "�������݃G���[";
                }
            }
        }

        //�t�@�C���I�[�v������
        private void ReportOpenFile() {
            if (ofdReportFIleOpen.ShowDialog() == DialogResult.OK) {
                try {
                    //�t�V���A�����Ńo�C�i���`������荞��
#pragma warning disable SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    var bf = new BinaryFormatter();
#pragma warning restore SYSLIB0011 // �^�܂��̓����o�[�����^���ł�
                    using (FileStream fs = File.Open(ofdReportFIleOpen.FileName,
                                                     FileMode.Open, FileAccess.Read)) {
                        listCarReports = (BindingList<CarReport>)bf.Deserialize(fs);
                        dgvCarReport.DataSource = listCarReports;

                        //�L�^�҂ƎԖ��̗������R���{�{�b�N�X�֓o�^(�d���Ȃ�)
                        foreach (var carReport in listCarReports) {
                            setCbAuthor(carReport.Author);
                            setCbCarName(carReport.CarName);
                        }
                        tlssMassageArea.Text = "";
                    }
                }
                catch (Exception ex) {
                    tlssMassageArea.Text = "�������`���̃t�@�C����I�����Ă��������B";
                }
                dgvCarReport.CurrentCell = null; //�Z���N�V�������O��
            }
        }

        //�N���A�{�^��
        private void btInputItemsClear_Click(object sender, EventArgs e) {
            inputItemsAllClear();
        }

        private void �J��ToolStripMenuItem_Click(object sender, EventArgs e) {
            ReportOpenFile(); //�t�@�C���I�[�v������
        }

        private void �ۑ�ToolStripMenuItem_Click(object sender, EventArgs e) {
            ReportSaveFIle(); //�t�@�C���Z�[�u����
        }

        private void �I��ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (MessageBox.Show("�{���ɏI�����܂����H", "�m�F",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
