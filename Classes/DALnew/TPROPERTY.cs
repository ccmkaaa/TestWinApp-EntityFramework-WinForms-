namespace TestWinApp.Classes.DALnew
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TPROPERTY")]
    public partial class TPROPERTY
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [StringLength(25)]
        public string Name { get; set; }

        [StringLength(25)]
        public string Value { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ID_Group { get; set; }

        public virtual TGROUP TGROUP { get; set; }
    }
}
