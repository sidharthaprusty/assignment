using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Models
{
    public static class DBInitializer
    {
        public static void SeedDb(CustomerContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Customers.Any())
            {
                context.Customers.Add(
                    new Customer()
                    {
                        Name = "Sidhartha Sankar Prusty",
                        Email = "siddharth.prusty@gmail.com",
                        Gender = 'M',
                        DateRegistered = new DateTime(2019, 6, 1),
                        EventDays = "Day1,Day2,Day3",
                        AdditionalReq = "Front Row Seats"
                    }
                );
                context.Customers.Add(
                    new Customer()
                    {
                        Name = "Sathish S",
                        Email = "sathish.s@gmail.com",
                        Gender = 'M',
                        DateRegistered = new DateTime(2019, 6, 1),
                        EventDays = "Day1",
                        AdditionalReq = "Drinking Water"
                    }
                );
                context.SaveChangesAsync();
            }
            
        }
    }
}

                    