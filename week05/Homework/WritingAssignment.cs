using System;
public class WritingAssignment : Assignment
{
    private String _title;

    public WritingAssignment ( String studentName, String topic, String title ): base ( studentName, topic)
    {
        _title=title;
    }
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}