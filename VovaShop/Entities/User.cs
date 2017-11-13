using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VovaShop.Entities
{
    class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(maximumLength: 128)]
        public string Name { get; set; }

        [Required, StringLength(maximumLength: 128)]
        public string Email { get; set; }

        [Required, StringLength(maximumLength: 128)]
        public string Password { get; set; }

        [Required, StringLength(maximumLength: 128)]
        public string Phone { get; set; }

        [Required, StringLength(maximumLength: 1024)]
        public string PathAvatar { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        public virtual RecycleBin RecycleBin { get; set; }

        public ICollection<BankCard> BankCards { get; set; }
    }
}
