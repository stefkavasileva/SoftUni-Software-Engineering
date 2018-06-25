using System.ComponentModel.DataAnnotations;

namespace FDMC.App.Models.BindingModels
{
    public class KittenAddBidingModel
    {
        [Required]
        public string Name { get; set; }

        public int Age { get; set; }

        [Required]
        public string Bread { get; set; }
    }
}
