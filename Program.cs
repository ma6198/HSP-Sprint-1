﻿using System;

namespace HSP_Algorithmus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parametereingabe mit Wertbegrenzungen
            Console.WriteLine("Eingabe der Zahnradparameter");
            //Modul m
            Console.WriteLine("Zahnradmodul m");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m <= 0)
            { Console.WriteLine("Fehler: Parameter muss größer als 0 sein"); }
            //Kopfspiel c
            Console.WriteLine("Kopfspiel c");
            Double c = Convert.ToDouble(Console.ReadLine());
            if((c > 0.3) && (c < 0.1) && (c == 0))
            {Console.WriteLine("Fehler: Parameter muss zwischen 0.1 und 0.3 liegen"); }
            //Teilkreisdurchmesser
            Console.WriteLine("Teilkreisdurchmesser d");
            Double d = Convert.ToDouble(Console.ReadLine());

            //Berechnungen
            //Zahnhöhe
            double h = 2 * m + c;
            //Zahnfußhöhe
            double hf = m + c;
            //Zahnkopfhöhe
            double ha = m;
            //Teilung
            double p = 3.14 * m;
            //Zahnzahl
            double z = m / d;
            //Fußkreisdurchmesser
            double df = d - 2 * (m + c);


            //Ausgabe
            Console.WriteLine("Zahnhöhe h =                 " + h) ;
            Console.WriteLine("Zahnfußhöhe hf =             " + hf);
            Console.WriteLine("Zahnkopfhöhe ha =            " + ha);
            Console.WriteLine("Teilung p =                  " + p);
            Console.WriteLine("Zahnzahl z=                  " + z);
            Console.WriteLine("Fußkreisdurchmesser df =     " + df);

        }
    }
}
