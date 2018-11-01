using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class EntityManager<T>
        where T: IEntity
    {
        public void Save(T user)
        {

        }

        public T Load(string id)
        {
            return default(T);
        }
    }
}
