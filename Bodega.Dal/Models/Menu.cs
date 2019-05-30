using System;
using System.Collections.Generic;
using System.Text;

namespace Bodega.Dal.Models
{
    public class Menu
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public DateTime Posted { get; set; }
    }
}
