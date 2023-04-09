namespace Business;

public class HomeWork
{
    private static int _nextHomeWorkId;
    public int HomeWorkId { get; private init; }
    public int StudentId { get; set; }
    public int ClassroomId { get; set; }
    public string? Content { get; set; }
    public DateTime SubmissionDate { get; set; }
    
    public HomeWork(int studentId, int classroomId, string? content, DateTime submissionDate)
    {
        StudentId = studentId;
        ClassroomId = classroomId;
        Content = content;
        SubmissionDate = submissionDate;
        HomeWorkId = _nextHomeWorkId++;
    }
}
