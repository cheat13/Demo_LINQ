using System;
using System.Linq;
using System.Collections.Generic;
using myConsoleApp.Models;
using System.Collections;

namespace myConsoleApp
{
    class Program
    {
        public static List<StudentInfo> StdLst = StudentManage.StudentLst;
        public static List<TeacherInfo> TchLst = TeacherManage.TeacherLst;
        static void Main(string[] args)
        {
            var qry = StdLst
                .SelectMany(std =>
                    std.SubjectLst,
                    (std, sub) =>
                        new
                        {
                            Name = std.Name,
                            Subject = sub.SubjectInfo.Name,
                            Score = sub.Score
                        })
                .OrderBy(std => std.Subject)
                .ThenByDescending(std => std.Score);

            foreach (var item in qry)
                Console.WriteLine(item);
        }
    }
}
