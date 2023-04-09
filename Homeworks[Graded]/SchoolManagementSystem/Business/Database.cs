namespace Business;

public class Database
{
    private readonly List<Student>  _students = new List<Student>();
    private readonly List<Teacher> _teachers = new List<Teacher>();
    private readonly List<Classroom> _classrooms = new List<Classroom>();
    private readonly List<HomeWork> _homeWorks = new List<HomeWork>();

    public List<Student> GetStudents()
    {
        return _students;
    }
    
    public List<Teacher> GetTeachers()
    {
        return _teachers;
    }
    
    public List<Classroom> GetClassrooms()
    {
        return _classrooms;
    }
    
    public List<HomeWork> GetHomeWorks()
    {
        return _homeWorks;
    }
    
    public HomeWork SubmitHomeWork(int studentId, int classroomId, string? content, DateTime submissionDate)
    {
        HomeWork homeWork = new HomeWork(studentId, classroomId, content, submissionDate);
        _homeWorks.Add(homeWork);
        return homeWork;
    }

    public Student AddStudent(string firstName, string lastName, int classroomId)
    {
        Student student = new Student(firstName, lastName, classroomId);
        _students.Add(student);
        return student;
    }
    
    public List<Teacher> GetAvailableTeachers()
    {
        return _teachers.Where(t => !t.HasResponsibleClassroom).ToList();
    }
    public Classroom AddClassroom(string classroomName)
    {
        Classroom classroom = new Classroom(classroomName);
        _classrooms.Add(classroom);
        return classroom;
    }
    
    public Teacher AddTeacher(string firstName, string lastName)
    {
        Teacher teacher = new Teacher(firstName, lastName);
        _teachers.Add(teacher);
        return teacher;
    }
    
    public Classroom GetClassroom(int classroomId)
    {
        var classroom = _classrooms.ToList().FirstOrDefault(c => c.ClassroomId == classroomId);
        if (classroom == null)
        {
            throw new Exception($"Classroom with id {classroomId} not found");
        }
        return classroom;
    }
    
    public Teacher GetTeacher(int teacherId)
    {
        var teacher = _teachers.ToList().FirstOrDefault(t => t.TeacherId == teacherId);
        if (teacher == null)
        {
            throw new Exception($"Teacher with id {teacherId} not found");
        }
        return teacher;
    }
    
    public Student GetStudent(int studentId)
    {
        var student = _students.ToList().FirstOrDefault(s => s.StudentId == studentId);
        if (student == null)
        {
            throw new Exception($"Student with id {studentId} not found");
        }
        return student;
    }
}
