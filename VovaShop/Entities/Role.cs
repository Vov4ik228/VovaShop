using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VovaShop.Entities
{
    class Role
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(maximumLength: 128)]
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
