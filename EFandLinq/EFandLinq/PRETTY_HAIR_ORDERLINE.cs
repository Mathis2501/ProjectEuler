namespace EFandLinq
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("db_owner.PRETTY_HAIR_ORDERLINE")]
    public partial class PRETTY_HAIR_ORDERLINE
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderAmount { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }

        public virtual PRETTY_HAIR_ORDERS PRETTY_HAIR_ORDERS { get; set; }

        public virtual PRETTY_HAIR_PRODUCTS PRETTY_HAIR_PRODUCTS { get; set; }
    }
}
