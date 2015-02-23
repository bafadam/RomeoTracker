using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using RomeoTracker.Models;
using RomeoTracker.Models.Entities;

namespace RomeoTracker.Services
{
    /// <summary>
    /// A public implementation of basic business logic for the Pet service.
    /// </summary>
    public class PetService
    {
        #region Properties 

        ApplicationDbContext context;

        #endregion

        #region Constructors

        public PetService(ApplicationDbContext _context)
        {
            this.context = _context;
        }

        #endregion

        #region CRUD Operations

        public void Create(Pet pet)
        {
            context.Pets.Add(pet);


        }



        #endregion



    }
}