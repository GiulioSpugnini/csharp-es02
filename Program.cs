using System;           //riferimento alla libreria di base
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)  //entry point
        {
            /*
            for (char paperino='a'; paperino < 'z'; paperino++)
                Console.WriteLine(paperino);
            var a = "aaaa"; //Utilizzo var <nome> per dichiarare una variabile assegnandogli
            il tipo dell'oggetto che gli sto assegnando come valore
            int n = 0;
            for (int i = 0; i < 512; i++)
            {
                if (n == 16)
                {
                    Console.WriteLine();
                    n = 0;
                }
                n++;
                //Console.Write("{0} ", Convert.ToChar(i));
                Console.Write("{0} ", (char)i);  //casting
            }
            for (char paperino = 'a'; paperino < 'z'; paperino++)
                Console.WriteLine((long)paperino);
            */


            /*  foreach (string s in "alfa beta gamma delta".Split(' '))
              {
                  Console.WriteLine("<{0}>", s);
              }
              foreach (string s in "alfa ; ;  beta gamma delta".Split(new char[] { ' ', ';' })) //creo un vettore e gli assegno dei valori
                  Console.WriteLine("<{0}>", s);
            */
            string[] comandi = new string[] { "somma", "prodotto", "divisione", "sottrazione", "quadrato", "media", "min", "max" };
            Console.Write("Comando [0-add, 1-mul, 2-div, 3-sub, 4-square, 5-avg, 6-min, 7-max]:");
            string cmd = Console.ReadLine();
            int num1;
            int num2;
            int[] array;
            try
            {


                switch (cmd)
                {
                    case "0":
                        Console.WriteLine("operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);
                        Console.Write("Inserisci due numeri; uno per riga");
                        num1 = int.Parse(Console.ReadLine());
                        num2 = int.Parse(Console.ReadLine());
                        Console.Write("La somma dei due numeri è: {0}", num1 + num2);
                        break;
                    case "1":
                        Console.WriteLine("operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);
                        Console.Write("Inserisci due numeri; uno per riga");
                        num1 = int.Parse(Console.ReadLine());
                        num2 = int.Parse(Console.ReadLine());
                        Console.Write("La moltiplicazione dei due numeri è: {0}", num1 * num2);
                        break;
                    case "2":
                        Console.WriteLine("operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);
                        Console.Write("Inserisci due numeri; uno per riga");
                        num1 = int.Parse(Console.ReadLine());
                        num2 = int.Parse(Console.ReadLine());
                        Console.Write("La divisione dei due numeri è: {0}", num1 / num2);
                        break;
                    case "3":
                        Console.WriteLine("operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);
                        Console.Write("Inserisci due numeri; uno per riga");
                        num1 = int.Parse(Console.ReadLine());
                        num2 = int.Parse(Console.ReadLine());
                        Console.Write("La sottrazione dei due numeri è: {0}", num1 - num2);
                        break;
                    case "4":
                        Console.WriteLine("operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);
                        Console.Write("Inserisci due numeri; uno per riga");
                        num1 = int.Parse(Console.ReadLine());
                        Console.Write("Il quadrato del numero è: {0}", num1 ^ 2);
                        break;
                    case "5":
                        Console.WriteLine("operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);
                        Console.Write("Inserisci 10 numeri; uno per riga");
                        int tot = 0;
                        for (int i = 0; i < 10; i++)
                        {
                            tot += int.Parse(Console.ReadLine());
                        }
                        Console.Write("La media dei 10 numeri è: {0}", (float)tot / 10);
                        break;
                    case "6":
                        Console.WriteLine("operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);
                        Console.Write("Inserisci 10 numeri; uno per riga");
                        array = new int[10];
                        for (int i = 0; i < 10; i++)
                        {
                            array[i] = int.Parse(Console.ReadLine());
                        }
                        Console.Write("Il minimo dei 10 numeri è: {0}", array.Min());
                        break;
                    case "7":
                        Console.WriteLine("operazione richiesta: {0}", comandi[Convert.ToInt32(cmd)]);
                        Console.Write("Inserisci 10 numeri; uno per riga");
                        array = new int[10];
                        for (int i = 0; i < 10; i++)
                        {
                            array[i] = int.Parse(Console.ReadLine());
                        }
                        Console.Write("Il massimo dei 10 numeri è: {0}", array.Max());
                        break;
                    default: Console.WriteLine("comando non esistente: {0}.", cmd); break;
                }
            }
            catch (Exception ex) { Console.WriteLine("Puoi inserire solo numeri"); }
        }
        /*
             * Realizzare un programma che chiede all utente che tuipo di operazione intende 
             * svolgere(0-somma, 1-prodotto,2-divisione,3-sottrazione,4-quadrato,5-media) 
             * e poi se somma,prodotto,divisione o sottrazione chiede due valori, se quadrato chiede un solo valore e 
             * se media chiede 10 valori.
             * Utilizzare un vettore di interi o reali per archiviare i valori di input.
             * OPZIONALE: implementare l operazione di elevamento a potenza superiore al 2.
             */


    }
}