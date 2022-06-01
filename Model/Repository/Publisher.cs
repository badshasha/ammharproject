using simpleproject.app.Model.Repository.BaseClass;
using System.ComponentModel.DataAnnotations;


namespace simpleproject.app.Model.Repository
{
    public class Publisher : BaseInfoRepo
    {       
        [Required]
        [MinLength(2) , MaxLength(20)]
        [Display(Name="User name")]
        public string Name { get; set; }
    }
}
