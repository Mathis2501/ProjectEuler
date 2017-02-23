namespace EFandLinq
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("db_owner.PRETTY_HAIR_CUSTOMERS")]
    public partial class PRETTY_HAIR_CUSTOMERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRETTY_HAIR_CUSTOMERS()
        {
            PRETTY_HAIR_ORDERS = new HashSet<PRETTY_HAIR_ORDERS>();
        }

        [Key]
        public int CustomerID { get; set; }

        [Required]
        public string CustomerLastName { get; set; }

        [Required]
        public string CustomerFirstName { get; set; }

        [Required]
        public string CustomerAddress { get; set; }

        [Required]
        public string CustomerPhone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRETTY_HAIR_ORDERS> PRETTY_HAIR_ORDERS { get; set; }
    }
}
