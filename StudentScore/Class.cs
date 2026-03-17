using System;
using System.Collections.Generic;
using System.Text;

class Student
{
    public string Name { get; }
    public string Subject { get; }
    public int Score { get; }


    public Student(string name, string subject, int score)
    {
        Name = name;
        Subject = subject;
        Score = score;
    }

}