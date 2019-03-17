using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestaurantProjectWebV02.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Display(Name = "Category")]
        public string Name { get; set; }

        public List<MenuItem> MenuItems { get; set; }
    }
}