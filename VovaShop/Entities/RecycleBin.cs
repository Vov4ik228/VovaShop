using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VovaShop.Entities
{
    class RecycleBin
    {
        [Key, ForeignKey("UserOf")]
        public int Id { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        public virtual User UserOf { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
