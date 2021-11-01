using System;

namespace pratik1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Product product1 = new Product(1,"iphone", "Apple", 20, 2000);
            //Console.WriteLine(product1);
            Phone product2 = new Phone(2, "A50", "samsung", 25, 400, "Android", 4);
            Phone product3 = new Phone(2, "A70", "samsung", 25, 300, "Android", 4);
            Phone product4 = new Phone(2, "Note 8", "Redmi", 25, 500, "Android", 4);
            Phone product5 = new Phone(2, "Ihone X", "Apple", 25, 2000, "ios", 4);
            Phone product6 = new Phone(2, "Iphone 11", "Apple", 25, 3000, "ios", 4);
            //Console.WriteLine(product2);
            Store store = new Store();
            store.AddPhone(product2);
            store.AddPhone(product3);
            store.AddPhone(product4);
            store.AddPhone(product5);
            store.AddPhone(product6);
            // store.GetAllPhones();
            Phone[] filteredphones = store.GetPhonesBySystem("Android");
            
                foreach (var item in filteredphones)
                {
                   Console.WriteLine(item);
                }
          Phone[] stores = store.GetPhonesByPrice(300, 3000);
            foreach (var item1 in stores)
            {
                Console.WriteLine(item1);
            }
        }
    }
}
