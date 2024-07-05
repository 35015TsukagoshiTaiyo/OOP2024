using System.ComponentModel;
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
            dgvCarReport.ClearSelection(); //�Z���N�V�������O��
            dtpDate.Value = DateTime.Now;
            cbAuthor.Text = "";
            setRadioButtonMaker(CarReport.MakerGroup.�Ȃ�);
            cbCarName.Text = "";
            tbReport.Text = "";
            pbPicture.Image = null;
            tlssMassageArea.Text = "";
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
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK)
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
        }

        //�폜�{�^���ŉ摜�̍폜
        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        //�ŏ��Ɏ��s�����
        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReport.Columns["Picture"].Visible = false; //�摜��̔�\��
        }

        //�ꗗ�̃N���b�N�����s��\��
        private void dgvCarReport_Click(object sender, EventArgs e) {
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
            if (dgvCarReport.CurrentRow == null) {
                tlssMassageArea.Text = "�f�[�^���I������Ă��܂���B";
                return;
            }

            //���X�g�̍폜
            listCarReports.RemoveAt(dgvCarReport.CurrentRow.Index);

            if (dgvCarReport.CurrentRow == null) {
                inputItemsAllClear(); //���͍��ڂ����ׂăN���A
                return;
            }
            inputItemsAllClear(); //���͍��ڂ����ׂăN���A
        }

        //�C���{�^��
        private void btModifyReport_Click(object sender, EventArgs e) {
            if (dgvCarReport.CurrentRow == null) {
                tlssMassageArea.Text = "�f�[�^������܂���B";
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
    }
}
