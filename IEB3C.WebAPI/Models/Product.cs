using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IEB3C.WebAPI.Models
{
    public class Product
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Product Code is required", AllowEmptyStrings = false)]
        [MinLength(6, ErrorMessage = "Product Code min lenght is 6 characters")]
        public string ProductCode { get; set; }
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Product Code is required", AllowEmptyStrings = false)]
        [MinLength(5, ErrorMessage = "Product Code min lenght is 6 characters")]
        [MaxLength(11, ErrorMessage = "Product Code max lenght is 12 characters")]
        public string ProductName { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}