using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace SVar.Codes
{

    public class OperationNotSupportException : ApplicationException
    {
        public OperationNotSupportException(string message) : base(message) {

        }
    }
}
