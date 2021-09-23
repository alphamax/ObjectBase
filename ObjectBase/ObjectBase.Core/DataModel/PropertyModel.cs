﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBase.Core.DataModel
{
    public class PropertyModel
    {
        public DataType Type { get; set; }
        public string Name { get; set; }
        public bool IsIndexed { get; set; }

        public PropertyModel(DataType type, string name, bool isIndexed=false)
        {
            Type = type;
            Name = name;
            IsIndexed = isIndexed;
        }
    }
}