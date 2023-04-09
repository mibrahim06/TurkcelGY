namespace Business;

public class Teacher
{
    private static int _nextTeacherId = 1;
    public int TeacherId { get; private init; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public bool HasResponsibleClassroom { get; set; } = false;
    public Teacher(string name, string lastName)
    {
        TeacherId = _nextTeacherId++;
        Name = name;
        LastName = lastName;
    }
}
