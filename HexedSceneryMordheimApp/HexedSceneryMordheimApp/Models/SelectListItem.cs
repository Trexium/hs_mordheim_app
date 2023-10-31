using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexedSceneryMordheimApp.Models
{
    public class SelectListItem
    {
        public SelectListItem() { }
        public SelectListItem(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
