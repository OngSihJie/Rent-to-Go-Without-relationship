using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rent_to_Go_Without_relationship.Models;

namespace Rent_to_Go_Without_relationship.Data
{
    public class Rent_to_Go_Without_relationshipContext : DbContext
    {
        public Rent_to_Go_Without_relationshipContext (DbContextOptions<Rent_to_Go_Without_relationshipContext> options)
            : base(options)
        {
        }

        public DbSet<Rent_to_Go_Without_relationship.Models.Agent> Agent { get; set; }

        public DbSet<Rent_to_Go_Without_relationship.Models.Customer> Customer { get; set; }

        public DbSet<Rent_to_Go_Without_relationship.Models.Property> Property { get; set; }
    }
}
