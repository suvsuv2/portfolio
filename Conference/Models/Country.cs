namespace Conference.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(100)]
        public string CountryNameRus { get; set; }

        [StringLength(100)]
        public string CountryNameEng { get; set; }

        [StringLength(100)]
        public string CodeText { get; set; }

        public int CodeNumber { get; set; }
    }
}
