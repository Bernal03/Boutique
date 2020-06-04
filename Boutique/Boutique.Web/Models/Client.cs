using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Boutique.Web.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        [Display(Name="Nombre")]
        [MaxLength(60)]
        public string Name { get; set; }
        [Display(Name = "Dirección")]
        [MaxLength(50)]
        public string Address { get; set; }
        [Display(Name = "Teléfono")]
        [MaxLength(15)]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "Correo electrónico")]
        [MaxLength(30)]
        public string Email { get; set; }
    }
}