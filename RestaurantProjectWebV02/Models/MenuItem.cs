using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantProjectWebV02.Models
{
    /// <summary>
    /// One item on Menu
    /// </summary>
    public class MenuItem
    {
        /// <summary>
        /// Primary Key PK
        /// </summary>
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }
    }
}