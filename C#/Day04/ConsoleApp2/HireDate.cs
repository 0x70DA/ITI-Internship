using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    struct HireDate
    {
        byte day;
        byte month;
        short year;
        public HireDate(byte day, byte month, short year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        

        public byte GetDay() { return day; }
        public byte GetMonth() { return month; }
        public short GetYear() { return year; }
        public void SetDay(byte day) { this.day = day; }
        public void SetMonth(byte month) { this.month = month; }
        public void SetYear(short year) { this.year = year; }
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
}
