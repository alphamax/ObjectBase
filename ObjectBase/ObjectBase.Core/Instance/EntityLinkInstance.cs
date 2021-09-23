using ObjectBase.Core.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBase.Core.Instance
{
    public class EntityLinkInstance
    {
        public EntityModelLink Model { get; set; }

        public EntityLinkInstance(EntityModelLink model)
        {
            Model = model;
        }
    }
}
