/*
Övning 2: Medelåldern i Göteborgs kommun är 39 år. Medellönen i Sverige är 36100 kr/månad.
Skapa ett program som frågar användaren efter hens ålder och månadslön. Programmet ska
sedan säga om användaren är lika gammal som, yngre eller äldre än medelpersonen i Göteborg.
Därefter ska programmet säga om användaren tjänar lika mycket som, mindre eller mer än
meddellönen i Sverige.
*/

namespace ifStatementsExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int avarageAge = 39;
                int avarageSalery = 36100;
                Console.WriteLine("How old are you:");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    Console.WriteLine("How much money do you make each month?");
                    if (int.TryParse(Console.ReadLine(), out int salary))
                    {
                        if (age > avarageAge && salary > avarageSalery)
                        {
                            Console.WriteLine("You are above the avarage age in Gothenburg and you make more money then the avarage salary in Sweden.");
                            break;
                        }
                        else if (age < avarageAge && salary < avarageSalery)
                        {
                            Console.WriteLine("You are younger then the avarage age in Gothenburg and you make less money they the avarage salary in Sweden.");
                            break;
                        }
                        else if (age == avarageAge && salary == avarageSalery)
                        {
                            Console.WriteLine("You are avarage!");
                            break;
                        }
                        else if (age > avarageAge && salary < avarageSalery)
                        {
                            Console.WriteLine("You are above avarage age in Gothenburg but you make less then the avarage salary in Sweden.");
                            break;
                        }
                        else if (age < avarageAge && salary > avarageSalery)
                        {
                            Console.WriteLine("You are younger then the avarage age in Gothenburg and make more money then the avarage salary in Sweden.");
                            break;
                        }
                        else { Console.WriteLine("Wrong input."); continue; }
                    }
                }
                else { Console.WriteLine("Wrong input."); continue; }
            }
        }
    }
}
