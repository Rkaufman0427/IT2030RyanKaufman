using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace Week_3_Lab.Models
{
    public class Products
    {
        public int ProductsId { get; set; } 

        [Required(ErrorMessage = "Please enter a Product Name.")]
        public string? ProductName { get; set; }

        [Required(ErrorMessage = "Please enter a Description.")]
        public string? ProductDescription { get; set; }


        [Required(ErrorMessage = "Please enter Product Price.")]
        [Range(0, 9999999, ErrorMessage = "Enter a value between 0 and 9999999.")]
        public double ProductPrice { get; set; }
    }
}
