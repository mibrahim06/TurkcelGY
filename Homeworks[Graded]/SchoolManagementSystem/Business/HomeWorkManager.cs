namespace Business;

public class HomeWorkManager
{
    private Database Database { get; init; }
    public HomeWorkManager(Database database)
    {
        Database = database;
    }
    public void SubmitHomeWork(int studentId, int classroomId, string homeWork)
    {
        var date = DateTime.Now;
        Database.SubmitHomeWork(studentId, classroomId, homeWork, date);
    }
}
