using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTask
{
    internal class IDGenerator
    {
        private static int counter = 1;
        public static string GenerateStudentID()
        {
            string year = DateTime.Now.Year.ToString();
            string numberPart = counter.ToString("D4");

            counter++;

            return $"084-{year}-{numberPart}";
        }
    }
}
