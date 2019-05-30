using System;
using System.Collections.Generic;
using System.Text;

namespace Bodega.Dal.Dtos
{
    public class AddMenuDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
