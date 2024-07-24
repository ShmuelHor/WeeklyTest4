using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static WeeklyTest4.Model.HebrewDateModel;
using static WeeklyTest4.Configurtion.Configurtion;
using WeeklyTest4.Model;
using System.Linq.Expressions;

namespace WeeklyTest4.service
{
    internal static class Service
    {
        public static void InsertQueries()
        {
            if (!File.Exists(DatePath))
            {
                XDocument document = XDocument.Parse(@"
                <Queries></Queries>");
                document.Save(DatePath);
            }

        }

        public static void InsertDate(HebrewDateModel Date)
        {
            XDocument docoment = XDocument.Load(DatePath);
            var root = docoment.Descendants("Queries").FirstOrDefault();
            if (root != null)
            {
                XElement element = new(
                    "Query",
                    new XElement("Day", Date.Day),
                    new XElement("DayMonth", Date.DayMonth),
                    new XElement("Month", Date.Month),
                    new XElement("Year", Date.Year),
                    new XElement("Result", Date.Result)
                    );
                root.Add(element);
                root.Save(DatePath);
            }
        }

        public static string ReturnDay(string Day)
        {
            switch (Day)
            {
                case "רשאון":
                    return "באחד בשבת";

                case "שני":
                    return "בשני בשבת";
                case "שלישי":
                    return "בשלישי בשבת";

                case "רביעי":
                    return "ברביעי בשבת";

                case "חמישי":
                    return "בחמישי בשבת";

                case "ששי":
                    return "בששי בשבת";

                default:
                    return null;

            }
        }

        public static string ReturnDayMonth(int DayMonth)
        {
            switch (DayMonth)
            {
                case 1:
                    return "יום אחד לירח ";

                case 2:
                    return "שני ימים לירח";

                case 3:
                    return "שלושה ימים לירח";

                case 4:
                    return "ארבעה ימים לירח";

                case 5:
                    return "חמישה ימים לירח";

                case 6:
                    return "שישה ימים לירח";

                case 7:
                    return "שבעה ימים לירח";

                case 8:
                    return "שמונה ימים לירח";

                case 9:
                    return "תשעה ימים לירח";

                case 10:
                    return "עשרה ימים לירח";

                case 11:
                    return "אחת עשר ימים לירח";

                case 12:
                    return "שתים עשר ימים לירח";

                case 13:
                    return "שלושה עשר ימים לירח";

                case 14:
                    return "ארבעה עשר ימים לירח";

                case 15:
                    return "חמישה עשר ימים לירח";

                case 16:
                    return "שישה עשר ימים לירח";

                case 17:
                    return "שבעה עשר ימים לירח";

                case 18:
                    return "שמונה עשר ימים לירח";

                case 19:
                    return "תשעה עשר ימים לירח";

                case 20:
                    return "עשרים ימים לירח";

                case 21:
                    return "אחד ועשרים ימים לירח";

                case 22:
                    return "שניים ועשרים ימים לירח";

                case 23:
                    return "שלושה ועשרים ימים לירח";

                case 24:
                    return "ארבעה ועשרים ימים לירח";

                case 25:
                    return "חמישה ועשרים ימים לירח";

                case 26:
                    return "שישה ועשרים ימים לירח";

                case 27:
                    return "שבעה ועשרים ימים לירח";

                case 28:
                    return "שמונה ועשרים ימים לירח";

                case 29:
                    return "תשעה ועשרים ימים לירח";

                case 30:
                    return "שלשים ימים לירח  ";

                default:
                    return null;
            }

        }

        public static string ReturnYear(string Year)
        {
            switch (Year)
            {
                case @"תשפ""ד":
                    return "בשנת חמשת אלפים ושבע מאות ושמנים וארבע לבריאת העולם";
                case @"תשפ""ה":
                    return "בשנת חמשת אלפים ושבע מאות ושמנים וחמש לבריאת העולם";
                case @"תשפ""ו":
                    return "בשנת חמשת אלפים ושבע מאות ושמנים ושש לבריאת העולם";
                case @"תשפ""ז":
                    return "בשנת חמשת אלפים ושבע מאות ושמנים ושבע לבריאת העולם";
                case @"תשפ""ח":
                    return "בשנת חמשת אלפים ושבע מאות ושמנים ושמונה לבריאת העולם";
                case @"תשפ""ט":
                    return "בשנת חמשת אלפים ושבע מאות ושמנים ותשע לבריאת העולם";
                case @"תש""צ":
                    return "בשנת חמשת אלפים ושבע מאות ותשעים  לבריאת העולם";
                case @"תשצ""א":
                    return "בשנת חמשת אלפים ושבע מאות ותשעים ואחת לבריאת העולם";
                case @"תשצ""ב":
                    return "בשנת חמשת אלפים ושבע מאות ותשעים ושניים לבריאת העולם";
                case @"תשצ""ג":
                    return "בשנת חמשת אלפים ושבע מאות ותשעים ושלוש לבריאת העולם";
                default:
                    return null;
            }
        }
        public static string ReturnNextMonth(string Month)
        {
            switch (Month)
            {
                case "תשרי":
                    return "שהוא ראש חודש מרחשון";
                case "מרחשון":
                    return "שהוא ראש חודש כסלו";
                case "כסלו":
                    return "שהוא ראש חודש טבת";
                case "טבת":
                    return "שהוא ראש חודש שבט";
                case "שבט":
                    return "שהוא ראש חודש אדר";
                case "אדר":
                    return "שהוא ראש חודש ניסן";
                case "אדר הראשון":
                    return "שהוא ראש חודש אדר השני";
                case "אדר השני":
                    return "שהוא ראש חודש ניסן";
                case "ניסן":
                    return "שהוא ראש חודש אייר";
                case "אייר":
                    return "שהוא ראש חודש סיון";
                case "סיון":
                    return "שהוא ראש חודש תמוז";
                case "תמוז":
                    return "שהוא ראש חודש אב";
                case "אב":
                    return "שהוא ראש חודש אלול";
                case "אלול":
                    return "שהוא ראש חודש תשרי";
                default:
                    return null;
            }
        }
    }
}
