namespace Ictshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Donhang")]
    public partial class Donhang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Donhang()
        {
            dondathangs = new HashSet<dondathang>();
        }

        [Key]
        public int Madon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngaydat { get; set; }

        public int? TinhTrang { get; set; }

        public int? MaNguoiDung { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dondathang> dondathangs { get; set; }

        public virtual Nguoidung Nguoidung { get; set; }
    }
}
