﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JetEntityFrameworkProvider.Test.Model03
{
    [Table("Texture")]
    public class Texture
    {
        [Column("ID")]
        public int Id { get; set; }

        [Column("DisplayText")]
        public string DisplayText { get; set; }

        [Column("IsDeleted")]
        public bool IsDeleted { get; set; }

        public virtual ICollection<PanelTexture> PanelTextures { get; set; }
    }
}
