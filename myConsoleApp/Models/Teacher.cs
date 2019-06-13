using System;
using System.Collections.Generic;

namespace myConsoleApp.Models
{
    public class TeacherInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<SubjectInfo> SubjectLst { get; set; }
    }

    public class TeacherManage
    {
        public static List<TeacherInfo> TeacherLst = new List<TeacherInfo>
        {
            new TeacherInfo
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Tc.01",
                Age = 25,
                SubjectLst = new List<SubjectInfo> { Subject.Math , Subject.Sci }
            },
            new TeacherInfo
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Tc.02",
                Age = 24,
                SubjectLst = new List<SubjectInfo> { Subject.Eng }
            },
            new TeacherInfo
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Tc.03",
                Age = 26,
                SubjectLst = new List<SubjectInfo> { Subject.Art }
            },
        };
    }
}