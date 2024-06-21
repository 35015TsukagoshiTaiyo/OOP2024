namespace DateTimeApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDateCount_Click(object sender, EventArgs e) {
            
            
            var today = DateTime.Today;
            TimeSpan diff = today - dtpBirthday.Value;

            //tbDisp.Text = "ZZ“ú–Ú";
            tbDisp.Text = (diff.Days+1)+"“ú–Ú";
        }
    }
}
