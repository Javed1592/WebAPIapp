using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class ProductDetail
    {
        [Key]

        public int ProductId { get; set; }

        [Required]
        [Column(TypeName = "Nvarchar(100)")]
        public string productname { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string description { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string MRC { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string NRC { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string discount { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string username { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string date { get; set; }

    }
}
