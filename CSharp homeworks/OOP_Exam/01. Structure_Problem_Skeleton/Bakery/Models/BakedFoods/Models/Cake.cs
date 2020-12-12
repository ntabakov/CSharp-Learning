﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.BakedFoods.Models
{
    public class Cake : Food
    {
        private const int InitialCakePortion = 245;

        public Cake(string name, decimal price)
            : base(name, InitialCakePortion, price)
        {
        }
    }
}
