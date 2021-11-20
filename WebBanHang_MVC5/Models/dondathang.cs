namespace Ictshop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dondathang")]
    public partial class dondathang
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Madon { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Masp { get; set; }

        public int? Soluong { get; set; }

        public decimal? Dongia { get; set; }

        public virtual Donhang Donhang { get; set; }

        public virtual Sanpham Sanpham { get; set; }
    }
}
