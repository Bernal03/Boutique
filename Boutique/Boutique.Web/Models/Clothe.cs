using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Boutique.Web.Models
{
    public class Clothe
    {
        public int Id { get; set; }
        [Display(Name = "Prenda")]
        public string Name { get; set; }
        [Display(Name = "Descripción")]
        public string Description { get; set; }

    }
}