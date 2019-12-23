using System;
using System.Collections.Generic;
using System.Linq;

namespace PropertyContainerPatternExample.PropertyContainer
{
    public abstract class PropertyContainerImpl : IPropertyContainer
    {
        private readonly Dictionary<string, object> _properties = new Dictionary<string, object>();

        protected PropertyContainerImpl(){}

        public void AddPropertyBy(object value, string token)
        {
            if (value == null || token == null) return;
            if (_properties.ContainsKey(token))
            {
                _properties.Remove(token);
            }
            _properties.Add(token, value);
        }
        public void RemoveProperty(string token)
        {
            if (token == null) return;
            _properties.Remove(token);
        }

        public object GetPropertyBy(string token)
        {
            if (token == null) return null;

            _properties.TryGetValue(token, out var value);
            return value;
        }
    
        public List<string> GetPropertyKeys()
        {
            var keys = new List<string>();
            lock(_properties)
            {
                foreach(var key in _properties.Keys)
                {
                    keys.Add(key);
                }
                return keys;
            }
        }
    }
}
