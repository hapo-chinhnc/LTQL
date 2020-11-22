using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQLTutorial.Models
{
    public class HoaDon
    {
        [Key]
        public int id { get; set; }
        [Required, Range(0, 10000000)]
        public int tien { get; set; }
        public int KhachHang_id { get; set; }
        [ForeignKey("KhachHang_id")]
        public virtual KhachHang KhachHang { get; set; }
    }
}