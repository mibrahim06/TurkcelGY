namespace Business;

public class ConsoleMenu
{
    private readonly Database _database;
    private readonly SchoolManager _manager;
    private readonly HomeWorkManager _homeWorkManager;
    public  ConsoleMenu()
    {
        _database = new Database();
        _manager = new SchoolManager(_database);
        _homeWorkManager = new HomeWorkManager(_database);
    }
    public void MainMenu()
    {
        Console.Clear();
        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("------- Main Menu --------");
            Console.WriteLine("1. Class Management");
            Console.WriteLine("2. Teacher Management");
            Console.WriteLine("3. Homework Management");
            Console.WriteLine("4. Display");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Exit");
            Console.WriteLine("--------------------------");
            Console.Write("Enter your choice: ");
            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ClassManagement();
                    break;
                case "2":
                    TeacherManagement();
                    break;
                case "3":
                    HomeWorkManagement();
                    break;
                case "4":
                    DisplayMenu();
                    break;
                case "5":
                    SearchMenu();
                    break;
                case "6":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    private void HomeWorkManagement()
    {
        bool isReturn = false;
        while (!isReturn)
        {
            Console.Clear();
            Console.WriteLine("------- Homework Management --------");
            Console.WriteLine("1. Submit homework");
            Console.WriteLine("2. Display homeworks");
            Console.WriteLine("3. Return");
            Console.WriteLine("--------------------------");
            Console.Write("Enter your choice: ");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    SubmitHomeWork();
                    break;
                case "2":
                    DisplayHomeworks();
                    break;
                case "3":
                    isReturn = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    
    private void SubmitHomeWork()
    {
        Console.Clear();
        DisplayAllStudentsForHomework();
        Console.Write("Enter the id of the student: ");
        int studentId = int.Parse(Console.ReadLine()!);
        Student student = _manager.GetStudentById(studentId);
        Console.Write("Enter the homework: ");
        string homeWork = Console.ReadLine()!;
        _homeWorkManager.SubmitHomeWork(studentId, student.ClassroomId, homeWork);
        Console.WriteLine("Homework submitted");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    private void DisplayHomeworks()
    {
        Console.Clear();
        var homeworks = _database.GetHomeWorks();
        Console.WriteLine("------- Homeworks --------");
        foreach (var homework in homeworks)
        {
            var classroom = _manager.GetClassroomById(homework.ClassroomId);
            var student = _manager.GetStudentById(homework.StudentId);
            var teacher = _manager.GetTeacherById(classroom.ClassTeacherId);
            Console.WriteLine($"Student:{student.StudentId}-{student.Name} {student.LastName}\t\tTeacher:{teacher.Name} {teacher.LastName}\t\tHomework:{homework.Content}\t\tDate:{homework.SubmissionDate}");
        }
        Console.WriteLine("--------------------------");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
    
    private void SearchMenu()
    {
        Console.Clear();
        Console.WriteLine("------- Search Menu --------");
        Console.WriteLine("1. Search for a student");
        Console.WriteLine("2. Search for a teacher");
        Console.WriteLine("3. Search for a classroom");
        Console.WriteLine("4. Return");
        Console.WriteLine("--------------------------");
        Console.Write("Enter your choice: ");
        string? choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                SearchStudent();
                break;
            case "2":
                SearchTeacher();
                break;
            case "3":
                SearchClassroom();
                break;
            case "4":
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }

    private void SearchClassroom()
    {
        Console.Clear();
        bool isReturn = false;
        while (!isReturn)
        {
            Console.Clear();
            Console.WriteLine("------- Search Classroom --------");
            Console.WriteLine("1. Search by name");
            Console.WriteLine("2. Search by id");
            Console.WriteLine("3. Return");
            Console.WriteLine("--------------------------");
            Console.Write("Enter your choice: ");
            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    SearchClassroomByName();
                    break;
                case "2":
                    SearchClassroomById();
                    break;
                case "3":
                    isReturn = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    
    private void SearchClassroomById()
    {
        Console.Clear();
        Console.Write("Enter the id of the classroom: ");
        int id = int.Parse(Console.ReadLine()!);
        try
        {
            var classroom = _manager.GetClassroomById(id);
            Console.WriteLine($"Classroom: {classroom.Name} with id: {classroom.ClassroomId}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
    
    private void SearchClassroomByName()
    {
        Console.Clear();
        Console.Write("Enter the name of the classroom: ");
        string name = Console.ReadLine()!;
        try
        {
            var classroom = _manager.GetClassroomByName(name);
            Console.WriteLine(classroom);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    private void SearchStudent()
    {
        Console.Clear();
        bool isReturn = false;
        while (!isReturn)
        {
            Console.Clear();
            Console.WriteLine("------- Search Student --------");
            Console.WriteLine("1. Search by name");
            Console.WriteLine("2. Search by last name");
            Console.WriteLine("3. Search by id");
            Console.WriteLine("4. Return");
            Console.WriteLine("--------------------------");
            Console.Write("Enter your choice: ");
            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    SearchStudentByName();
                    break;
                case "2":
                    SearchStudentByLastName();
                    break;
                case "3":
                    SearchStudentById();
                    break;
                case "4":
                    isReturn = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    private void SearchStudentById()
    {
        Console.Clear();
        Console.WriteLine("------- Search Student By Id --------");
        Console.WriteLine("Enter student id: ");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int id))
        {
            try
            {
                var foundStudent = _manager.GetStudentById(id);
                Console.WriteLine($"Id: {foundStudent.StudentId} Name: {foundStudent.Name} Last Name: {foundStudent.LastName}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("Press any key to return");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Invalid student Id");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Press any key to return");
            Console.ReadKey();
        }
    }
    
    private void SearchStudentByLastName()
    {
        Console.Clear();
        Console.WriteLine("------- Search Student By Last Name --------");
        Console.WriteLine("Enter student last name: ");
        string? lastName = Console.ReadLine();
        try 
        {
            if (lastName != null)
            {
                var foundStudents = _manager.GetStudentsByLastName(lastName);
                foreach (var student in foundStudents)
                {
                    Console.WriteLine($"Id: {student.StudentId} Name: {student.Name} Last Name: {student.LastName}");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("--------------------------");
        Console.WriteLine("Press any key to return");
        Console.ReadKey();
    }
    
    private void SearchTeacher()
    {
        Console.Clear();
        bool isReturn = false;
        while (!isReturn)
        {
            Console.Clear();
            Console.WriteLine("------- Search Teacher --------");
            Console.WriteLine("1. Search by name");
            Console.WriteLine("2. Search by last name");
            Console.WriteLine("3. Search by id");
            Console.WriteLine("4. Return");
            Console.WriteLine("--------------------------");
            Console.Write("Enter your choice: ");
            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    SearchTeacherByName();
                    break;
                case "2":
                    SearchTeacherByLastName();
                    break;
                case "3":
                    SearchTeacherById();
                    break;
                case "4":
                    isReturn = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    private void SearchStudentByName()
    {
        Console.Clear();
        Console.WriteLine("------- Search Student By Name --------");
        Console.WriteLine("Enter student name: ");
        var name = Console.ReadLine();
        try 
        {
            if (name != null)
            {
                var foundStudents = _manager.GetStudentsByName(name);
                foreach (var student in foundStudents)
                {
                    Console.WriteLine($"Id: {student.StudentId} Name: {student.Name} Last Name: {student.LastName}");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("--------------------------");
        Console.WriteLine("Press any key to return");
        Console.ReadKey();
    }
    
    private void SearchTeacherByName()
    {
        Console.Clear();
        Console.WriteLine("------- Search Teacher By Name --------");
        Console.WriteLine("Enter teacher name: ");
        string? name = Console.ReadLine();
        try 
        {
            if (name != null)
            {
                var foundTeachers = _manager.GetTeachersByName(name);
                foreach (var teacher in foundTeachers)
                {
                    Console.WriteLine($"Id: {teacher.TeacherId} Name: {teacher.Name} Last Name: {teacher.LastName}");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("--------------------------");
        Console.WriteLine("Press any key to return");
        Console.ReadKey();
    }
    
    void SearchTeacherByLastName()
    {
        Console.Clear();
        Console.WriteLine("------- Search Teacher By Last Name --------");
        Console.WriteLine("Enter teacher last name: ");
        var lastName = Console.ReadLine();
        try 
        {
            if (lastName != null)
            {
                var foundTeachers = _manager.GetTeachersByLastName(lastName);
                foreach (var teacher in foundTeachers)
                {
                    Console.WriteLine($"Id: {teacher.TeacherId} Name: {teacher.Name} Last Name: {teacher.LastName}");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("--------------------------");
        Console.WriteLine("Press any key to return");
        Console.ReadKey();
    }
    
    void SearchTeacherById()
    {
        Console.Clear();
        Console.WriteLine("------- Search Teacher By Id --------");
        Console.WriteLine("Enter teacher id: ");
        var input = Console.ReadLine();
        if (input != null)
        {
            var id = int.Parse(input);
            try 
            {
                var foundTeacher = _manager.GetTeacherById(id);
                Console.WriteLine($"Id: {foundTeacher.TeacherId} Name: {foundTeacher.Name} Last Name: {foundTeacher.LastName}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        Console.WriteLine("--------------------------");
        Console.WriteLine("Press any key to return");
        Console.ReadKey();
    }
    

    private void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("------- Display Menu --------");
        Console.WriteLine("1. Display all classes");
        Console.WriteLine("2. Display all teachers");
        Console.WriteLine("3. Display all students");
        Console.WriteLine("4. Display Teachers and Their Classes");
        Console.WriteLine("5. Return");
        Console.WriteLine("--------------------------");
        Console.Write("Enter your choice: ");
        string? choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                DisplayAllClasses();
                break;
            case "2":
                DisplayAllTeachers();
                break;
            case "3":
                DisplayAllStudents();
                break;
            case "4":
                DisplayTeachersAndTheirClasses();
                break;
            case "5":
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
    
    private void DisplayTeachersAndTheirClasses()
    {
        Console.Clear();
        Console.WriteLine("------- Teachers and Their Classes --------");
        var classrooms = _database.GetClassrooms();
        foreach (var classroom in classrooms)
        {
            var teacher = _manager.GetTeacherById(classroom.ClassTeacherId);
            Console.WriteLine($"Classroom:{classroom.Name}\tTeacher:{teacher.Name} {teacher.LastName}");
        }
      
        Console.WriteLine("--------------------------");
        Console.WriteLine("Press any key to return");
        Console.ReadKey();
    }
    private void DisplayAllClasses()
    {
        Console.Clear();
        Console.WriteLine("------- All Classes --------");
        var classrooms = _database.GetClassrooms();
        foreach (var classroom in classrooms)
        {
            Console.WriteLine(classroom.Name);
        }
        Console.WriteLine("--------------------------");
        Console.WriteLine("Press any key to return");
        Console.ReadKey();
    }
    
    private void DisplayAllStudents()
    {
        Console.Clear();
        Console.WriteLine("------- All Students --------");
        var students = _database.GetStudents();
        foreach (var student in students)
        {
            var classroom = _manager.GetClassroomById(student.ClassroomId);
            Console.WriteLine($"Id:{student.StudentId}\tName:{student.Name} {student.LastName}\tClassroom:{classroom.Name}");
        }
        Console.WriteLine("--------------------------");
        Console.WriteLine("Press any key to return");
        Console.ReadKey();
    }
    
    private void DisplayAllStudentsForHomework()
    {
        Console.Clear();
        Console.WriteLine("------- All Students --------");
        var students = _database.GetStudents();
        foreach (var student in students)
        {
            var classroom = _manager.GetClassroomById(student.ClassroomId);
            Console.WriteLine($"Student Id:{student.StudentId}\tName:{student.Name} {student.LastName}\tClassroom:{classroom.Name}");
        }
        Console.WriteLine("--------------------------");
    }
    
    private void CreateClassMenu()
    {
        bool isReturn = false;
        
        while (!isReturn)
        {
            Console.Clear();
            Console.WriteLine("------- Create Class --------");
            Console.WriteLine("Class Name: ");
            string? className = Console.ReadLine();
            Console.WriteLine("1-)Create Teacher 2-)Select Teacher");
            string? choice = Console.ReadLine();
            List<String> teacherInfo = new List<string>();
            switch (choice)
            {
                case "1":
                    teacherInfo = CreateTeacherMenu();
                    string teacherName = teacherInfo[0];
                    string teacherLastName = teacherInfo[1];
                    if (className != null) _manager.CreateClassroom(className, teacherName, teacherLastName);
                    isReturn = true;
                    break;
                case "2":
                    teacherInfo = SelectTeacherMenu();
                    if (teacherInfo.Count == 0)
                    {
                        isReturn = true;
                        break;
                    }
                    
                    if (int.TryParse(teacherInfo[2], out int teacherId))
                    {
                        if (className != null) _manager.CreateClassroom(className, teacherId);
                        isReturn = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid teacher id");
                        Console.WriteLine("Press any key to return");
                        Console.ReadKey();
                        break;
                    }
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            if (teacherInfo.Count == 0)
            {
                isReturn = true;
            }
        }
    }
    private List<string> SelectTeacherMenu()
    {
        Console.Clear();
        Console.WriteLine("------- Select Teacher --------");
        var teachers = _database.GetAvailableTeachers();
        if (teachers.Count == 0)
        {
            Console.WriteLine("There is no available teacher in the database");
            Console.WriteLine("Press any key to return");
            Console.ReadKey();
            return new List<string>();
        }
        foreach (var teacher in teachers)
        {
            Console.WriteLine($"Id:{teacher.TeacherId}\tName: {teacher.Name} {teacher.LastName}");
        }
        Console.WriteLine("--------------------------");
        Console.WriteLine("Enter Teacher Id: ");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out int teacherId))
        {
            try
            {
                var teacherInfo = _manager.GetTeacherInfo(teacherId).Concat(new[] { teacherId.ToString() }).ToList();
                return teacherInfo;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Press any key to return");
                Console.ReadKey();
                return new List<string>();
            }
        }
        else
        {
            Console.WriteLine("Invalid teacher Id");
            Console.WriteLine("Press any key to return");
            Console.ReadKey();
            return new List<string>();
        }
    }

    private void ClassManagement()
    {
        Console.Clear();
        bool isReturn = false;
        Console.WriteLine("------- Class Configurations --------");
        Console.WriteLine("1. Create Class");
        Console.WriteLine("2. Add Student to Class");
        Console.WriteLine("3. Return");
        Console.WriteLine("--------------------------");
        Console.Write("Enter your choice: ");
        string? choice = Console.ReadLine();

        while (!isReturn)
        {
            switch (choice)
            {
                case "1":
                    CreateClassMenu();
                    isReturn = true;
                    break;
                case "2":
                    AddStudentToClass();
                    isReturn = true;
                    break;
                case "3":
                    isReturn = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    
    private void AddStudentToClass()
    {
        Console.Clear();
        Console.WriteLine("------- Add Student to Class --------");
        var classrooms = _database.GetClassrooms();
        if (classrooms.Count == 0)
        {
            Console.WriteLine("There is no class in the database");
            Console.WriteLine("Press any key to return");
            Console.ReadKey();
            return;
        }
        foreach (var classroom in classrooms)
        {
            Console.WriteLine($"Class Id: {classroom.ClassroomId} Classroom Name: {classroom.Name}");
        }
        Console.WriteLine("--------------------------");
        Console.WriteLine($"Select Class Id:");
        int classId = int.Parse(Console.ReadLine()!);
        Console.WriteLine("How many students do you want to add?");
        int studentCount = int.Parse(Console.ReadLine()!);
        for (int i = 0; i < studentCount; i++)
        {
            Console.WriteLine($"Enter Student {i + 1}. Name:");
            string studentName = Console.ReadLine()!;
            Console.WriteLine($"Enter Student {i + 1}. Last Name:");
            string studentLastName = Console.ReadLine()!;
            try
            {
                _manager.AddStudentToClass(classId, studentName, studentLastName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        Console.WriteLine("Press any key to return");
        Console.ReadKey();
    }
    private void TeacherManagement()
    {
        Console.Clear();
        bool isReturn = false;
        Console.WriteLine("------- Teacher Management --------");
        Console.WriteLine("1. Create Teacher");
        Console.WriteLine("2. Display all teachers");
        Console.WriteLine("3. Return");
        Console.WriteLine("--------------------------");
        Console.Write("Enter your choice: ");
        string? choice = Console.ReadLine();
        while (!isReturn)
        {
            switch (choice)
            {
                case "1":
                    CreateTeacher();
                    isReturn = true;
                    break;
                case "2":
                    DisplayAllTeachers();
                    isReturn = true;
                    break;
                case "3":
                    isReturn = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    private List<String> CreateTeacherMenu()
    {
        List<String> teacherInfo = new List<string>();
        Console.WriteLine("Teacher Name:");
        string? teacherName = Console.ReadLine();
        Console.WriteLine("Teacher Last Name:");
        string? teacherLastName = Console.ReadLine();
        if (teacherName != null) teacherInfo.Add(teacherName);
        if (teacherLastName != null) teacherInfo.Add(teacherLastName);
        return teacherInfo;
    }
    private void CreateTeacher()
    {
        Console.Clear();
        bool isReturn = false;
        while (!isReturn)
        {   Console.WriteLine("Teacher Name:");
            string? teacherName = Console.ReadLine();
            Console.WriteLine("Teacher Last Name:");
            string? teacherLastName = Console.ReadLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine("1. Accept 2. Return");
            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    if (teacherName != null)
                        if (teacherLastName != null)
                            _manager.AddTeacher(teacherName, teacherLastName);
                    isReturn = true;
                    break;
                case "2":
                    isReturn = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    private void DisplayAllTeachers()
    {
        Console.Clear();
        Console.WriteLine("------- All Teachers --------");
        var teachers = _database.GetTeachers();
        foreach (var teacher in teachers)
        {
            Console.WriteLine(teacher.Name + " " + teacher.LastName);
        }
        Console.WriteLine("--------------------------");
        Console.WriteLine("Press any key to return");
        Console.ReadKey();
    }
}
