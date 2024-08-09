using finalProject;
using Microsoft.EntityFrameworkCore;

AttendanceSystemDbContext attendanceSystem = new AttendanceSystemDbContext();
while (true)
{
    Console.Write("username: ");
    var username = Console.ReadLine();
    Console.Write("password: ");
    var password = Console.ReadLine();

    var admin=attendanceSystem.Admins.SingleOrDefault(x=>x.Username == username && x.Password==password);
    var student=attendanceSystem.Students.SingleOrDefault(x=>x.Username==username && x.Password==password);
    var teacher=attendanceSystem.Teachers.SingleOrDefault(x=>x.Username== username && x.Password==password);

    if (admin != null)
    {

    }
    else if (student != null)
    {

    }
    else if (teacher != null) {
    }

}

void AdminTaskPrint()
{
    Console.WriteLine("1. Create a User as Teacher ");
    Console.WriteLine("2. Create a User Student ");
    Console.WriteLine("3. Create a Course ");
    Console.WriteLine("4. Assign a Teacher in a Course");
    Console.WriteLine("5. Assign Students in a Course");
    Console.WriteLine("6. Set Class Schedule for a Course");
    Console.WriteLine("7. Exit");
    Console.Write("Please Choose Option: ");
}



void LoadAdminTask()
{
    while (true)
    {
        AdminTaskPrint();
        int option = int.Parse(Console.ReadLine());
        if (option > 8)
        {
            Console.WriteLine("Please Enter Valid Option");
            Console.Clear();
            continue;
        }
        else if (option == 1)
        {
            Console.WriteLine("Creating a User as Teacher");
            while (true)
            {
                var User = CreateUser();
                Teacher TeacherCreate = new Teacher
                {
                    Name = User.Name,
                    Username = User.Username,
                    Password = User.Password
                };
                attendanceSystem.Teachers.Add(TeacherCreate);
                attendanceSystem.SaveChanges();
                if (AskAndRepeat() == "n") break;
            }
        }
        else if (option == 2)
        {
            Console.WriteLine("Creating a User as Student");
            while (true)
            {
                var User = CreateUser();
                Student StudentCreate = new Student
                {
                    Name = User.Name,
                    Username = User.Username,
                    Password = User.Password
                };
                attendanceSystem.Students.Add(StudentCreate);
                attendanceSystem.SaveChanges();
                if (AskAndRepeat() == "n") break;
            }
        }
        else if (option == 3)
        {
            Console.WriteLine("Creating a Course");
            while (true)
            {
                Console.WriteLine("Name: ");
                string Name=Console.ReadLine();
                Console.WriteLine("Fees: ");
                double Fees = double.Parse(Console.ReadLine());
                Course CourseCreate = new Course
                {
                    Name = Name,
                    Fees = Fees
                };
                attendanceSystem.Courses.Add(CourseCreate);
                attendanceSystem.SaveChanges();
                if(AskAndRepeat() == "n") break;
            }
        }
        else if (option == 4)
        {
            var Teachers = attendanceSystem.Teachers.ToList();
            var Courses= attendanceSystem.Courses.ToList();
            Console.WriteLine("Teachers Inforamation");
            foreach (var teacher in Teachers)
            {
                Console.WriteLine($"ID: {teacher.TeacherId} Name: {teacher.Name}");
            }
            Console.WriteLine("Course Information");
            foreach (var course in Courses)
            {
                Console.WriteLine($"ID: {course.CourseId} Name: {course.Name}");
            }
            Console.WriteLine("Please Enter Teacher Id and Course Id to assign a Teacher in a Course");

            do
            {
                Console.WriteLine("Enter Teacher ID: ");
                int TeacherId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Course ID: ");
                int CourseId=int.Parse(Console.ReadLine());
                var found = Teachers.Any(x => x.TeacherId == TeacherId) && Courses.Any(x => x.CourseId == CourseId);
                if (found == false) continue;
                //var assingedTeacher=attendanceSystem.Teachers
                //    .Include(tc=>tc.TeacherCourses)
                //    .SingleOrDefault(x => x.TeacherId == TeacherId);
                //TeacherCourse assignedCourse = new TeacherCourse
                //{
                //    TeacherId = TeacherId,
                //    CourseId = CourseId
                //};
                //assingedTeacher.TeacherCourses.Add(assignedCourse);
            } while (true);

        }
    }
}

(string Name,string Username,string Password) CreateUser()
{
    Console.Write("Enter Name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Enter Username: ");
    string username = Console.ReadLine();
    Console.WriteLine("Enter Password: ");
    string password = Console.ReadLine();
    return (name,username,password);
}

string AskAndRepeat()
{
    Console.WriteLine("Want to create more user as Teacher?(y for yes or n for no ");
    string ask = Console.ReadLine();
    while (ask != "n" && ask != "y")
    {
        Console.WriteLine("Please Enter y or n");
        ask = Console.ReadLine();
    }
    return ask;
}