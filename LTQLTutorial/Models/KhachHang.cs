using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LTQLTutorial.Models
{
    public class KhachHang
    {
        [Key]
        public int id { get; set; }
        [Required, StringLength(30)]
        public string name { get; set; }
        [Required]
        public string phone { get; set; }
        public string address { get; set; }
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}