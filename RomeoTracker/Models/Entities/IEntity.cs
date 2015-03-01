using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace RomeoTracker.Models.Entities
{
    /// <summary>
    /// Base implementation for all entities in the system.  
    /// </summary>
    public abstract class IEntity
    {
        [UIHint("DateTime")]
        [DisplayName("Create Date")]
        public DateTime? CreateDate { get; set; }
        [UIHint("DateTime")]
        [DisplayName("Modify Date")]
        public DateTime? ModifyDate { get; set; }

        public SystemUser CreateUser { get; set; }
        public SystemUser ModifyUser { get; set; }

        /// <summary>
        /// Provides an overridable instance to handle before insert operations.
        /// </summary>
        public virtual void OnBeforeInsert()
        {
            this.CreateDate = DateTime.Now;
            this.ModifyDate = DateTime.Now;
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