using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VovaShop.Entities
{
    class BankCard
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Code { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        public int UserId { get; set; }
        public User UserOf { get; set; }
    }
}
