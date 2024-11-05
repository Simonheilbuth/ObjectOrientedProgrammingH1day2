using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingH1day2.Exercises
{
    internal class AccountOwner : Person
    {
        public int CustomerId { get; set; }
        

     



        public AccountOwner(int customerId, string firstName, string lastName) : base(firstName, lastName)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;


           
        }

         
    }
}
