using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VovaShop.Entities
{
    class Goods
    {
        [Key]
        public int Id { get; set; }

        public int OrderId { get; set; }       

        [Required, StringLength(maximumLength: 256)]
        public string Name { get; set; }

        [Required, StringLength(maximumLength: 256)]
        public string Price { get; set; }

        [Required, StringLength(maximumLength: 256)]
        public string Quarantee { get; set; }

        public Order Order { get; set; }

        public ICollection<Category> Category { get; set; }
    }
}
