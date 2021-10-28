using System;

namespace ApplicationC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ArrayList:La classe ArrayList est une collection 
            //qui peut être utilisée pour tout type ou objet. 
            //Arraylist est une classe similaire à un tableau,
            ///mais elle peut être utilisée pour stocker 
            ///des valeurs de différents types.
            //Un Arraylist n’a pas de taille spécifique.
            //N’importe quel nombre d’éléments peut être stocké.
            ArrayList numbers = new ArrayList();  
            numbers.Add(1);       //int
            numbers.Add(1.9803);  //float
            numbers.Add("one");   //string
            numbers.Add('o');     //char
                
            foreach (object nbr in numbers)  
            {  
            Console.Write("{0} ", nbr);
            }

        }
    }
}
