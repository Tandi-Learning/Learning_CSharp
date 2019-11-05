using System.Collections.Generic;

public class Teacher
{
    public Teacher(
        string firstName,
        string lastName,
        string subject)
    {
        FirstName = firstName;
        LastName = lastName;
        Subject  = subject;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Subject { get; private set; }

    public void Deconstruct(
        out string firstName,
        out string lastName,
        out string subject)
    {
        firstName = FirstName;
        lastName = LastName;
        subject = Subject;
    }
}

public class Student
{
    public Student(
        string firstName,
        string lastName,
        Teacher homeRoomTeacher,
        int gradeLevel)
    {
        FirstName = firstName;
        LastName = lastName;
        HomeRoomTeacher = homeRoomTeacher;
        GradeLevel = gradeLevel;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public Teacher HomeRoomTeacher { get; private set; }
    public int GradeLevel { get; private set; }

    public string FullName => $"{FirstName} {LastName}";

    public void Deconstruct(
        out string firstName,
        out string lastName,
        out Teacher homeRoomTeacher,
        out int gradeLevel)
    {
        firstName = FirstName;
        lastName = LastName;
        homeRoomTeacher = HomeRoomTeacher;
        gradeLevel = GradeLevel;
    }
}

public class PatternSample
{
    public bool IsInSeventhGradeMathPositional(Student student)
    {
        // can also be written in a more consice form
        // student is (_, _, (_, _, "Math"), 7);
        return student is Student(_, _, Teacher(_, _, "Math"), 7);
    }

    public bool IsInSeventhGradeMathProperty(Student student)
    {
        return student is { GradeLevel: 7, HomeRoomTeacher: { Subject: "Math" } };
    }
}