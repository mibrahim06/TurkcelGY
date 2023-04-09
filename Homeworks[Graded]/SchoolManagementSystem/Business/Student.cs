namespace Business;

public class Student
{
    private static uint _nextStudentId = 1;
    public uint StudentId { get; private init; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public int ClassroomId { get; set; }
    public Student(string name, string lastName, int classroomId)
    {
        StudentId = _nextStudentId++;
        Name = name;
        LastName = lastName;
        ClassroomId = classroomId;
    }
}
