using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace miniproject
{
    class AppEngine
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        static SqlConnection getConnection()
        {
            con = new SqlConnection("data source = RMGW58ZLPC0909\\SQLEXPRESS; Initial Catalog=StudentManagement; user id=sa; password=Temp1234");
            con.Open();
            return con;
        }
        public void introduce(Course course)
        {
            Console.WriteLine(course.Id + " " + course.Name + " " + course.duration + " " +"days,"+ " " + course.fees);
        }

        //public void register(Student student)
        //{

        //    Console.WriteLine(student.Id+" "+student.Name+" "+student.DOB);

        //}

        public void studentregister(Student student)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;

            try
            {
                con = getConnection();

                cmd = new SqlCommand("insert into tblStudents values(@StudentId,@StudentName,@studentDOB)", con);
                cmd.Parameters.AddWithValue("@StudentId", student.Id);
                cmd.Parameters.AddWithValue("@StudentName", student.Name);
                cmd.Parameters.AddWithValue("studentDOB", student.DOB);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Row inserted");
                else
                    Console.WriteLine("Not Inserted");


            }
            catch (SqlException e)
            {
                Console.WriteLine(e); //instead throw user defined exception
            }
            finally
            {

                con.Close();
            }
        }

        internal void Updatecourse()
        {
            throw new NotImplementedException();
        }

        //public Student[] ListOfStudents()
        //{
        //    Student[] students = new Student[3]
        //    {
        //        new Student(1,"vajahulla", "19/10/1998"),
        //       new Student(2,"sharif", "21/05/1999"),
        //       new Student(3,"Mohammed", "11/08/1992")
        //    };

        //    return students;
        //}

        //public List<Student> listOfStudents()
        //{
        //    List<Student> students = new List<Student>()
        //    {
        //       new Student(1,"vajahulla", "19/10/1998"),
        //       new Student(2,"sharif", "21/05/1999"),
        //       new Student(3,"Mohammed", "11/08/1992")
        //    };

        //    return students;
        //}

        //public Course[] ListOfCourses()
        //{
        //    Course[] courses = new Course[3]
        //   {
        //         new Course(101,"python",30,35000.00f),
        //        new Course(102,"DotNet",40,25000.00f),
        //        new Course(103,"java",35,40000.00f)
        //   };
        //    return courses;
        //}

        //public List<Course> listOfCourses()
        //{
        //    List<Course> courses = new List<Course>()
        //   {
        //        new Course(101,"python",30,35000.00f),
        //        new Course(102,"DotNet",40,25000.00f),
        //        new Course(103,"java",35,40000.00f)
        //   };
        //    return courses;
        //}

        //public void enroll(Student student, Course course)
        //{
        //    info info = new info();
        //    info.display(student);
        //    info.display(course);
        //}

        //public Enroll[] ListOfEnrollments()
        //{
        //    Enroll[] enroll = new Enroll[3]
        //    {

        //      new Enroll(new Student(1,"vajahulla", "19/10/1998" ), new Course(101, "python", 30, 35000.00f), Convert.ToDateTime(DateTime.Now)),
        //      new Enroll(new Student(2, "sharif", "21/05/1999"), new Course(102, "Dotnet", 40, 25000.00f), Convert.ToDateTime(DateTime.Now)),
        //      new Enroll(new Student(3,  "Mohammed", "11/08/1992"), new Course(103, "java", 35, 40000.00f), Convert.ToDateTime(DateTime.Now))
        //    };
        //    return enroll;
        //}

        //public List<Enroll> listOfEnrollments()
        //{
        //    List<Enroll> enroll = new List<Enroll>()
        //    {

        //      new Enroll(new Student(1, "vajahulla", "19/10/1998"), new Course(101, "python", 30, 35000.00f), Convert.ToDateTime(DateTime.Now)),
        //      new Enroll(new Student(2, "sharif", "21/05/1999"), new Course(102, "Dotnet", 40, 25000.00f), Convert.ToDateTime(DateTime.Now)),
        //      new Enroll(new Student(3, "Mohammed", "11/08/1992"), new Course(103, "java", 35, 40000.00f), Convert.ToDateTime(DateTime.Now))
        //    };
        //    return enroll;
        //}

        public void AllStudentDetails()
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("Select * from tblStudents", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student Id : " + dr[0] + " " + "Student Name : " + dr[1] + " " + "Student DOB : " + dr[2]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }


        public void UpdateStudent()
        {
            try
            {
                Console.WriteLine("Enter the Student id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Student Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Student DOB :");
                string dob = Console.ReadLine();
                con = getConnection();
                cmd = new SqlCommand("update tblStudents set StudentName=@studentname,StudentDOB=@studentdob where StudentId=@studentId",con);
                cmd.Parameters.AddWithValue("@studentId", id);
                cmd.Parameters.AddWithValue("@studentname", name);
                cmd.Parameters.AddWithValue("@studentdob", dob);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Row Updated");
                }
                else
                {
                    Console.WriteLine("Row Not Updated");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void DeleteStudents()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The student Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("delete tblStudents where StudentId=@studentid", con);
                cmd.Parameters.AddWithValue("@studentid", id);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Row Delete Successfully");
                else
                    Console.WriteLine("Row Not Deleted");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void ParticularStudent()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The Student Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("select * from tblStudents where StudentId =@studentid", con);
                cmd.Parameters.AddWithValue("@studentid", id);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student Id : " + dr[0] + " " + "Student Name : " + dr[1] + " " + "Student DOB : " + dr[2]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }
        public void AllCoursesLists()
        {
            try
            {
                con = getConnection();
                cmd = new SqlCommand("select * from tblCourses", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Course Id : " + dr[0] + " Course Name : " + dr[1] + " Course Duration : " + dr[2] +" "+"days," + " Course Fees : " + dr[3]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void ParticularCourse()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The Course Id ");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("select * from tblCourses where CourseId=@Courseid",con);
                cmd.Parameters.AddWithValue("@Courseid", id);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Course Id : " + dr[0] + " Course Name : " + dr[1] + " Course Duration : " + dr[2] + " Course Fees : " + dr[3]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }


        public void updatestudentCourse()
        {
            try
            {
                Console.WriteLine("Enter the Course id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Course Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Course Duration :");
                int duration = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Course Fees :");
                float fee = Convert.ToSingle(Console.ReadLine());
                con = getConnection();
                cmd = new SqlCommand("update tblCourses set Courseduration=@Courseduration,coursename=@coursename,Coursefees=@Coursefees where CourseId=@Courseid", con);
                cmd.Parameters.AddWithValue("@Courseid", id);
                cmd.Parameters.AddWithValue("@Coursename", name);
                cmd.Parameters.AddWithValue("@Courseduration", duration);
                cmd.Parameters.AddWithValue("@Coursefees", fee);
                int res1 = cmd.ExecuteNonQuery();
                if (res1 > 0)
                {
                    Console.WriteLine("Row Updated");
                }
                else
                {
                    Console.WriteLine("Row Not Updated");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void DeletestudentCourse()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The Course Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("delete tblCourses where CourseId=@courseid", con);
                cmd.Parameters.AddWithValue("@courseid", id);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Row Delete Successfully");
                else
                    Console.WriteLine("Row Not Deleted");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void insertingstudentCourse()
        {
            try
            {
                con = getConnection();
                Console.WriteLine("Enter The Course Id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Course Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Course Duration : ");
                int dur = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter The Couration Fees : ");
                float fee = Convert.ToSingle(Console.ReadLine());
                cmd = new SqlCommand("insert into tblCourses values(@CourseId,@CourseName,@Courseduration,@Coursefees)", con);
                cmd.Parameters.AddWithValue("@CourseId", id);
                cmd.Parameters.AddWithValue("CourseName", name);
                cmd.Parameters.AddWithValue("@Courseduration", dur);
                cmd.Parameters.AddWithValue("@Coursefees", fee);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Row Inserted");
                }
                else
                {
                    Console.WriteLine("Row Not Inserted");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void EnrollstudentDetailslists()
        {
            try
            {
                con = getConnection();
               
                Console.WriteLine("Enter the Course id :");
                int Id1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Student Id :");
                int Id = Convert.ToInt32(Console.ReadLine());
                DateTime Enrolldate = DateTime.UtcNow;
                cmd = new SqlCommand("insert into tblEnrollDetails values(@Courseid,@StudentId,@EnrollDate)", con);
                cmd.Parameters.AddWithValue("@Courseid", Id1);
                cmd.Parameters.AddWithValue("@StudentId", Id);
                cmd.Parameters.AddWithValue("@EnrollDate", Enrolldate);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Row Inserted Successfully");
                }
                else
                {
                    Console.WriteLine("Row Not Inserted ");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
