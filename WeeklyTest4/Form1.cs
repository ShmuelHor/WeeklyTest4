using WeeklyTest4.Model;
using static WeeklyTest4.service.Service;
namespace WeeklyTest4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InsertQueries();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Day = DayComboBox.Text;
            int DayMonth = int.Parse(DayMonthComboBox.Text);
            string Monthh = MonthComboBox.Text;
            string Year = YearComboBox.Text;
            MessageBox.Show(Monthh);
            string HebrewDay = ReturnDay(Day);
            string HebrewDayMonth = ReturnDayMonth(DayMonth);
            string HebrewYear = ReturnYear(Year);
            string NextMonth = ReturnNextMonth(Monthh);
            string Result = "";
            if (DayMonth == 30)
            {
                 Result = $"{HebrewDay} {HebrewDayMonth} {Monthh} {NextMonth} {HebrewYear}";
            }
            else
            {
                 Result = $"{HebrewDay} {HebrewDayMonth} {Monthh} {HebrewYear}";
            }

            HebrewDateModel Date = new HebrewDateModel(Day, DayMonth, Monthh, Year , Result);


            InsertDate(Date);

            DayComboBox.Text = "";
            DayMonthComboBox.Text = "";
            MonthComboBox.Text = "";
            YearComboBox.Text = "";


            MessageBox.Show(Result);
        }
    }
}
