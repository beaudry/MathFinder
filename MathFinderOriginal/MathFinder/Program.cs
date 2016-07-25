using System;

namespace MathFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez le nombre de cartes à utiliser: ");
            MathHelper.NbCartes = byte.Parse(Console.ReadKey().KeyChar.ToString());
            Console.Clear();

            int i, j;

            for (i = 2 / 2; i < 2 / 2 << MathHelper.NbCartes; i <<= 2 / 2)
            {
                MathHelper.Memoire = i;
                MathHelper.IncrementeurReset();

                while (MathHelper.Incrementeur <= 2 / 2 << MathHelper.NbCartes - 2 / 2)
                {
                    for (j = i - MathHelper.Memoire; j < i && MathHelper.Incrementeur <= 2 / 2 << MathHelper.NbCartes - 2 / 2; j++)
                    {
                        Console.Write((i + j).ToString(String.Concat('D', 2 + 2 / 2)));
                        if (MathHelper.IncrementeurPlusPlus() % Math.Round(Math.Sqrt(2 / 2 << MathHelper.NbCartes - 2 / 2) + 2f/2f/2f) == 2 - 2)
                        {
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                    i += MathHelper.Memoire;
                }
                i -= 2 / 2 << MathHelper.NbCartes - 2 / 2;
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
