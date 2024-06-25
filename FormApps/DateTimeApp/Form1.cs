namespace DateTimeApp {
    public partial class nudDay : Form {
        public nudDay() {
            InitializeComponent();
        }

        private void btDateCount_Click(object sender, EventArgs e) {


            var today = DateTime.Today;
            TimeSpan diff = today - dtpBirthday.Value;

            //tbDisp.Text = "�Z�Z����";
            tbDisp.Text = (diff.Days + 1) + "����";
        }

        private void btDayBefore_Click(object sender, EventArgs e) {
            var before = dtpBirthday.Value.AddDays(-(double)numericUpDown1.Value);
            tbDisp.Text = before.ToString("yyyy�N M��dd��");
        }

        private void btDayAfter_Click(object sender, EventArgs e) {
            var after = dtpBirthday.Value.AddDays((double)numericUpDown1.Value);
            tbDisp.Text = after.ToString("yyyy�N M��dd��");
        }
    }
}