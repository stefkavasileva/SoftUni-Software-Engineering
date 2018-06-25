using System;

namespace SimpleMvc.Framework.Attributes.Property
{
    public abstract class PropertyAttribute : Attribute
    {
        public abstract bool IsValid(object value);
    }
}
