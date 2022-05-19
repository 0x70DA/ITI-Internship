-- 1- Display the Department id, name and id and the name of its manager.
select D.Dnum, D.Dname, D.MGRSSN, E.Fname + ' ' + E.Lname as Name
from Departments D inner join Employee E
on D.MGRSSN = E.SSN;


--2- Display the name of the departments and the name of the projects under its control.
select D.Dname, P.Pname
from Departments D inner join Project P
on P.Dnum = D.Dnum
order by D.Dname;


-- 3- Display All Data of the mangers
select E.*
from Employee E inner join Departments D
on D.MGRSSN = E.SSN;


-- 4- Display All Employees data and the data of their dependents even if they have no dependents
select E.*, D.*
from Employee E left outer join Dependent D
on D.ESSN = E.SSN;


-- 5- Display the Projects full data of the projects with a name starts with "a" letter.
select *
from Project
where Pname like 'a%';


-- 6- display all the employees in department 30 whose salary from 1000 to 2000 LE monthly
select *
from Employee
where Dno = 30 and Salary >= 1000 and Salary <= 2000;


-- 7- For each department-- if its average salary is less than the average salary of all employees-- display its number,
--name and number of its employees.
select COUNT(E.Fname) as [Number Of Empolyees], D.Dname, D.Dnum
from Departments D inner join Employee E
on E.Dno = D.Dnum
group by D.Dname, D.Dnum
having AVG(E.Salary) < (select AVG(Salary) from Employee);

-- 8- Display the data of the department which has the smallest employee ID over all employees' ID.
select *
from Departments D inner join Employee E
on E.Dno = D.Dnum
where E.SSN = (select MIN(SSN) from Employee);