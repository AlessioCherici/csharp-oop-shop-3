using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop_3.CustomException
    {
    internal class ConversioneImpossibileException : Exception 
        {
        public string message;

        internal ConversioneImpossibileException(string message) : base(message)
            {
            this.message = message;
            }
        }
    }
