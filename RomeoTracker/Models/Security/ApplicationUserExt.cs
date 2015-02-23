using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace RomeoTracker.Models
{
    /// <summary>
    /// A class that holds additional information about users lke profile data.
    /// </summary>
    public class ApplicationUserExt
    {
        [Key]
        public int Id { get; set; }
        
        public virtual ApplicationUser User { get; set; }


    }
}