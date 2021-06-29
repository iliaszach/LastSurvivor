using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastSurvivor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LastSurvivor("c", new int[] {0}));
        }
        public static string LastSurvivor(string letters, int[] coords)
        {
            List<char> asso = new List<char>();
            
            var a = "";
            for (int i = 0; i < letters.Length; i++)
            {
                asso.Add(letters[i]);
            }            
            if (!(coords.Length==0 || coords.Length==1 && coords[0]==0))
            {
                for (int i = 0; i < coords.Length; i++)
                {
                    asso.RemoveAt(coords[i]);                    
                }
                for (int i = 0; i < asso.Count; i++)
                {
                    a += asso[i];
                }
                return a;
            }
            else
            {
                return letters;
            }                         
            
        }
    }
}
