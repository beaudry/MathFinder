using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFinder
{
    /// <summary>
    /// Classe pour aider à résoudre le problème.
    /// </summary>
    public static class MathHelper
    {
        private static byte nbCartes = 0;

        private static int memoire;
        private static int incrementeur;

        private static byte nbAssigns = 0;

        /// <summary>
        /// Nombre de "cartes" à afficher.
        /// </summary>
        /// <exception cref="MethodAccessException">Lorsque l'on fait deux assignations dans la même instance.</exception>
        /// <remarks>Une seule affectation est permise.</remarks>
        public static byte NbCartes
        {
            get { return nbCartes; }
            set
            {
                if (nbCartes == 0)
                {
                    nbCartes = value;
                }
                else
                {
                    throw new MethodAccessException("Une seule affectation est permise pour le nombre de cartes.");
                }
            }
        }

        /// <summary>
        /// Mémoire disponible pour stocker ce que l'on veut.
        /// </summary>
        /// <exception cref="MethodAccessException">Lorsque l'on fait trop d'assignations.</exception>
        /// <remarks>On ne peut pas faire plus de <paramref name="nbCartes"/> assignations.</remarks>
        public static int Memoire
        {
            get { return memoire; }
            set
            {
                if (nbAssigns++ >= NbCartes)
                {
                    throw new MethodAccessException("Trop d'assignations!");
                }

                memoire = value;
            }
        }

        /// <summary>
        /// Chiffre disponible à utiliser, mais qu'on ne peut pas modifier directement.
        /// </summary>
        public static int Incrementeur
        {
            get { return incrementeur; }
            private set { incrementeur = value; }
        }

        /// <summary>
        /// Incrémente de 1 la valeur de l'incrémenteur.
        /// </summary>
        /// <returns>La valeur de l'incrémenteur avant d'être incrémenté.</returns>
        public static int IncrementeurPlusPlus()
        {
            return Incrementeur++;
        }

        /// <summary>
        /// Met la valeur de l'incrémenteur à 1.
        /// </summary>
        public static void IncrementeurReset()
        {
            Incrementeur = 1;
        }

    }
}
