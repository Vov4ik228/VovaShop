using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VovaShop.Entities
{
    class Country
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(maximumLength: 256)]
        public string Name { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
