using System;
using System.Collections.Generic;

namespace myConsoleApp.Models
{
    public class SubjectManage
    {
        public SubjectInfo SubjectInfo { get; set; }
        public double Score { get; set; }
    }
    
    public class SubjectInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
    }

    public class Subject
    {
        public static SubjectInfo Math = new SubjectInfo { Id = "M601", Name = "Mathematics", Weight = 3 };
        public static SubjectInfo Sci = new SubjectInfo { Id = "S601", Name = "Science", Weight = 3 };
        public static SubjectInfo Eng = new SubjectInfo { Id = "E601", Name = "English", Weight = 2.5 };
        public static SubjectInfo Art = new SubjectInfo { Id = "A601", Name = "Art", Weight = 1.5 };
    }
}