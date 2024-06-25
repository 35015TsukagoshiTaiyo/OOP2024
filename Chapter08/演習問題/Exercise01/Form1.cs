using System.Globalization;

namespace Exercise01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btEx8_1_Click(object sender, EventArgs e) {
            var now = DateTime.Now;

            var culture = new CultureInfo("ja-JP");
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();
            var str = now.ToString("ggyy�N M��dd��(dddd)",culture);

            tbDisp.Text = now.ToString("yyyy/M/dd hh:mm") + "\r\n"+
                          now.ToString("yyyy�NMM��dd�� hh��mm��ss�b") + "\r\n"+
                          now.ToString(str);


        }
    }
}
