using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Boutique.Web.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Display(Name = "Cliente")]
        public int ClientName { get; set; }
        [ForeignKey("ClientName")]
        public Client Client { get; set; }


        [Display(Name ="Producto")]
        public int ClotheId { get; set; }
        [ForeignKey("ProductId")]
        public Clothe Clothe { get; set; }
    }
}