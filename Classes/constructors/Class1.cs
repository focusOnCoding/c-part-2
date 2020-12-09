using System;
using System.Collections.Generic;
using System.Text;

namespace constructors
{
    public class Customer
    {
        public int Id;
        public string Name;
        // gineric type <order> is the type of the list
        public List<order> orders;

        public Customer()
        {
            // i should always init to a empty list  
            orders = new List<order>(); // if i dont do this i get a null error coz this is a referance type
        }

        // constructor overload
        public Customer(int id)
            : this() // this is how is aad my order list  
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id) // this means first call the constructor that has the id as a peremiter
        {
            this.Name = name;
        }
    }
}
