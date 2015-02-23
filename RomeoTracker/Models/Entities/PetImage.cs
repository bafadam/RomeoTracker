using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RomeoTracker.Models.Entities
{
    /// <summary>
    /// Pet Images are database pictures of the pet.
    /// </summary>
    public class PetImage : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public byte[] Picture { get; set; }


    }
}