using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionDemo
{
    class CustomerInfo
    {
        public int ID { get; set; }
        public string ClassName { get; set; }
        public CustomerInfo(int id, string name)
        {
            this.ID = id;
            this.ClassName = name;
        }
        public CustomerInfo()
        {
            this.ID = -1;
            this.ClassName = string.Empty;
        }

        public void PrintId()
        {
            Console.WriteLine("Id is {0} :" + this.ID);
        }

        public void PrintName()
        {
            Console.WriteLine("Name is {0} " + this.ClassName);
        }
    }
}
