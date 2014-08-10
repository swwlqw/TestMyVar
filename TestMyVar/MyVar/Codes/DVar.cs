using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SVar.Codes
{

    public abstract partial class DVar
    {
        public abstract DVar this[int index]
        {
            get;
            set;
        }
        public abstract DVar this[string key]
        {
            get;
            set;
        }

        public abstract int Size();

        public static implicit operator DVar(string str)
        {
            return new TypeVar<string>(str);
        }

        public static implicit operator DVar(int i)
        {
            return new TypeVar<int>(i);
        }

        public static implicit operator DVar(double i)
        {
            return new TypeVar<double>(i);
        }

        public static implicit operator int(DVar d)
        {
            return ((TypeVar<int>)d).getObj();
        }

        public static implicit operator string(DVar d)
        {
            return ((TypeVar<string>)d).getObj();
        }

        public static implicit operator double(DVar d)
        {
            return ((TypeVar<double>)d).getObj();
        }

        public static implicit operator DateTime(DVar d)
        {
            return ((TypeVar<DateTime>)d).getObj();
        }

        public static implicit operator DVar(DateTime dt)
        {
            return new TypeVar<DateTime>(dt);
        }
    }
}
