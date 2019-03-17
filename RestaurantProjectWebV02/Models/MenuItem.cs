using System;
using System.Collections.Generic;
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

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}