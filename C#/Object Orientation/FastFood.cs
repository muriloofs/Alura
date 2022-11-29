using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank
{
    public class FastFood
    {
        public class Request
        {
            public int number_Request;
            public Client client;
            public ItemRequest item;
            public float total_Request;
        }
        public class ItemRequest
        {
            public int quantity;
            public int number_Request;
            public Product productA;
            public Product productB;
            public Product productC;
        }
        public class Product
        {
            public int code_Product;
            public string Description;
            public double value_Single;
            public double quantity;
        }
        public class Client
        {
            public string name;
            public string cpf;
            public string email;
            public Address address;
        }
        public class Address
        {
            public string street;
            public string neighborhood;
            public string city;
            public string zip_Code;
            public int number;
        }
    }
}
