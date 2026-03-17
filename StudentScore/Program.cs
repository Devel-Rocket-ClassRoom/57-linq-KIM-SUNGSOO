using System;
using System.Collections.Generic;
using System.Linq;


class Score
{
    static void Main()
    {
        List<Student> studentsGrade = new List<Student>
        {
            new Student("김철수", "수학", 85),
            new Student("김철수", "영어", 78),
            new Student("이영희", "수학", 92),
            new Student("이영희", "영어", 88),
            new Student("박민수", "수학", 76),
            new Student("박민수", "영어", 82),
            new Student("정지은", "수학", 95),
            new Student("정지은", "영어", 91),
        };


        Console.WriteLine("=== 문제 1: 85점 이상 ===");
        var overScore = studentsGrade.Where(n => n.Score >= 85);
        foreach (var student in overScore)
        {
            Console.WriteLine($"{student.Name} - {student.Subject}: {student.Score}점");
        }

        Console.WriteLine("=== 문제 2: 수학 과목 ===");

        var mathScore = studentsGrade.Where(n => n.Subject == "수학");
        foreach (var student in mathScore)
        {
            Console.WriteLine($"{student.Name} - {student.Subject}: {student.Score}점");
        }

        Console.WriteLine("=== 문제 3: 점수 내림차순 ===");
        var downsortScore = studentsGrade.OrderByDescending(n => n.Score);
        foreach (var student in downsortScore)
        {
            Console.WriteLine($"{student.Name} - {student.Subject}: {student.Score}점");
        }
        Console.WriteLine("=== 문제 4: 전체 평균 ===");
        var avgScore = studentsGrade.Average(n => n.Score);
        Console.WriteLine($"{avgScore:F3}점");

        Console.WriteLine("=== 문제 5: 수학 최고/최저 점수 ===");
        var mathMaxScore = studentsGrade.Where(n => n.Subject == "수학")
                                         .Max(n => n.Score);
        var mathMinScore = studentsGrade.Where(n => n.Subject == "수학")
                                        .Min(n => n.Score);
        Console.WriteLine($"최고 : {mathMaxScore}점");
        Console.WriteLine($"최저 : {mathMinScore}점");


        Console.WriteLine("=== 문제 6: 영어 90점 이상 존재 여부 ===");

        bool trueScore = studentsGrade.Where(n=> n.Subject =="영어")
                                        .Any(n => n.Score >=90);

        Console.WriteLine(trueScore);


        Console.WriteLine("=== 문제 7: 모두 70점 이상 존재 여부 ===");

        bool allScore = studentsGrade.Any(n=> n.Score >= 70);
        Console.WriteLine(allScore);

        Console.WriteLine("=== 문제 8: 학생 이름 (중복 제거) ===");

        Console.WriteLine("=== 문제 9: 수학 최고점 학생 ===");

        Console.WriteLine("=== 문제 10: 과목별 정렬 ===");

    }
}