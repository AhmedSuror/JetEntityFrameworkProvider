﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace JetEntityFrameworkProvider.Test.Model23_NestedInclude
{
    public class DocumentMetadataExpression
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Expression Expression { get; set; }
    }
}
