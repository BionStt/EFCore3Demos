﻿using System;
using System.Collections.Generic;

namespace query_tags.Model
{
    public class Illustration
    {
        public Illustration()
        {
            ProductModelIllustration = new HashSet<ProductModelIllustration>();
        }

        public int IllustrationID { get; set; }
        public string Diagram { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductModelIllustration> ProductModelIllustration { get; set; }
    }
}