﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tiba.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
    }
}
