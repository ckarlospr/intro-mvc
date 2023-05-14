using System.ComponentModel.DataAnnotations;

namespace IntroASP.Models.ViewModels
{
    public class BeerViewModel
    {
        [Display(Name = "Beer name")]
        public string Name { get; set; }

        [Display(Name = "Brand name")]
        public string BrandId { get; set; }
    }
}
