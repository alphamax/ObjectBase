using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBase.Core.DataModel
{
    public class EntityModelLink
    {
        public string LinkName { get; set; }
        public EntityModel Entities { get; set; }

        public EntityModelLink(string linkName, EntityModel entities)
        {
            LinkName = linkName;
            Entities = entities;
        }
    }
}
