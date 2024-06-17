namespace labo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tekst = "DIT IS EEN ZIN MET 8 WOORDEN EN 2 CIJFERS";
            int[] getallen = new int[] { 1, 20, 5, 32, 2, 8, 77, 100 };
            Method m = new Method();
            Query q = new Query();

            //oef2
            Log(m.ZoekE(tekst));
            Log(q.ZoekE(tekst));
            Log(m.ZoekEZ(tekst));
            Log(q.ZoekEZ(tekst));
            Log(m.ZoekVoorE(tekst));
            Log(q.ZoekVoorE(tekst));
            Log(m.DeelbaarDoor5(getallen));
            Log(q.DeelbaarDoor5(getallen));
        }

        public static void Log(List<char> list)
        {
            foreach (var c in list) Console.WriteLine(c);
        }
        public static void Log(List<int> list)
        {
            foreach (var g in list) Console.WriteLine(g);
        }
    }
}