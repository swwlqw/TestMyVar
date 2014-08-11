using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVar.Codes;

namespace TestServer
{
    public class Tttt:ITest
    {
        public DVar GetAllCities()
        {
            DVar re = new ArrayVar();
            for (int i = 0; i < 10; i++) {
                re[i] = new MapVar();
                re[i]["id"] = i;
                re[i]["name"] = "city" + i;
            }
            return re;
        }
    }
}
