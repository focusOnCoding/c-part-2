using System;
using System.Collections.Generic;
using System.Text;

namespace fields
{
    public class Customer
    {
        public int ID;
        public string Name;
        // better way so every constructor has access to the list
        // this field should only be init ones so ill use {readonly}
        public readonly List<Orders> Oreders = new List<Orders>();

        // Default constructor for list {bad way}
       /* public Customer()
        {
            Order = new List<Orders>(); 
        }*/
        public Customer(int id)
        {
            this.ID = id;
        }
        public Customer(int id, string name)
            // deliga the code of the id to the to the constructor above
            : this(id)
        {
            this.Name = name;
        }

        //
        public void Promote()
        {
             
        }
    }

    public class Orders
    {

    }
}
