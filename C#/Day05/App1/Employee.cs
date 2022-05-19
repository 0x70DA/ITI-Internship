using System;


namespace App1
{
    class Employee: IComparable
    {
        int id;
        int salary;
        HireDate hd;
        Gender gender;

        public Employee()
        {

        }
        public Employee(int id, int salary, HireDate hd, Gender gender)
        {
            this.id = id;
            this.salary = salary;
            this.hd = hd;
            this.gender = gender;
        }
        //public int GetID() { return id; }
        //public string GetSalary() { return $"{salary:c}"; }
        //public HireDate GetHireDate() { return hd; }
        //public Gender GetGender() { return gender; }

        //public void SetID(int id) { this.id = id; }
        //public void SetSalary(int salary) { this.salary = salary; }
        //public void SetHireDate(HireDate hd) { this.hd = hd; }
        //public void SetGender(Gender gender) { this.gender = gender; }

        #region Properties
        public int ID
        {
            set { id = value; }
            get { return id; }
        }
        public int Salary
        {
            set { salary = value; }
            get { return salary; }
        }
        public HireDate HD
        {
            set { hd = value; }
            get { return hd; }
        }
        public Gender Gender
        {
            set { gender = value; }
            get { return gender; }
        }
        #endregion


        public override string ToString()
        {
            return $"ID: {id}\nsalary:{salary:c}\nHireDate:{hd}\nGender:{gender}";
        }

        public int CompareTo(object obj)
        {
            Employee rhs = (Employee)obj;
            if (HD.Year > rhs.HD.Year)
            {
                return 1;
            }
            else if (HD.Year < rhs.HD.Year)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    enum Gender : byte
    {
        M,
        F
    }
}
