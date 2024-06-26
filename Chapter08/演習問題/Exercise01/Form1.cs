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
            var str = now.ToString("ggyy年 M月dd日(dddd)", culture);

            tbDisp.Text = now.ToString("yyyy/M/dd hh:mm") + "\r\n" +
                          now.ToString("yyyy年MM月dd日 HH時mm分ss秒") + "\r\n" +
                          now.ToString(str);
        }

        private void btEx8_2_Click(object sender, EventArgs e) {
            var today = DateTime.Today;
            foreach (var dayofweek in Enum.GetValues(typeof(DayOfWeek))) {
                var str = string.Format("{0:yy/MM/dd}の次週の{1}：{2:yy/MM/dd(ddd)}",
                                        today, (DayOfWeek)dayofweek,
                                        NextWeek(today, (DayOfWeek)dayofweek));
                tbDisp.Text += str + "\r\n";
            }
        }

        //第１引数で指定した日付の、第２引数で指定した翌週の曜日
        public static DateTime NextWeek(DateTime date, DayOfWeek dayOfWeek) {
            var nextWeek = NextDay(date, dayOfWeek);
            return nextWeek;
        }

        public static DateTime NextDay(DateTime date, DayOfWeek dayOfWeek) {
            var days = (int)dayOfWeek - (int)date.DayOfWeek;
            days += 7;
            return date.AddDays(days);
        }

        private void btEx8_3_Click(object sender, EventArgs e) {
            var tw = new TImeWatch();
            tw.Start();
            Thread.Sleep(1000);
            TimeSpan duration = tw.Stop();
            var str = String.Format("処理時間は{0}ミリ秒でした", duration.TotalMilliseconds);
            tbDisp.Text = str;
        }
    }

    class TImeWatch() {
        private DateTime _time;

        public void Start() {
            _time = DateTime.Now;
        }

        public TimeSpan Stop() {
            return DateTime.Now - _time;
        }
    }
}
