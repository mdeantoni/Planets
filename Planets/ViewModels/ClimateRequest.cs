using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Planets.ViewModels
{
    public class ClimateRequest
    {
        [Required]
        [Range(1, 3650)]
        public int Dia { get; set; }
    }
}