﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JetEntityFrameworkProvider.Test.Model27_SimpleTest
{
    [Table("User27")]
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}