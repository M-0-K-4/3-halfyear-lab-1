using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;
using JsonConstructorAttribute = Newtonsoft.Json.JsonConstructorAttribute;

namespace Task_2
{
    internal class Callers
    {
        public string name { get; set; }

        public string surname { get; set; }

        public string phoneNumber { get; set; }

        public string address { get; set; }

        public Callers(string name, string surname, string phoneNumber, string address)
        {
            this.name = name;
            this.surname = surname;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        public override string ToString()
        {
            return $"{name} {surname}, {phoneNumber} | {address}\n";
        }
    }
}
