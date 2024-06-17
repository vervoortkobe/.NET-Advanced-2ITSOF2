using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zolando.OrderSystem.BLL.Exceptions
{
    public class NoUpdateOrderDateException : Exception
    {
        public NoUpdateOrderDateException() : base()
        {

        }
        public NoUpdateOrderDateException(string message) : base(message)
        {

        }
    }
}
