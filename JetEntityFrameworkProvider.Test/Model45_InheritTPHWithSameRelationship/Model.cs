﻿using System;

namespace JetEntityFrameworkProvider.Test.Model45_InheritTPHWithSameRelationship
{
    public abstract class Base
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }

    public class Inherited1 : Base
    {
        public virtual Type1 Rel { get; set; }
    }

    public class Inherited2 : Base
    {
        public virtual Type1 Rel { get; set; }
    }

    public class Type1
    {
        public int Id { get; set; }
        public int Description { get; set; }
    }

}
