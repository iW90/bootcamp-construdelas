using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DapperAPI.DTO
{
    /// <summary>
    /// 
    /// </summary>
    public class AdressDTO
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo City é obrigatório.")]
        public int CityId { get; set; }
        
        [Required]
        [StringLength(100, MinimumLength = 4)]
        [Display(Name = "Rua do estabelecimento")]
        public string Street { get; set; }

        [Display(Name = "Número")]
        [Range(1, 99999)]
        public int Number { get; set; }

        [DefaultValue(true)]
        public bool Active { get; set; }
    }
}
