using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyContainerPatternExample.PropertyContainer
{
    public interface IPropertyContainer
    {
        void AddPropertyBy(object value, string token);
        void RemoveProperty(string token);
        object GetPropertyBy(string token);
        List<string> GetPropertyKeys();
    }
}
