using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBase.Core.DataModel
{
    public class EntityModel
    {
        public string Name { get; set; }
        public List<PropertyModel> Properties { get; set; }
        public List<EntityModelLink> Entities { get; set; }

        public EntityModel(string name, Action<EntityModel> initEntityModel = null)
        {
            Name = name;
            Properties = new List<PropertyModel>();
            Entities = new List<EntityModelLink>();
            initEntityModel?.Invoke(this);
        }

        public EntityModel AddProperty(DataType type, string name, bool isIndexed=false)
        {
            Properties.Add(new PropertyModel(type, name, isIndexed));
            return this;
        }

        public EntityModel AddEntity(string linkName, string entityName, Action<EntityModel> initEntityModel = null)
        {
            Entities.Add(new EntityModelLink(linkName, new EntityModel(entityName, initEntityModel)));
            return this;
        }
    }
}
