using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RomeoTracker.Models;
using RomeoTracker.Models.Entities;


namespace RomeoTracker.Models.Entities 
{
    public class Medicine : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SystemUser Onwer { get; set; }

        public virtual ICollection<PetMedicine> PetMedicines { get; set; }
    }
}