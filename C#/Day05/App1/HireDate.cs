using System;


namespace App1
{
    class HireDate
    {
        byte day;
        byte month;
        short year;
        public HireDate()
        {

        }
        public HireDate(byte day, byte month, short year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public byte Day
        {
            set { day = value; }
            get { return day; }
        }
        public byte Month
        {
            set { month = value; }
            get { return month; }
        }
        public short Year
        {
            set { year = value; }
            get { return year; }
        }


        //public byte GetDay() { return day; }
        //public byte GetMonth() { return month; }
        //public short GetYear() { return year; }
        //public void SetDay(byte day) { this.day = day; }
        //public void SetMonth(byte month) { this.month = month; }
        //public void SetYear(short year) { this.year = year; }
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
    }
}
