using System;
using System.Linq;
using System.Collections.Generic;
using myConsoleApp.Models;

namespace myConsoleApp
{
    class Program
    {
        public static List<StudentInfo> StdLst = StudentManage.StudentLst;
        public static List<TeacherInfo> TchLst = TeacherManage.TeacherLst;
        static void Main(string[] args)
        {
            var query = StdLst
                .SelectMany(std =>
                    std.SubjectLst.Where(sub => sub.Score >= 80),
                    (std, subject) =>
                        new
                        {
                            Name = std.Name,
                            Subject = subject.SubjectInfo.Name,
                            Score = subject.Score,
                        })
                .OrderBy(qry => qry.Subject)
                .ThenByDescending(qry => qry.Score);

            foreach (var std in query)
                Console.WriteLine(std);
        }
    }
}
