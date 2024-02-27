using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class AddServiceDto
    {
        [Required(ErrorMessage ="Hizmet ikon linki giriniz")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet başlığı giriniz")]
        [StringLength(25,ErrorMessage ="Hizmet başılığı en fazla 25 karakter olabilir.")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
