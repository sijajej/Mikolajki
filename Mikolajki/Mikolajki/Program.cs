using System;
using System.Collections.Generic;


namespace Mikolajki
{
    class Program
    {

        static void Main(string[] args)
        {
            var random = new Random();
            var names = new List<string> { "Bulbi", "Wojtas", "Ania", "Olaf", "Buchcik", "Kasia", "Andrzej", "Wiki", "Aniela", "Dynowski" };
            var input = Console.ReadLine();
            var a = "";
            
            if (!String.IsNullOrWhiteSpace(input))
            {
                names.AddRange(input.Split(" "));
                
            }

            var iks = names.Count;
            for (var i = 0; i < iks  ; i++)
            {
                var ran = random.Next(names.Count);

                if (i == 0)
                {
                    a = names[ran];
                }

                Console.Write(names[ran] + " -> ");
                names.Remove(names[ran]);
            }
            Console.WriteLine(a);
        }
    }
    

}
