namespace TestWinApp.Classes.DALnew 
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRELATION")]
    public partial class TRELATION
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ID_Parent { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ID_Child { get; set; }

        public virtual TGROUP TGROUP { get; set; }

        public virtual TGROUP TGROUP1 { get; set; }
    }
}
