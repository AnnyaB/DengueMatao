using DengueMatao.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DengueMatao.Application.DTOs
{
    public class CasoDengueDTO
    {
        public int Id { get; set; }

        #region CEP
        [Required(ErrorMessage = "O CEP é obrigatorio")]
        [MinLength(8)]
        [MaxLength(8)]
        [DisplayName("CEP")]
        public string Cep { get; set; }
        #endregion

        #region NomeRua
        [Required(ErrorMessage = "O nome da rua é obrigatorio")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("NomeRua")]
        public string NomeRua { get; set; }
        #endregion

        #region Bairro
        [Required(ErrorMessage = "O Bairro é obrigatorio")]
        [MinLength(3)]
        [MaxLength(100)]
        [DisplayName("CEP")]
        public string Bairro { get; set; }
        #endregion

        #region NumeroCasa
        [Required(ErrorMessage = "O Numero da casa é obrigatorio")]
        [Range(1, 9999)]
        [DisplayName("NumeroCasa")]
        public int NumeroCasa { get; set; }
        #endregion

        #region DataRegistro
        [Required]
        [DisplayName("DataRegistro")]
        public DateTime DataRegistro { get; set; }
        #endregion

        #region TodosCasosDengue
        [DisplayName("TodosCasosDengue")]
        public CasoDengue TodosCasosDengue { get; set; }
        #endregion
    }
}
