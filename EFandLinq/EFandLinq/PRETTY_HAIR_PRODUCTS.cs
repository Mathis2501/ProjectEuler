namespace EFandLinq
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("db_owner.PRETTY_HAIR_PRODUCTS")]
    public partial class PRETTY_HAIR_PRODUCTS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRETTY_HAIR_PRODUCTS()
        {
            PRETTY_HAIR_ORDERLINE = new HashSet<PRETTY_HAIR_ORDERLINE>();
        }

        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductPrice { get; set; }

        public int ProductAmount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRETTY_HAIR_ORDERLINE> PRETTY_HAIR_ORDERLINE { get; set; }
    }
}
