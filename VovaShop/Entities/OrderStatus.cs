using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VovaShop.Entities
{
    class OrderStatus
    {
        [Key, ForeignKey("OrderOf")]
        public int Id { get; set; }

        [Required, StringLength(maximumLength: 256)]
        public string Status { get; set; }

        public virtual Order OrderOf { get; set; }
    }
}
