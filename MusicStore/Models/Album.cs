using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Album
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Album Cover")]
        public string AlbumArtUrl { get; set; }

        //[DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{ 0:c }")]
        [Required]
        public double AlbumPrice { get; set; }
    }
}