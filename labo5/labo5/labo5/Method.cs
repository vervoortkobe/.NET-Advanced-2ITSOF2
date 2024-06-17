using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo5
{
    public class Method
    {
        public List<char> ZoekE(string tekst) //oef2
        {
            return tekst.Where(c => c == 'E').ToList();
        }
        public List<char> ZoekEZ(string tekst) //oef2
        {
            return tekst.Where(c => c == 'E' || c == 'Z').ToList();
        }
        public List<char> ZoekVoorE(string tekst) //oef2
        {
            return tekst.Where(c => c < 'E' && c != ' ').ToList();
        }
        public List<int> DeelbaarDoor5(int[] getallen) //oef2
        {
            return getallen.Where(g => g % 5 == 0).ToList();
        }
    }
}
