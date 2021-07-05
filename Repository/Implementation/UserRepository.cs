using Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Implementation
{

    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<ApplicationUser> entities;

        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<ApplicationUser>();
        }

        public ApplicationUser Get(string id)
        {
            return entities
                .Include(z => z.UserCart)
                .Include("UserCart.TicketsInShoppingCart")
                .SingleOrDefault(s => s.Id == id);
        }

        public IEnumerable<ApplicationUser> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(ApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(ApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(ApplicationUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
