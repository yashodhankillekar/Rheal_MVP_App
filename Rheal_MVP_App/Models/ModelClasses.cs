using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rheal_MVP_App.Models
{
    public class Category
    {
        [Key]
        public int CategoryRowId { get; set; }

        [Required(ErrorMessage = "Category Id is Must")]
        [StringLength(50, ErrorMessage = "Category Name can be 50 characters max")]
        public string CategoryId { get; set; }

        [Required(ErrorMessage = "Category Name is Must")]
        [StringLength(200, ErrorMessage = "Category Name can be 200 characters max")]
        public string CategoryName { get; set; }

        [Required(ErrorMessage = "Base Price is Must")]
        public int CategoryBasePrice { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }

    public class Product
    {
        [Key]
        public int ProductRowId { get; set; }
        
        [Required(ErrorMessage ="Product ID is Required")]
        [StringLength(20, ErrorMessage = "Product ID can be 20 charaters max")]
        public string ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is Required")]
        [StringLength(200, ErrorMessage = "Product name can be 200 charaters max")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Product Manufacturer is Required")]
        [StringLength(200, ErrorMessage = "Product manufacturer can be 200 charaters max")]
        public string ProductManufacturer { get; set; }

        [Required(ErrorMessage = "Product Description is Required")]
        [StringLength(200, ErrorMessage = "Product description can be 200 charaters max")]
        public string ProductDescription { get; set; }

        [Required(ErrorMessage ="Category Id is must")]
        public int CategoryRowId { get; set; }

        public virtual Category Category { get; set; }

    }
    public class ModelClasses
    {
    }
}