namespace Conference.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Activity")]
    public partial class Activity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int ActivityNumber { get; set; }

        [StringLength(500)]
        public string ActivityName { get; set; }

        [StringLength(500)]
        public string BeginDate { get; set; }

        public int Days { get; set; }

        [StringLength(500)]
        public string ActivityEvent { get; set; }

        [Required]
        [StringLength(50)]
        public string DayCount { get; set; }

        [StringLength(50)]
        public string BeginTime { get; set; }

        [StringLength(500)]
        public string Moderator { get; set; }

        [StringLength(500)]
        public string Shuri1 { get; set; }

        [StringLength(500)]
        public string Shuri2 { get; set; }

        [StringLength(500)]
        public string Shuri3 { get; set; }

        [StringLength(500)]
        public string Shuri4 { get; set; }

        [StringLength(500)]
        public string Shuri5 { get; set; }

        [StringLength(500)]
        public string Winner { get; set; }
    }
}
