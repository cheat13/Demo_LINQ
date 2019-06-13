using System;
using System.Collections.Generic;

namespace myConsoleApp.Models
{
    public class StudentInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<SubjectManage> SubjectLst { get; set; }
    }

    public class StudentManage
    {
        public static List<StudentInfo> StudentLst = new List<StudentInfo>
        {
            new StudentInfo
            {
                Id = "001",
                Name = "Mr.01",
                Age = 17,
                SubjectLst = new List<SubjectManage>
                    {
                        new SubjectManage{ SubjectInfo = Subject.Math, Score = 85 }
                    }
            },
            new StudentInfo
            {
                Id = "002",
                Name = "Mr.02",
                Age = 19,
                SubjectLst = new List<SubjectManage>
                    {
                        new SubjectManage{ SubjectInfo = Subject.Sci, Score = 90 }
                    }
            },
            new StudentInfo
            {
                Id = "003",
                Name = "Mr.03",
                Age = 18,
                SubjectLst = new List<SubjectManage>
                    {
                        new SubjectManage{ SubjectInfo = Subject.Eng, Score = 75 }
                    }
            },
            new StudentInfo
            {
                Id = "004",
                Name = "Mr.04",
                Age = 20,
                SubjectLst = new List<SubjectManage>
                    {
                        new SubjectManage{ SubjectInfo = Subject.Art, Score = 90 }
                    }
            },
            new StudentInfo
            {
                Id = "005",
                Name = "Mr.05",
                Age = 18,
                SubjectLst = new List<SubjectManage>
                    {
                        new SubjectManage{ SubjectInfo = Subject.Math, Score = 68 },
                        new SubjectManage{ SubjectInfo = Subject.Sci, Score = 58 }
                    }
            },
            new StudentInfo
            {
                Id = "006",
                Name = "Mr.06",
                Age = 18,
                SubjectLst = new List<SubjectManage> 
                    {
                        new SubjectManage{ SubjectInfo = Subject.Math, Score = 75 },
                        new SubjectManage{ SubjectInfo = Subject.Eng, Score = 85 }
                    }
            },
            new StudentInfo
            {
                Id = "007",
                Name = "Mr.07",
                Age = 19,
                SubjectLst = new List<SubjectManage> 
                    {
                        new SubjectManage{ SubjectInfo = Subject.Math, Score = 98 },
                        new SubjectManage{ SubjectInfo = Subject.Art, Score = 62 }
                    }
            },
            new StudentInfo
            {
                Id = "008",
                Name = "Mr.08",
                Age = 16,
                SubjectLst = new List<SubjectManage> 
                    {
                        new SubjectManage{ SubjectInfo = Subject.Sci, Score = 73 },
                        new SubjectManage{ SubjectInfo = Subject.Eng, Score = 75 }
                    }
            },
            new StudentInfo
            {
                Id = "009",
                Name = "Mr.09",
                Age = 17,
                SubjectLst = new List<SubjectManage> 
                    {
                        new SubjectManage{ SubjectInfo = Subject.Sci, Score = 64 },
                        new SubjectManage{ SubjectInfo = Subject.Art, Score = 59 }
                    }
            },
            new StudentInfo
            {
                Id = "010",
                Name = "Mr.10",
                Age = 18,
                SubjectLst = new List<SubjectManage> 
                    {
                        new SubjectManage{ SubjectInfo = Subject.Art, Score = 68 }
                    }
            },
            new StudentInfo
            {
                Id = "011",
                Name = "Mr.11",
                Age = 20,
                SubjectLst = new List<SubjectManage> 
                    {
                        new SubjectManage{ SubjectInfo = Subject.Math, Score = 80 },
                        new SubjectManage{ SubjectInfo = Subject.Eng, Score = 79 }
                    }
            },
            new StudentInfo
            {
                Id = "012",
                Name = "Mr.12",
                Age = 17,
                SubjectLst = new List<SubjectManage> 
                    {
                        new SubjectManage{ SubjectInfo = Subject.Math, Score = 68 },
                        new SubjectManage{ SubjectInfo = Subject.Sci, Score = 76 },
                    }
            },
            new StudentInfo
            {
                Id = "013",
                Name = "Mr.13",
                Age = 16,
                SubjectLst = new List<SubjectManage> 
                    {
                        new SubjectManage{ SubjectInfo = Subject.Math, Score = 85 },
                    }
            },
            new StudentInfo
            {
                Id = "014",
                Name = "Mr.14",
                Age = 17,
                SubjectLst = new List<SubjectManage> 
                    {
                        new SubjectManage{ SubjectInfo = Subject.Sci, Score = 76 },
                        new SubjectManage{ SubjectInfo = Subject.Eng, Score = 76 },
                    }
            },
            new StudentInfo
            {
                Id = "015",
                Name = "Mr.15",
                Age = 20,
                SubjectLst = new List<SubjectManage> 
                    {
                        new SubjectManage{ SubjectInfo = Subject.Math, Score = 67 },
                        new SubjectManage{ SubjectInfo = Subject.Sci, Score = 86 },
                        new SubjectManage{ SubjectInfo = Subject.Eng, Score = 87 },
                        new SubjectManage{ SubjectInfo = Subject.Art, Score = 76 }
                    }
            },
            new StudentInfo
            {
                Id = "016",
                Name = "Mr.16",
                Age = 20,
                SubjectLst = new List<SubjectManage> 
                    {
                        new SubjectManage{ SubjectInfo = Subject.Math, Score = 49 },
                        new SubjectManage{ SubjectInfo = Subject.Sci, Score = 50 },
                        new SubjectManage{ SubjectInfo = Subject.Eng, Score = 68 },
                        new SubjectManage{ SubjectInfo = Subject.Art, Score = 79 }
                    }
            },
            new StudentInfo
            {
                Id = "017",
                Name = "Mr.17",
                Age = 20,
                SubjectLst = new List<SubjectManage> 
                    {
                        new SubjectManage{ SubjectInfo = Subject.Math, Score = 61 },
                        new SubjectManage{ SubjectInfo = Subject.Sci, Score = 67 },
                        new SubjectManage{ SubjectInfo = Subject.Eng, Score = 59 },
                        new SubjectManage{ SubjectInfo = Subject.Art, Score = 86 }
                    }
            },
            new StudentInfo
            {
                Id = "018",
                Name = "Mr.18",
                Age = 20,
                SubjectLst = new List<SubjectManage> 
                    {
                        new SubjectManage{ SubjectInfo = Subject.Math, Score = 47 },
                        new SubjectManage{ SubjectInfo = Subject.Sci, Score = 99 },
                        new SubjectManage{ SubjectInfo = Subject.Eng, Score = 76 },
                        new SubjectManage{ SubjectInfo = Subject.Art, Score = 72 }
                    }
            },
            new StudentInfo
            {
                Id = "019",
                Name = "Mr.19",
                Age = 20,
                SubjectLst = new List<SubjectManage> 
                    {
                        new SubjectManage{ SubjectInfo = Subject.Math, Score = 65 },
                        new SubjectManage{ SubjectInfo = Subject.Sci, Score = 73 },
                        new SubjectManage{ SubjectInfo = Subject.Eng, Score = 71 },
                        new SubjectManage{ SubjectInfo = Subject.Art, Score = 74 }
                    }
            },
            new StudentInfo
            {
                Id = "020",
                Name = "Mr.20",
                Age = 20,
                SubjectLst = new List<SubjectManage> 
                    {
                        new SubjectManage{ SubjectInfo = Subject.Math, Score = 61 },
                        new SubjectManage{ SubjectInfo = Subject.Sci, Score = 55 },
                        new SubjectManage{ SubjectInfo = Subject.Eng, Score = 75 },
                        new SubjectManage{ SubjectInfo = Subject.Art, Score = 72 }
                    }
            },
        };
    }
}