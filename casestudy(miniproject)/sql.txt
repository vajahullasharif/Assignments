create database StudentManagement
use StudentManagement

create table tblCourses
(CourseId int primary key,CourseName varchar(20),Courseduration int, Coursefees float)

insert into tblCourses values(101,'vajahulla',35,35000),(102,'sharif',40,40000),(103,'saleem',35,40000);

select * from tblCourses

create table tblStudents
(StudentId int primary key,StudentName varchar(20),studentDOB date)

insert into tblstudents values(10,'ansari','10/1/1994'),
(20,'javeed','2/3/1997'),(30,'ubedullah','6/7/1998')

select * from tblStudents

create table tblEnrollDetails
(Courseid int foreign key references tblCourses(CourseId),
 StudentId int foreign key references tblStudents(StudentId),
 EnrollDate date)

 insert into tblEnrollDetails values(101,10,'2022/5/1'),
 (102,20,'2022/5/11'),(103,30,'2022/5/21')


 select * from tblEnrollDetails