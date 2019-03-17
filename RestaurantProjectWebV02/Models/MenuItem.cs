using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public Category Category { get; set; }

        #region Only for the View
        [NotMapped] //we dont need for the database
        public List<SelectListItem> AssignableCategories { get; set; }

        [NotMapped] //we dont need for the database
        public int CategoryId { get; set; }
        #endregion Only for the View    
    }
}