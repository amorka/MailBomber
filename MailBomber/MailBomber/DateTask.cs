using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MailBomber
{
    class DateTask
    {
        
        public int ordering { get; set; }

        public DateTask(int ord) {
            ordering = ord;
        }

        public DateTask() { }
        
        public int CalcDate() {
            ordering++;
            return ordering;
        }
    }
}
