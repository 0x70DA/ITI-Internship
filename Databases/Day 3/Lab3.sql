--1
select *
from Employee;

--2
select Fname, Lname, Salary, Dno
from Employee;

--3
select Pname, Plocation, Dnum
from Project;

--4
select SSN, Fname + ' ' + Lname as Name
from Employee
where Salary > 1000;

--5
select SSN, Fname + ' ' + Lname as Name
from Employee
where Salary * 12 > 10000;

--6
select Fname + ' ' + Lname as Name, salary
from Employee
where Sex = 'F';

--7
select Dnum, Dname
from Departments
where MGRSSN = 968574;