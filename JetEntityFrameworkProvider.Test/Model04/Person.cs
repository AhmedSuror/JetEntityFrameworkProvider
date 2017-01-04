﻿using System;

namespace JetEntityFrameworkProvider.Test.Model04
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Car OwnedCar { get; set; }
    }
}
