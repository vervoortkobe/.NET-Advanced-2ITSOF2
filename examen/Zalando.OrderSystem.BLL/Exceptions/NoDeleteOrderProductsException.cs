using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zolando.OrderSystem.BLL.Exceptions
{
    public class NoDeleteOrderProductsException : Exception
    {
        public NoDeleteOrderProductsException() : base()
        {

        }
        public NoDeleteOrderProductsException(string message) : base(message)
        {

        }
    }
}