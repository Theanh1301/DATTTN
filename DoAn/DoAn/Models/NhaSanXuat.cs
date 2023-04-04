namespace DoAn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaSanXuat")]
    public partial class NhaSanXuat
    {
        [Key]
        [StringLength(10)]
        public string MaNSX { get; set; }

        [StringLength(50)]
        public string TenNSX { get; set; }
    }
}
