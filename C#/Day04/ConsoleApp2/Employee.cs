using System;


namespace ConsoleApp2
{
    struct Employee: IComparable
    {
        int ID;
        int salary;
        HireDate hireDate;
        Gender gender;

        public Employee(int ID, int salary, HireDate hireDate, Gender gender)
        {
            this.ID = ID;
            this.salary = salary;
            this.hireDate = hireDate;
            this.gender = gender;
        }
        public int GetID() { return ID; }
        public string GetSalary() { return $"{salary:c}"; }
        public HireDate GetHireDate() { return hireDate; }
        public Gender GetGender() { return gender; }

        public void SetID(int ID) { this.ID = ID; }
        public void SetSalary(int salary) { this.salary = salary; }
        public void SetHireDate(HireDate hireDate) { this.hireDate = hireDate; }
        public void SetGender(Gender gender) { this.gender = gender; }

        public override string ToString()
        {
            return $"ID: {ID}\nsalary:{salary:c}\nHireDate:{hireDate}\nGender:{gender}";
        }

        public int CompareTo(object obj)
        {
            Employee rhs = (Employee)obj;
            if (hireDate.GetYear() > rhs.hireDate.GetYear())
            {
                return 1;
            }
            else if (hireDate.GetYear() < rhs.hireDate.GetYear())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    
    enum Gender: byte
    {
        M,
        F
    }
}
