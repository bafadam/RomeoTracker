using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace RomeoTracker.Models.Entities
{
    /// <summary>
    /// Base implementation for all entities in the system.  
    /// </summary>
    public abstract class IEntity
    {
        [UIHint("DateTime")]
        public DateTime CreateDate { get; set; }
        [UIHint("DateTime")]
        public DateTime ModifyDate { get; set; }

        public SystemUser CreateUser { get; set; }
        public SystemUser ModifyUser { get; set; }

        /// <summary>
        /// Provides an overridable instance to handle before insert operations.
        /// </summary>
        public virtual void OnBeforeInsert()
        {
            this.CreateDate = DateTime.Now;
        }

        public virtual void OnBeforeUpdate()
        {
            this.ModifyDate = DateTime.Now;
        }

        public virtual void OnBeforeDelete()
        {

        }


    }
}