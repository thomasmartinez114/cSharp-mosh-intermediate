﻿using System;

namespace AccessModifiers
{
    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            Console.WriteLine("Promote logic change");
        }

}
