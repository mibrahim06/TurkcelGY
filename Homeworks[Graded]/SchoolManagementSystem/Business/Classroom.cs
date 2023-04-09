namespace Business;

public class Classroom
{
    private static int _nextClassroomId = 1;
    public string Name { get; set; }
    public int ClassroomId { get; private init; }
    public int ClassTeacherId { get; set; }
    public Classroom(string name)
    {
        Name = name;
        ClassroomId = _nextClassroomId++;
    }
}
