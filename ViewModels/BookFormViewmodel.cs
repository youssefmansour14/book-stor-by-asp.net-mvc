using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Day3.Models;
using Day3.Models;

namespace Day3.ViewModels
{
    public class BookFormViewmodel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Title { get; set; }
        [Required]
        [MaxLength(256)]
        public string Author { get; set; }
 
      
        [Display(Name = "Category")]
        public int CategoryId { get; set; }



        public IEnumerable<Category> categories { get; set; }
    }
}