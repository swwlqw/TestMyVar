using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace SVar.Codes
{
    [DataContract]
    public partial class ArrayVar :DVar
    {
        [DataMember]
        private List<DVar> list = new List<DVar>();

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

        public override DVar this[int index]
        {
            get
            {
                return list[index];
            }
            set
            {
                if (index == list.Count())
                {
                    list.Add(value);
                }
                else
                {
                    list[index] = value;
                }
            }
        }

        public override string ToString()
        {
            return list.ToString();
        }

        public override int Size()
        {
            return list.Count();
        }
    }
}
