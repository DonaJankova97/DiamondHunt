using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proekt
{
    class Users
    {
        LinkedList<String> igraci;
        public Users()
        {
            igraci = new LinkedList<String>();
        }
        public void addUser(String name)
        {
            if(!igraci.Contains(name))
                igraci.AddLast(name);
        }
        
        public String getIgrac(int i)
        {
            return igraci.ElementAt(i);
        }
        public int size()
        {
            return igraci.Count();
        }
    }
}
