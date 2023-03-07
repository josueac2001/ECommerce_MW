using System.ComponentModel.DataAnnotations;

namespace ECommerce_MW.DAL.Entities
{
    public class Entity
    {
        #region Properties}
        [Key] //PRIMARY KEY
        [Required] //NOT NULL
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion
    }
}
