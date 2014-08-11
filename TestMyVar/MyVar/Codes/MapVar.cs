using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SVar.Codes
{
    [DataContract]
    public partial class MapVar : DVar
    {
        [DataMember]
        private Dictionary<string, DVar> dictionary = new Dictionary<string, DVar>();
        public override DVar this[string key]
        {
            get
            {
                return dictionary[key];
            }

            set
            {
                dictionary[key] = value;
            }
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
        public override string ToString()
        {
            return dictionary.ToString();
        }

        public override int Size()
        {
            return dictionary.Count();
        }
        public Dictionary<string,DVar> getDictionary()
        {
            return dictionary;
        }
    }
}
