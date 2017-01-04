﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JetEntityFrameworkProvider.Test.Model23_NestedInclude
{
    public class VariableMetadata
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string DefaultValue { get; set; }
    }
}
