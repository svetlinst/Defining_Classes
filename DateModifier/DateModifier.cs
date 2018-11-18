using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        private DateTime firstDate;
        private DateTime secoDateTime;

        public int CalculateDaysDiff()
        {
            int diff = Math.Abs((firstDate - secoDateTime).Days);
            return diff;
        }

        public DateModifier(string first, string second)
        {
            this.firstDate = DateTime.ParseExact(first, "yyyy MM dd", CultureInfo.InvariantCulture);
            this.secoDateTime = DateTime.ParseExact(second, "yyyy MM dd", CultureInfo.InvariantCulture);
        }
    }
}
