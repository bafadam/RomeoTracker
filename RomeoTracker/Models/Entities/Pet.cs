using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RomeoTracker.Models.Entities
{
    /// <summary>
    /// Public model class for pets.
    /// </summary>
    public class Pet : IEntity
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [UIHint("Date")]
        [DisplayName("Birth Date")]
        public DateTime? BirthDate { get; set; }

        [DisplayName("Pet Image")]
        public virtual PetImage PetPicture { get; set; }


        public Pet()
        {
        }



    }
}