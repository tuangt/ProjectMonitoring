﻿
namespace ProjectMonitoring.ProjectMonitoring.Columns
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [ColumnsScript("ProjectMonitoring.Classes")]
    [BasedOnRow(typeof(Entities.ClassesRow), CheckNames = true)]
    public class ClassesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignCenter]
        public Int32 Id { get; set; }
        [EditLink]
        public String ClassCode { get; set; }
        public String SubjectCode { get; set; }
        public String MidExamCode { get; set; }
        public String FinalExamCode { get; set; }
        public DateTime StartDate { get; set; }
        [AlignCenter]
        public Int32 IsFinished { get; set; }
    }
}