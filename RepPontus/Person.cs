using System;
using System.Collections.Generic;
using System.Text;

namespace RepPontus
{
    class Person
    {
        // private string name;

        //public string Name
        //{
        //    get { return name; }
        //    set
        //    {
        //        if (string.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentException("Invalid name");
        //        }
        //        name = value;
        //    }
        //}
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Person(string name, DateTime dateOfBirth)
        {
            // name =this.Name;  
           Name = name;
            //this.name = name; //Tilldela prop name to parameter name;  this.Name is the the instansens name., this can be taken away!
            DateOfBirth = dateOfBirth;
        }


    }
}
