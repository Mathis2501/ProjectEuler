namespace EFandLinq
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("db_owner.PRETTY_HAIR_ORDERS")]
    public partial class PRETTY_HAIR_ORDERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRETTY_HAIR_ORDERS()
        {
            PRETTY_HAIR_ORDERLINE = new HashSet<PRETTY_HAIR_ORDERLINE>();
        }

        [Key]
        public int OrderID { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDeliveryDate { get; set; }

        public int CustomerID { get; set; }

        public virtual PRETTY_HAIR_CUSTOMERS PRETTY_HAIR_CUSTOMERS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRETTY_HAIR_ORDERLINE> PRETTY_HAIR_ORDERLINE { get; set; }
    }
}
