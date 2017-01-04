﻿using System;
using System.ComponentModel.DataAnnotations;

namespace JetEntityFrameworkProvider.Test.Model50_Interception
{
    public class Note
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public string NoteText { get; set; }
    }
}
