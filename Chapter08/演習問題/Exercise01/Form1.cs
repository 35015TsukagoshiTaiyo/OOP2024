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
            var str = now.ToString("ggyy�N M��dd��(dddd)", culture);

            tbDisp.Text = now.ToString("yyyy/M/dd hh:mm") + "\r\n" +
                          now.ToString("yyyy�NMM��dd�� HH��mm��ss�b") + "\r\n" +
                          now.ToString(str);
        }

        private void btEx8_2_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            DateTime nextSunday = NextDay(today, DayOfWeek.Sunday);
            tbDisp.Text = today.ToString("yy/MM/dd�̎��T�̓��j��: ") +
                          nextSunday.ToString("yy/MM/dd(ddd)");
        }

        public static DateTime NextDay(DateTime date, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            if (days <= 0)
                days += 7;
            return date.AddDays(days);
        }
    }
}
