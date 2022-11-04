﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoUML3.model
{
    public class Pizza:MenuItem
    {
        public Pizza()
        {
        }

        public Pizza(int number, string name, string description, double price, bool isVegan, bool deepPan) :
            base(number, name, description, price, MenuType.Pizza, isVegan)
        {
            DeepPan = deepPan;
        }

        public bool DeepPan { get; set; }

        public override string GetInfo()
        {
            return ToString();
        }
        public override string ToString()
        {
            return base.ToString() +  $" {nameof(DeepPan)}={DeepPan}";
        }
    }
}
