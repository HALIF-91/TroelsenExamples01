﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    abstract class Shape
    {
        public string PetName { get; set; }
        public Shape() { }
        public Shape(string name)
        {
            PetName = name;
        }
        public abstract void Draw();
    }
}
