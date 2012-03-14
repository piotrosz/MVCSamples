using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTemplatedViewHelpers.Models
{
    public class PersonRepository
    {
        public static Person GetPerson()
        {
            return new Person()
            {
                BirthDate = new DateTime(1854, 12, 12),
                FirstName = "John",
                IsApproved = true,
                LastName = "Peel",
                PersonId = 1,
                Role = Role.User,
                HomeAddress = new Address()
                {
                    City = "London",
                    Country = "Great Britain",
                    Line1 = "ul. Radomska 123A",
                    Line2 = "Line 2",
                    PostalCode = "0970-342-23"
                }
            };
        }
    }
}