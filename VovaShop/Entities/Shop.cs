using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VovaShop.Entities
{
    class Shop
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(maximumLength: 256)]
        public string Name { get; set; }

        [Required, StringLength(maximumLength: 256)]
        public string Rating { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        public ICollection<Storage> Storages { get; set; }
    }
}
