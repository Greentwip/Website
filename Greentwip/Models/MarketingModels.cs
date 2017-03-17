using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Greentwip.Models
{
    public class ShortUrlContainer
    {
        // entity detects ShortUrlContainer as key or any other if it contains the 
        // class name, and ID on this case
        public int ShortUrlContainerID { get; set; }

        [Required]
        [Display(Name = "Title")]
        [DataType(DataType.Text)]
        [MaxLength(70)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Image Link")]
        [DataType(DataType.Url)]
        public string Image { get; set; }

        [Required]
        [Display(Name = "Real Url")]
        [DataType(DataType.Url)]
        public string RealUrl { get; set; }

        [Required]
        [Display(Name = "Shortened Url")]
        [DataType(DataType.Url)]
        public string ShortenedUrl { get; set; }

        [Required]
        [Display(Name = "Creation Date")]
        [DataType(DataType.DateTime)]
        public DateTime CreateDate { get; set; }

        [Required]
        [Display(Name = "Created By")]
        public string CreatedBy { get; set; }

        public ShortUrlContainer()
        {
            this.Title = "Unkown";
            this.Description = "Unkown";
            this.Title = "";

            this.RealUrl = null;
            this.ShortenedUrl = "Unknown";
            this.CreateDate = DateTime.Now;
            this.CreatedBy = "Unknown";

        }


    }
    public class UrlsDBContext : DbContext
    {
        public UrlsDBContext()
            : base("UrlsConnection")
        {
        }
        public DbSet<ShortUrlContainer> Urls { get; set; }
    }
}
