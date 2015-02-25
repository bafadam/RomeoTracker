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
            pet.OnBeforeInsert();
            context.Pets.Add(pet);
            context.SaveChanges();
        }

        public void Update(Pet pet)
        {
            pet.OnBeforeUpdate();
            context.SaveChanges();
        }

        public void Delete(Pet pet)
        {
            pet.OnBeforeDelete();
            context.Pets.Remove(pet);
        }

        /// <summary>
        /// A public impelementation that follows the security model to retrieve an IEnumerable list of pets.
        /// </summary>
        public IEnumerable<Pet> Retrieve()
        {
            return context.Pets;
        }

        #endregion



    }
}