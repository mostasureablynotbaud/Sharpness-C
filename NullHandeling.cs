using System;

namespace NullHandeling
{   
    class Address
    {
        public string? Building;
        public string Street;
        public string City; 
        public string Region;
    }   
    class Program
    {
        static void Main(string[] args)
        {
            int thisCannotBeNull = 4;
            //thisCannotBeNull = null; // compile error!

            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull);

            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull); 
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "London";
            address.Region = null;
        }
    }
}
