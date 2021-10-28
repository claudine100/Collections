using System;
using System.Collections;

namespace ApplicationC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //POUR ARRAYLIST

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
                Console.WriteLine("POUR ARRAYLIST");
             Console.WriteLine("-----------------");
            foreach (object nbr in numbers)  //ou  foreach (var nbr in numbers)  
            {  
            Console.Write("{0} ", nbr);
            }
             Console.WriteLine("\n");
             Console.WriteLine("POUR LE HASHTABLE");
             Console.WriteLine("-----------------");
             
            //POUR   HASHTABLE 
            //HashTable est similaire à arraylist,
            // mais représente les éléments sous forme de clé et valeur.
            Hashtable languages = new Hashtable();  
            languages.Add(1, "Java");  
            languages.Add(2, "C#");  
            languages.Add(3, "Python");  
            languages.Add(4, "C++");  
            
            foreach (DictionaryEntry language in languages)  
            {  
            Console.WriteLine("Clé: {0}, Valeur: {1}", language.Key, language.Value);   
            }
            //POUR STACK
            //Il représente une collection d’objets 
            //LIFO(Last In First Out). Lorsque vous 
            //ajoutez un élément dans la liste, cela 
            //s’appelle PUSH ou Empiler et lorsque vous
            // le supprimez, cela s’appelle POP ou Dépiler.
            Console.WriteLine("\n");
             Console.WriteLine("POUR LE STACK");
             Console.WriteLine("-------------");
             Stack languages = new Stack();  

            languages.Push("Java");  
            languages.Push("C#");  
            languages.Push("Python");  
            languages.Push("C++");  

            foreach (object o in languages)  
            {
            Console.WriteLine(o);
            }

        }
    }
}
