using PropertyContainerPatternExample.PropertyContainer;
using System;

namespace PropertyContainerPatternExample.model
{
    public class Book : PropertyContainerImpl
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string ISBN { get; set; }
    }
}
