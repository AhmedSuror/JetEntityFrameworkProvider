﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JetEntityFrameworkProvider.Test.Model21_CommandInterception
{
    [Table("Car21")]
    public class Car
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
