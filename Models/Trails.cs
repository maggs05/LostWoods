using System.ComponentModel.DataAnnotations;

namespace LostWoods.Models{
    public class Trails{
        [Required (ErrorMessage="Must have a name")]
        [Display(Name="Name")]
        public string Name{get; set;}
        
    }
}