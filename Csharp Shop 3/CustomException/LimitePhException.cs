using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop_3.CustomException
    {
    internal class LimitiPhException : Exception
        {
        public string message;
        internal LimitiPhException(string message) : base(message)
            {
            this.message = message;
            }
        }             
    }
