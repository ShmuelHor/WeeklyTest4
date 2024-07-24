using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyTest4.Configurtion
{
    internal class Configurtion
    {
        public static string DatePath = Path.Combine(
            Directory.GetCurrentDirectory(), "Queries.xml");
    }
}
