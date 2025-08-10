namespace WebApplication2.Home
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("info")]
    public partial class info
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        private static int currentId = 0;
        public info()
        {

            ID = ++currentId;
        }
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Picture { get; set; }

        [StringLength(100)]
        public string Description { get; set; }

        [StringLength(100)]
        public string Type { get; set; }

        [StringLength(5000)]
        public string DescriptionBig { get; set; }

      
    }
}
