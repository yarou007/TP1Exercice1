using System;

namespace TP1Exerice1
{
    public static class Porgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donner nombre de produit a ajouter? ");
            int n = int.Parse(Console.ReadLine());
            double[] prixHT = new double[n];

            for (int i = 0; i < prixHT.Length; i++) {
                Console.WriteLine("Saisir prix pour produit num"+(i+1)+": ");
                prixHT[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("-----Affichage prix HT----");
            foreach(double p in prixHT)
            {
                Console.WriteLine(p);
            }

            double[] prixTTC = new double[n];
            for (int i = 0; i < prixTTC.Length; i++)
            {
                prixTTC[i] += prixHT[i]+ (prixHT[i] * 0.20); 
            }
            Console.WriteLine("-----Affichage prix TTC ----");
            foreach (double p in prixTTC)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("-----Affichage prix TTC TRIER ----");

            Array.Sort(prixTTC);
            foreach (double p in prixTTC)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("Prix TTC MIN " + prixTTC.Min());
            Console.WriteLine("Prix TTC MAX " + prixTTC.Max());

        }
    }
}