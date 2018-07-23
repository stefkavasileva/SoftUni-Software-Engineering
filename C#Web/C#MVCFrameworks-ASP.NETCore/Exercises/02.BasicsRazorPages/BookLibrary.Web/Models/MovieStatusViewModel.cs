using System.Collections.Generic;

namespace BookLibrary.Web.Models
{
    public class MovieStatusViewModel
    {
        public string Title { get; set; }   

        public ICollection<StatusViewModel> Statuses { get; set; }    
    }
}
