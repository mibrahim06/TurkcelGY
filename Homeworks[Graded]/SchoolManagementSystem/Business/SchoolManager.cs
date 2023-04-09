namespace Business;

public class SchoolManager
{
    private Database Database { get; set; }
    public SchoolManager(Database database)
    {
        Database = database;
    }
    
    public void AddStudent(string firstName, string lastName, int classroomId)
    {
        Database.AddStudent(firstName, lastName, classroomId);
    }
    
    public void AddClassroom(string classroomName)
    {
        Database.AddClassroom(classroomName);
    }
    
    public void AddTeacher(string firstName, string lastName)
    {
        Database.AddTeacher(firstName, lastName);
    }
    
    public void CreateClassroom(string classroomName, string teacherFirstName, string teacherLastName)
    {
        var teacher = Database.AddTeacher(teacherFirstName, teacherLastName);
        teacher.HasResponsibleClassroom = true;
        var classroom = Database.AddClassroom(classroomName);
        classroom.ClassTeacherId = teacher.TeacherId;
    }
    
    public Classroom CreateClassroom(string classroomName, int teacherId)
    {
        var teacher = Database.GetTeacher(teacherId);
        teacher.HasResponsibleClassroom = true;

        var classroom = Database.AddClassroom(classroomName);
        classroom.ClassTeacherId = teacherId;

        return classroom;
    }

    public List<Teacher> GetTeachersByName(string name)
    {
        var result = Database.GetTeachers().Where(teacher => teacher.Name == name).ToList();
        if(result.Count == 0)
        {
            throw new ArgumentException("Teacher not found");
        }

        return result;
    }

    public List<Teacher> GetTeachersByLastName(string lastName)
    {
        var result = Database.GetTeachers().Where(teacher => teacher.LastName == lastName).ToList();
        if(result.Count == 0)
        {
            throw new ArgumentException("Teacher not found");
        }

        return result;
    }
    
    public Teacher GetTeacherById(int teacherId)
    {
        if (Database?.GetTeacher(teacherId) == null)
        {
            throw new ArgumentException("Teacher not found");
        }
        return Database.GetTeacher(teacherId);
    }
    
    public List<Student> GetStudentsByName(string name)
    {
        var result = Database.GetStudents().Where(student => student.Name == name).ToList();
        if(result.Count == 0)
        {
            throw new ArgumentException("Student not found");
        }
        return result;
    }
    
    public List<Student> GetStudentsByLastName(string lastName)
    {
        var result = Database.GetStudents().Where(student => student.LastName == lastName).ToList();
        if(result.Count == 0)
        {
            throw new ArgumentException("Student not found");
        }

        return result;
    }
    
    public Student GetStudentById(int studentId)
    {
        if (Database.GetStudents().Where(student => student.StudentId == studentId).ToList().Count == 0)
        {
            throw new ArgumentException("Student not found");
        }
        return Database.GetStudents().Where(student => student.StudentId == studentId).ToList().First();
    }

    public List<string> GetTeacherInfo(int teacherId)
    {
        if (Database?.GetTeacher(teacherId) == null)
        {
            throw new ArgumentException("Teacher not found");
        }
        var teacher = Database.GetTeacher(teacherId);
        return new List<string> { teacher.Name, teacher.LastName };
    }
    public void AddStudentToClass(int classId,string  studentName,string  studentLastName)
    {
        var classroom = Database.GetClassroom(classId);
        var student = Database.AddStudent(studentName, studentLastName, classId);
    }
    
    public Classroom GetClassroomById(int classroomId)
    {
        if (Database?.GetClassroom(classroomId) == null)
        {
            throw new ArgumentException("Classroom not found");
        }
        return Database.GetClassroom(classroomId);
    }
    
    public List<Classroom> GetClassroomByName(string classroomName)
    {
        var result = Database.GetClassrooms().Where(classroom => classroom.Name == classroomName).ToList();
        if(result.Count == 0)
        {
            throw new ArgumentException("Classroom not found");
        }
        return result;
    }
}