﻿using bigOn.WebUI.AppCode.Infrastructure;
using System;
using System.Collections.Generic;

namespace bigOn.WebUI.Models.Entities
{
    public class Category : BaseEntity
    {
        public int? ParentId { get; set; }
        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> Children { get; set; }
        public string Name { get; set; }
       


    }
}
