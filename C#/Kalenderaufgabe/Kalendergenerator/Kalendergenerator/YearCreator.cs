using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalendergenerator
{
    class YearCreator
    {
        public Year CreateYear(int year)
        {
            return new Year(year);
        }

        public Year CreateYear()
        {
            return new Year(DateTime.Now.Year);
        }
    }
}
