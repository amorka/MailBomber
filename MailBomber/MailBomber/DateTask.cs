﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MailBomber
{
    class DateTask
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public string Date { get; set; }

        public DateTask(int yy, int mm, int dd) {
            Date = yy.ToString() + "-" + mm.ToString() + "-" + dd.ToString();
        }

        public DateTask Parse(string s) {
            this.Date = s;
            Regex reg = new Regex(@"^([0-9]{4,});([0-9]{1,2});([0-9]{1,2})$", RegexOptions.IgnoreCase);
            Match match=reg.Match(s);
            Group g_yy = match.Groups[1];
            Group g_mm = match.Groups[2];
            Group g_dd = match.Groups[3];

            Year= Int32.Parse(g_yy.Value);
            Month = Int32.Parse(g_mm.Value);
            Day= Int32.Parse(g_dd.Value);
            return this;
        }
    }
}