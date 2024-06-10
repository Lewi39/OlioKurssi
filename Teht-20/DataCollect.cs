using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht_20
{
    internal class DataCollect
    {
        public class Student
        {
            public string FirstName {  get; set; }
            public string LastName { get; set; }
            public int Id { get; set; }
            public string Email { get; set; }
            public int PhoneNumber { get; set; }

            public Student (string firstName, string lastName, int id, string email, int phoneNumber)
            {
                FirstName = firstName;
                LastName = lastName;
                Id = id;
                Email = email;
                PhoneNumber = phoneNumber;
            }
        }
    }
}
