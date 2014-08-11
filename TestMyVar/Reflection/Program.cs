using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVar.Codes;
using System.Reflection.Context;
using System.Reflection;
namespace Reflection
{
    class Program
    {

        public static T ConvertDVarToType<T>(DVar d)
        {
            TypeVar<T> tv = (TypeVar<T>)d;
            return tv.getObj();
        }

        public static object ConvertDVarToObject(DVar d, Type type)
        {
            if (d is ArrayVar)
            {
                object re = Activator.CreateInstance(type);
                for (int i = 0; i < d.Size(); i++)
                {
                    object obj = ConvertDVarToObject(d[i], type.GenericTypeArguments[0]);
                    MethodInfo method = type.GetMethod("Add");
                    method.Invoke(re, new object[] { obj });
                }
                return re;
            }
            else if (d is MapVar)
            {
                object re = Activator.CreateInstance(type);
                MapVar mv = (MapVar)d;
                foreach (string key in mv.getDictionary().Keys)
                {
                    MethodInfo method = type.GetMethod("set_" + key);
                    Type tp = method.GetParameters()[0].GetType();
                    object obj = ConvertDVarToObject(d[key], tp);
                    method.Invoke(re, new object[] { obj});
                }
                return re;
            }

            else if (d is TypeVar<int>)
            {
                return ConvertDVarToType<int>(d);
            }
            else if (d is TypeVar<string>)
            {
                return ConvertDVarToType<string>(d);
            }
            else {
                return null;
            }
        }



        static void Main(string[] args)
        {
            DVar d = new ArrayVar();
            for (int i = 0; i < 3; i++)
            {
                d[i] = new MapVar();
                d[i]["id"] = i;
                d[i]["name"] = i+"name";
                d[i]["age"] = 10+i;
            }
            object obj = ConvertDVarToObject(d, typeof(List<City>));
            List<City> list =(List<City>) obj;
            Console.ReadKey();
        }
    }

    class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get;set; }

    }
}
