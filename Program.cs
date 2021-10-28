using System;
using System.Collections;
using System.Collections.Generic;

namespace ApplicationC_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. LES COLLECTIONS NON GENERIQUES");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
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
             Stack lang = new Stack();  

            lang.Push("Java");  
            lang.Push("C#");  
            lang.Push("Python");  
            lang.Push("C++");  

            foreach (object o in lang)  
            {
            Console.WriteLine(o);
            }
            //POUR QUEUE
            //Il représente une collection d’objets 
            //FIFO(First In First Out). Lorsque 
            //vous ajoutez un élément à la liste,
            // cela s’appelle « Enqueue » ou « Enfiler » 
            //et lorsque vous supprimez un élément, 
            //cela s’appelle « Deque » ou « Défiler ».
            Console.WriteLine("\n");
             Console.WriteLine("POUR LE QUEUE");
             Console.WriteLine("-------------");
             Queue langQueue = new Queue(); 

            langQueue.Enqueue("Java");  
            langQueue.Enqueue("C#");  
            langQueue.Enqueue("Python");  
            langQueue.Enqueue("C++");  

            foreach (object o in langQueue)  
            {
            Console.WriteLine(o);
            }
            Console.WriteLine("2. LES COLLECTIONS GENERIQUES");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
             Console.WriteLine("\n");
             //POUR LE LIST
             //Il s’agit d’un tableau dynamique 
             //offrant des fonctionnalités similaires 
             //à celles de la classe non générique ArrayList.
             Console.WriteLine("POUR LE LIST");
             Console.WriteLine("-------------");

             List<int> num = new List<int>();
            num.Add(10);  
            num.Add(20);  
            num.Add(30);  
            num.Add(40);  
            foreach (int nombr in num)  
            {
            Console.WriteLine(nombr); 
            }
            //POUR DICTIONARY
            //Il stocke les données sous forme de paires 
            //clé-valeur et fournit des fonctionnalités
            // similaires à celles de la classe non générique Hashtable
            Console.WriteLine("POUR LE DICTIONARY");
            Console.WriteLine("-------------");
            Dictionary<int, string> langDict = new Dictionary<int, string>(); 
                
            langDict.Add(1, "Java");  
            langDict.Add(2, "C#");  
            langDict.Add(3, "Python");  
            langDict.Add(4, "C++");  

            foreach (KeyValuePair<int, string> langua in langDict)  
            {  
            Console.WriteLine("Clé: {0}, Valeur: {1}", langua.Key, langua.Value);  
            }
        }
    }
}
