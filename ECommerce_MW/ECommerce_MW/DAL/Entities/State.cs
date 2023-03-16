using System.ComponentModel.DataAnnotations;

namespace ECommerce_MW.DAL.Entities
{
    public class State : Entity
    {
        #region Properties
        [Display(Name = "Estado")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe ser de {1} caracteres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        public String Name { get; set; }
        public Country Country { get; set; }
        public ICollection<City> Cities { get; set;}
        public int CitiesNumber => Cities == null ? 0 : Cities.Count; //IF TERNEARIO
        #endregion

    }
}
