using System;
using System.Collections.Generic;
using System.Text;

namespace pratik1
{
    class Store
    {
        Phone[] phones = new Phone[0];
       public void AddPhone(Phone newphone)
        {
            Array.Resize(ref phones, phones.Length + 1);
            phones[phones.Length - 1] = newphone;
        }
        public void GetAllPhones ()
        {
            foreach (var item in phones)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Brand: {item.Brand}, Quantity: {item.Quantity}, Price: {item.Price}, System: {item.System}, Ram: {item.Ram}");
            }
        }
        public Phone [] GetPhonesBySystem (string system)
        {
            Phone[] phonesystem = new Phone[0];
            foreach (var item in phones)
            {
               if((item.System.ToLower())==system.ToLower())
                {
                    Array.Resize(ref phonesystem, phonesystem.Length + 1);
                    phonesystem[phonesystem.Length - 1] = item;
                }
            }
            return phonesystem;
        }
        public Phone[] GetPhonesByPrice (double minprice, double maxprice)
        {
            Phone[] phonebyprice = new Phone[0];
            foreach (var item in phones)
            {
                if (item.Price>minprice&& item.Price<maxprice)
                {
                    Array.Resize(ref phonebyprice, phonebyprice.Length + 1);
                    phonebyprice[phonebyprice.Length - 1] = item;
                }
            }
            return phonebyprice;
        }
    }
}
