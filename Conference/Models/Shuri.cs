namespace Conference.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Shuri")]
    public partial class Shuri
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(100)]
        public string FIO { get; set; }

        [StringLength(7)]
        public string Gender { get; set; }

        [StringLength(100)]
        public string Mail { get; set; }

        [Column(TypeName = "date")]
        public DateTime? BirthdayData { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        [StringLength(100)]
        public string TelephoneNumber { get; set; }

        [StringLength(100)]
        public string Specialization { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(100)]
        public string Photo { get; set; }
    }
}
