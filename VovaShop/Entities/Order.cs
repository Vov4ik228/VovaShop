using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VovaShop.Entities
{
    class Order
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(maximumLength: 256)]
        public string Price { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        public int RecycleBinId { get; set; }
        public RecycleBin RecycleBin { get; set; }

        public virtual OrderAddress OrderAddress { get; set; }

        public ICollection<Goods> Goods { get; set; }
    }
}
