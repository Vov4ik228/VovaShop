using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VovaShop.Entities
{
    class StorageAddress
    {
        [Key, ForeignKey("StorageOf")]
        public int StorageId { get; set; }

        [ForeignKey("CityOf")]
        public int CityId { get; set; }

        [Required, StringLength(maximumLength: 256)]
        public string Street { get; set; }

        [Required, StringLength(maximumLength: 256)]
        public string HouseNumber { get; set; }

        public virtual Storage StorageOf { get; set; }

        public virtual City CityOf { get; set; }
    }
}
