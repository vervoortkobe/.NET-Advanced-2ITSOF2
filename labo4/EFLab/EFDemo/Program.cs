using Microsoft.EntityFrameworkCore;

namespace EFDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World of cars!");
            
            //Vergeet niet om de migrations eerst uit te laten voeren !
            
            var ctxt = new LabContext();

            var query = ctxt.Cars//.Include(c => c.Manufacturer)
                .OrderBy(c => c.Manufacturer.Name).ThenBy(c => c.Year).ThenBy(c => c.Model)
                .Select(c => c)
                .Skip(20).Take(10);

            //ctxt.Cars.GroupBy(c => c.Model).Select(c => new { c.Key, Count = c.Count() });


            foreach (var c in query)
            {
                Console.WriteLine($"Year:{c.Year}\tManId:{c.Manufacturer.Name}\tModel:{c.Model}");
                //Console.WriteLine($"\tManufacturer: {c.Manufacturer.Name}");
            }
        }
    }
}