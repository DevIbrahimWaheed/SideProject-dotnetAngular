using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



// this is Model

namespace PaymentSystem.Models
{
    public class PaymentDetails
    {
        // mask the primay KEY
        [Key]
        public int PaymentDetailId { get; set; }

        [Column(TypeName ="nvarchar(100)")] 
        public string CardName { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string CardNumber { get; set; }


        [Column(TypeName = "nvarchar(5)")]
        public string  ExpireDate { get; set; }

        [Column(TypeName = "nvarchar(3)")]
        public  string SecurityCode { get; set; }

    }
}
