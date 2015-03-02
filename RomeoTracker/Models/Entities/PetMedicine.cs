using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RomeoTracker.Models.Entities
{
    public class PetMedicine : IEntity
    {
        public int Id { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? NextScheduled { get; set; }

        public virtual Pet Pet { get; set; }
        public virtual Medicine Medicine { get; set; }

    }
}