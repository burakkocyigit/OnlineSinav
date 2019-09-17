﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineSinav.UI.WinFormAdmin.Models
{
    class Exam
    {
        public int ExamID { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public uint Duration { get; set; }
        public bool IsActive { get; set; }
        public int LessonID { get; set; }
        public int CategoryID { get; set; }
        public string LessonName { get; set; }
        public string CategoryName { get; set; }
    }
}
