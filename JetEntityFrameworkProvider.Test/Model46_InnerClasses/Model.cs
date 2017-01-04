﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JetEntityFrameworkProvider.Test.Model46_InnerClasses
{
    [Table("ClassA46")]
    public class ClassA
    {
        public ClassA()
        {
            B = new ClassB();
            C = new ClassC();
        }

        [Key]
        public int id { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public virtual ClassB B { get; set; }
        public virtual ClassC C { get; set; }

        [ComplexType]
        public class ClassB
        {
            public int? b { get; set; }
        }

        [ComplexType]
        public class ClassC
        {
            public int? c { get; set; }
        }
    }
}
