namespace DAL.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CourseRegisteration")]
    public partial class CourseRegisteration
    {
        public int CourseRegisterationID { get; set; }

        public int StudentID { get; set; }

        public int CourseID { get; set; }

        public int SemestersID { get; set; }

        public virtual Cours Cours { get; set; }

        public virtual Semester Semester { get; set; }

        public virtual Student Student { get; set; }
    }
}
