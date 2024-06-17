using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo5
{
    public class Query
    {
        public List<char> ZoekE(string tekst) //oef2
        {
            var query = from c in tekst
                        where c == 'E'
                        select c;
            return query.ToList();
        }
        public List<char> ZoekEZ(string tekst) //oef2
        {
            var query = from c in tekst
                        where c == 'E' || c == 'Z'
                        select c;
            return query.ToList();
        }
        public List<char> ZoekVoorE(string tekst) //oef2
        {
            var query = from c in tekst
                        where c < 'E' && c != ' '
                        select c;
            return query.ToList();
        }
        public List<int> DeelbaarDoor5(int[] getallen) //oef2
        {
            var query = from g in getallen
                        where g % 5 == 0
                        select g;
            return query.ToList();
        }
    }
}
