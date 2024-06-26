namespace DateTimeApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btDateCount_Click(object sender, EventArgs e) {


            var today = DateTime.Today;
            TimeSpan diff = today - dtpDate.Value;

            //tbDisp.Text = "〇〇日目";
            tbDisp.Text = (diff.Days + 1) + "日目";
        }

        private void btDayBefore_Click(object sender, EventArgs e) {
            var before = dtpDate.Value.AddDays(-(double)nudDay.Value);
            tbDisp.Text = before.ToString("yyyy年 M月dd日");
        }

        private void btDayAfter_Click(object sender, EventArgs e) {
            var after = dtpDate.Value.AddDays((double)nudDay.Value);
            tbDisp.Text = after.ToString("yyyy年 M月dd日");
        }

        private void btAge_Click(object sender, EventArgs e) {
            var birthday = dtpDate.Value.Date;
            var today = DateTime.Today;
            int age = GetAge(birthday,today);
            tbDisp.Text = age.ToString()+"歳";
        }

        public static int GetAge(DateTime birthday,DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if(targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }
    }
}
