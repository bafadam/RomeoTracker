using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RomeoTracker.Models.Entities
{
    /// <summary>
    /// Public model class for pets.
    /// </summary>
    public class Pet : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [UIHint("Date")]
        public DateTime? BirthDate { get; set; }

        
        public virtual PetImage PetPicture { get; set; }




    }
}