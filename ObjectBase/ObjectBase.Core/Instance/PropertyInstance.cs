using ObjectBase.Core.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBase.Core.Instance
{
    public class PropertyInstance<T>
    {
        public PropertyModel Model { get; set; }
        public IBehavior<T> ModelStream => _modelStream.ToBehavior<T>(default(T));
        private BehaviorSubject<T> _modelStream { get; } = new BehaviorSubject<T>(default(T));

        public PropertyInstance(PropertyModel model)
        {
            this.Model = model;
        }

        public PropertyInstance(PropertyModel model, T initialValue)
            : this(model)
        {
            SetValue(initialValue);
        }

        public void SetValue(T value)
        {
            _modelStream.OnNext(value);
        }

        public PropertyInstance<T> Clone()
        {
            return new PropertyInstance<T>(Model, _modelStream.Value);
        }
    }
}
