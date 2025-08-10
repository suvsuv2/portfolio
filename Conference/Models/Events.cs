namespace Conference.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Events
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int EventNumber { get; set; }

        [StringLength(100)]
        public string EventName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? EventDate { get; set; }

        public int EventDays { get; set; }

        public int EventCity { get; set; }

        [StringLength(100)]
        public string EventPicture { get; set; }

        [StringLength(100)]
        public string EventDirection { get; set; }
    }
}
