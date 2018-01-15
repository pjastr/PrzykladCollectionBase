using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrzykladCollectionBase
{
    class WlasnaKolekcja:CollectionBase
    {
        protected override void OnInsert(int index, Object value)
        {
            Console.WriteLine("Dodano {1} na pozycji {0}", index, value);
        }

        public int Add(object value)
        {
            return (List.Add(value));
        }
    }
}
