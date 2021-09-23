using ObjectBase.Core.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBase.Core.Instance
{
    public class EntityInstance
    {
        public EntityModel Model { get; set; }

        public List<PropertyInstance<bool>> BoolProperties { get; set; }
        public List<PropertyInstance<string>> EnumProperties { get; set; }
        public List<PropertyInstance<string>> StringProperties { get; set; }
        public List<PropertyInstance<int>> IntProperties { get; set; }
        public List<PropertyInstance<float>> FloatProperties { get; set; }
        public List<PropertyInstance<double>> DoubleProperties { get; set; }
        public List<PropertyInstance<DateTime>> DateTimeProperties { get; set; }


        public List<EntityLinkInstance> Entities { get; set; }

        public EntityInstance(EntityModel model)
        {
            BoolProperties = new List<PropertyInstance<bool>>();
            EnumProperties = new List<PropertyInstance<string>>();
            StringProperties = new List<PropertyInstance<string>>();
            IntProperties = new List<PropertyInstance<int>>();
            FloatProperties = new List<PropertyInstance<float>>();
            DoubleProperties = new List<PropertyInstance<double>>();
            DateTimeProperties = new List<PropertyInstance<DateTime>>();

            foreach (var item in model.Properties)
            {
                switch (item.Type)
                {
                    case DataType.BooleanType:
                        BoolProperties.Add(new PropertyInstance<bool>(item));
                        break;
                    case DataType.EnumType:
                        EnumProperties.Add(new PropertyInstance<string>(item));
                        break;
                    case DataType.StringType:
                        StringProperties.Add(new PropertyInstance<string>(item));
                        break;
                    case DataType.IntType:
                        IntProperties.Add(new PropertyInstance<int>(item));
                        break;
                    case DataType.FloatType:
                        FloatProperties.Add(new PropertyInstance<float>(item));
                        break;
                    case DataType.DoubleType:
                        DoubleProperties.Add(new PropertyInstance<double>(item));
                        break;
                    case DataType.DateTimeType:
                        DateTimeProperties.Add(new PropertyInstance<DateTime>(item));
                        break;
                    default:
                        throw new Exception("Datatype not found.");
                }
            }

            foreach (var item in model.Entities)
            {
                Entities.Add(new EntityLinkInstance(item));
            }
        }

        public void SetValue<T>(string[] path, T Value)
        {

        }

    }
}
