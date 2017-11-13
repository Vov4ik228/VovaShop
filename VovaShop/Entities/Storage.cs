using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VovaShop.Entities
{
    class Storage
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(maximumLength: 256)]
        public string Name { get; set; }

        public int ShopId { get; set; }
        public Shop Shop { get; set; }

        public virtual StorageAddress StorageAddress{ get; set; }
    }
}
