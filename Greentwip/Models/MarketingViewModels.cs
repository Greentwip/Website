using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Greentwip.Models
{
    public class UrlGeneratorViewModel
    {
        [Required(ErrorMessage = "Title is required")]
        [Display(Name = "Title")]
        [DataType(DataType.Text)]
        [MaxLength(70, ErrorMessage = "Max length is 70")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        [MaxLength(200, ErrorMessage = "Max length is 200")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Link")]
        [DataType(DataType.Url)]
        public string Link { get; set; }

        [Required]
        [Display(Name = "Image Link")]
        [DataType(DataType.Url)]
        public string Image { get; set; }
    }
    public class GeneratedUrlViewModel
    {

        [Required]
        [Display(Name = "Link")]
        [DataType(DataType.Url)]
        public string Link { get; set; }
    }
}
