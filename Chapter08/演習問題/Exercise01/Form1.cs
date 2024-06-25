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
            var str = now.ToString("ggyy年 M月dd日(dddd)",culture);

            tbDisp.Text = now.ToString("yyyy/M/dd hh:mm") + "\r\n"+
                          now.ToString("yyyy年MM月dd日 hh時mm分ss秒") + "\r\n"+
                          now.ToString(str);


        }
    }
}
