using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBase.Core.DataModel
{
    public class DatabaseModel
    {
        public string Name { get; set; }
        public List<EntityModel> Models { get; set; }

        public DatabaseModel(string name, Action<DatabaseModel> initDatabaseModel = null)
        {
            Name = name;
            Models = new List<EntityModel>();
            initDatabaseModel?.Invoke(this);
        }

        public DatabaseModel AddEntity(string name, Action<EntityModel> initEntityModel = null)
        {
            Models.Add(new EntityModel(name, initEntityModel));
            return this;
        }
    }
}
