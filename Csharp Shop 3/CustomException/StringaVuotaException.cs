using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop_3.CustomException
    {
    internal class StringaVuotaException: Exception
        {
        public string message;

        internal StringaVuotaException(string message) : base(message)
            {
            this.message = message;
            }
        }               
    }
