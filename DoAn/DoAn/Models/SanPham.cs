namespace DoAn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]
        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(10)]
        public string MaLSP { get; set; }

        [StringLength(10)]
        public string MaNSX { get; set; }

        public string TenSP { get; set; }

        public string CauHinh { get; set; }

        [StringLength(50)]
        public string HinhChinh { get; set; }

        [StringLength(50)]
        public string Hinh1 { get; set; }

        [StringLength(50)]
        public string Hinh2 { get; set; }

        [StringLength(50)]
        public string Hinh3 { get; set; }

        [StringLength(50)]
        public string Hinh4 { get; set; }

        public int? Gia { get; set; }

        public int? SoLuongDaBan { get; set; }

        [StringLength(10)]
        public string TinhTrang { get; set; }
    }
}
