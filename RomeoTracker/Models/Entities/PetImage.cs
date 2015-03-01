using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RomeoTracker.Models.Entities
{
    /// <summary>
    /// Pet Images are database pictures of the pet.
    /// </summary>
    public class PetImage : IEntity
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Description")]
        public string Description { get; set; }

        [DisplayName("Content Type")]
        public string ImageMimeType { get; set; }

        [DisplayName("Content Length")]
        public int ContentLength { get; set; }

        public byte[] Picture { get; set; }

        public PetImage()
        {

        }
    }
}