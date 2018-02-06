﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.CSharp.RentSystem.Models
{
    public abstract class Person : Base
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // dziedziczenie
    public class Woman : Person
    {
        public string EyesColor { get; set; }

        public void Makeup()
        {
        }
    }

    public class Man : Person
    {

    }
}
