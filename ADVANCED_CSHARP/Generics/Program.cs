using System;
using System.Collections.Generic;

namespace Generics
{
    // before we had generics this is what would be done
    public class List
    {
        
        public void Add(int number)
        {
            throw new NotImplementedException();
        }

        // return number at iven index
        public int this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    // the problem with his was that for every type i would have to create a new list class
    public class BookList {} //for ooks list
    public class Book { }
    // one solution to fix this is to use a Lst of Object {anything}
    public class ObjectList
    {
        // use object as return type because object canbe any type 
        // so i wouldnt have top create a new class for every type i have as a list eg BookList
        public void Add(object value)
        {
            throw new NotImplementedException();
        }

        public object this[int index]
        {
            get { throw new NotImplementedException(); }
        }
        
    }

    // Better way of doing the above using GENERICS 
    //@ [t] = type
    public class GenericList<t>
    {
        public void Add(t value)
        {

        }

        public t this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    // generic dictionary
    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }

    // limit what types i have in my Generics Class
    public class Utilities<T> where T : new() // constrant like the below separad them by ,
        //where T : IComparable //so i dont have to write it agin inside the generic class
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // make T instationable (new T()) by creating a constructor to make that possible

        // generic one
        public T Max<T>(T a, T b) where T : IComparable
        {
            //wont work type not known
            //return a > b ? a : b;

            return a.CompareTo(b) > 0 ? a : b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            var list = new List { };
            list.Add(10);
            var bookList = new BookList { };
            var anyObject = new ObjectList();
            anyObject.Add("siya");

            // bast way that does not box the types {referance types}
            var numbers = new GenericList<int>();
            // now this will depend on the type i enter in the <t> which type it is
            numbers.Add(2020);

            // stor books
            var books = new GenericList<Book>();
            books.Add(new Book());
            Console.WriteLine("Hello World!");

            // use generic dictionary
            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());

            var numbersNull = new Nullable<int>(5);
            Console.WriteLine("Has Value" + numbersNull.HasValue);
            Console.WriteLine("Value + " + numbersNull.GetValueOrDefault());
        }
    }
}
