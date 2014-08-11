using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVar.Codes;
using System.ServiceModel;

namespace TestServer
{
    [ServiceContract]
    public interface ITest
    {
        [OperationContract]
        DVar GetAllCities();
    }
}
