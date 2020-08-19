using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public static class GlobalConfigurations
    {
        /// <summary>
        /// Creates an instance of the Interface
        /// </summary>

        public static IOperations Iinstance { get; private set; }

        /// <summary>
        /// Add an instance of 
        /// </summary>
        public static void AddIinstance()
        {
            Operations now = new Operations();
            Iinstance = now;
        }
        /// <summary>
        /// 
        /// </summary>
        public static void RemoveIinstance()
        {
            Iinstance = null;
        }

    }
}
