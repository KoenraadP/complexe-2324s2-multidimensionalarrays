using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // enkelvoudige array met cijfers, onmiddellijk geïnitialiseerd met waarden
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // enkelvoudige array met cijfers, al geïnitialiseerd maar zonder waarden
            int[] numbers2 = new int[6];
            // enkelvoudige array met cijfers, enkel gedeclareerd
            int[] numbers3;
            // laatste array ook initialiseren
            numbers3 = new int[5];

            // item plaatsen op de derde plek in de derde array
            numbers3[2] = int.MaxValue;
            Console.WriteLine(numbers3.Length);

            // item plaatsen op de zesde plaats in de derde array
            // numbers3[5] = int.MinValue;
            // kan niet! de array heeft vijf plaatsen en niet zes

            // multi dimensional arary maken met 4 rijen / 3 kolommen
            // int[,] numberMatrix = new int[4,3]; 

            int[,] numberMatrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
                { 10, 11, 12}
            };

            // toon in de console het eerste element 
            // uit de numberMatrix array
            Console.WriteLine(numberMatrix[0, 0]);
            // toon het laatste element
            Console.WriteLine(numberMatrix[3,2]);

            // toon het aantal rijen van de array
            Console.WriteLine(numberMatrix.GetLength(0)); // 4
            // toon het aantal kolommen van de array
            Console.WriteLine(numberMatrix.GetLength(1)); // 3

            // sla het index cijfer van de laatste rij op 
            // in een variabele
            int lastRow = numberMatrix.GetLength(0) - 1;
            int lastCol = numberMatrix.GetLength(1) - 1;
            // toon het laatste element
            Console.WriteLine(numberMatrix[lastRow, lastCol]);

            // toon alle elementen met foreach
            foreach (int i in numberMatrix) 
            {
                Console.WriteLine(i);
            }

            // toon alle elementen met een dubbele loop
        }
    }
}
