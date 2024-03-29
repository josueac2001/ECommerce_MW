﻿using System.ComponentModel.DataAnnotations;

namespace ECommerce_MW.DAL.Entities
{
    public class Country : Entity
    {
        #region Properties
        [Display(Name = "Pais")] 
        [MaxLength(50, ErrorMessage ="El campo {0} debe ser de {1} caracteres.")]
        [Required(ErrorMessage ="El campo {0} es obligatorio.")]
        public String Name { get; set; }
        #endregion

    }
}
