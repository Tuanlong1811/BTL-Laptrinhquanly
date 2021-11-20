namespace Ictshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sanpham")]
    public partial class Sanpham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sanpham()
        {
            dondathangs = new HashSet<dondathang>();
        }

        [Key]
        [Display(Name = "Mã sản phẩm")]
        public int Masp { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên sản phẩm")]
        public string Tensp { get; set; }
        [Display(Name = "Giá tiền")]
        public decimal? Giatien { get; set; }

        [Display(Name = "Số lượng")]
        public int? Soluong { get; set; }

        [Column(TypeName = "ntext")]
        [Display(Name = "Mô tả")]
        public string Mota { get; set; }

        [Display(Name = "Thẻ sim")]
        public int? Thesim { get; set; }
        [Display(Name = "Bộ nhớ trong")]

        public int? Bonhotrong { get; set; }
        [Display(Name = "Sản phẩm mới")]

        public bool? Sanphammoi { get; set; }

        public int? Ram { get; set; }

        [StringLength(100)]
        [Display(Name = "Hình ảnh sản phẩm")]
        public string Anhbia { get; set; }
        [Display(Name = "Hãng sản xuất")]

        public int? Mahang { get; set; }
        [Display(Name = "Hệ điều hành")]

        public int? Mahdh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dondathang> dondathangs { get; set; }

        public virtual Hangsanxuat Hangsanxuat { get; set; }

        public virtual Hedieuhanh Hedieuhanh { get; set; }
        [NotMapped]
        public virtual List<Hangsanxuat> HangCollection { get; set; }
        [NotMapped]
        public virtual List<Hedieuhanh> HeDhCollection { get; set; }
    }
}
