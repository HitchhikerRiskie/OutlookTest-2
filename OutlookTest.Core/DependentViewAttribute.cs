using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookTest.Core
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class DependentViewAttribute : Attribute
    {
        public string Region { get; set; }
        public Type Type { get; set; }

        public DependentViewAttribute(String region, Type type)
        {
            if (region is null)
                throw new ArgumentNullException(nameof(region));
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            Type = type;
            Region = region;
        }
    }
}
