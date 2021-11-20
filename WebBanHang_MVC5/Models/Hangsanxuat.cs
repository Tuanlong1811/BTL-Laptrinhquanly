namespace Ictshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hangsanxuat")]
    public partial class Hangsanxuat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hangsanxuat()
        {
            Sanphams = new HashSet<Sanpham>();
        }

        [Key]
        [Display(Name ="M� h�ng")]
        public int Mahang { get; set; }

        [StringLength(10)]
        [Display(Name = "T�n h�ng")]
        public string Tenhang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sanpham> Sanphams { get; set; }
    }
}
