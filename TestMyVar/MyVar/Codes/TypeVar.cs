using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SVar.Codes
{

    public partial class TypeVar<T> : DVar
    {

        private T obj;
        public TypeVar(T obj) {
            this.obj = obj;
        }

        public override DVar this[int index]
        {
            get
            {
                throw new OperationNotSupportException(this.GetType().FullName);
            }

            set
            {
                throw new OperationNotSupportException(this.GetType().FullName);
            }
        }
        public override DVar this[string key]
        {
            get
            {
                throw new OperationNotSupportException(this.GetType().FullName);
            }

            set
            {
                throw new OperationNotSupportException(this.GetType().FullName);
            }
        }
        public override string ToString()
        {
            return obj.ToString();
        }

        public override int Size()
        {
            throw new NotImplementedException();
        }

        public T getObj()
        {
            return obj;
        }
    }
}
