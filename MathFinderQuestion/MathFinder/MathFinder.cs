using System;

namespace MathFinder
{
    class MathFinder
    {
        static void Main(string[] args)
        {

            /*
             * MISE EN SITUATION:
             * 
             * Il existe un tour de magie où l'on demande à quelqu'un de choisir un nombre, puis on lui montre des cartes contenant
             * des chiffres et on lui demande d'indiquer les cartes qui contiennent son nombre, puis, à sa grande surprise, on lui dit
             * son chiffre immédiatement. Le tour repose sur le fait que chaque carte contient tous les nombres qui ont un "1" 
             * à leur position en binaire. Donc la première carte va contenir tous les nombres où le dernier chiffre de leur version en
             * binaire est 1. Le résultat est d'ailleurs tous les nombres impairs. Pour la seconde carte, il s'agit de tous les nombres
             * où le deuxième chiffre en binaire est 1, et ainsi de suite.
             * 
             * Vous remarquerez que le premier chiffre de chaque carte est une puissance de deux. C'est grâce à cette propriété que nous
             * sommes capable de réaliser le tour de magie, car en sachant à quelle position binaire on retrouve des 1 dans le nombre
             * choisi par la personne, nous pouvons reconstituer ce chiffre en additionnant le premier nombre se retrouvant sur les
             * cartes qui contiennent ce chiffre.
             * 
             * Nous vous demandons donc de créer une application qui va permettre de créer un "set" de X cartes, permettant la
             * réalisation de ce tour de magie. Toutefois, le métier de mathémagicien n'est pas très payant, alors peu de ressources vous
             * sont permises. Entre autre, le magicien n'a pas les moyens de s'acheter plus que deux variables, mais il possède un petit
             * helper qui va vous aider.
             * 
             * Si vous ne comprenez rien, j'ai trouvé un site qui semble l'expliquer, mais d'une façon assez bâtarde.
             * http://www.mathsbusking.com/shows-mind-reading.html
             * 
             * Vous n'avez pas le droit de collaborer avec d'autres équipes. Bon succès! :-)
             * 
             */

            /*
             * RÈGLEMENTS :
             * - Un string litéral seulement (donc au total, une paire de guillemets)
             * - Deux caractères litérals maximums (donc au total, deux paires d'apostrophes)
             * - Seulement deux integers vous sont permis (i et j)
             * - Vous n'avez pas le droit de créer de nouvelles variables
             * - Vous avez accès à la classe MathHelper pour vous aider
             * 
             * ============= MATHHELPER ==========================================
             * La classe MathHelper contient les propriétés statiques suivantes:
             *      + NbCartes, qui indique le nombre de cartes à afficher. 
             *        Vous ne pouvez initialiser cette valeur qu'une seule fois.
             *        
             *      + Memoire, qui vous permet de stocker le chiffre que vous désirez. Toutefois,
             *        vous ne pouvez pas lui faire plus de NbCartes assignations
             *        
             *      + Incrementeur, qui est accessible en lecture seulement, mais modifiable avec des méthodes de la classe MathHelper
             *      
             * Méthodes de la classe MathHelper:
             *      + IncrementeurReset(), qui met la valeur de Incrementeur à 1
             *      + IncrementeurPlusPlus(), qui vous retourne la valeur de Incrementeur, qui est ensuite augmenté de 1
             *      
             * ===================================================================
             * 
             * - Les opérations mathématique autorisées sont : +, -, /, *, %, <<, >>, Math.Round et Math.Sqrt
             * - Aucune autre opération provenant de la classe Math n'est acceptée
             * - Vous pouvez utiliser les ++, --, +=, -= si elles sont disponible
             * - Vous avez le droit de convertir un int en float, en double ou en decimal.
             * - Les cartes doivent être le plus carré possible (6x6 plutôt que 9x4)
             * 
             * - Le résultat dans la console doit être EXACTEMENT le même que dans l'exécutable que
             *   vous retrouverez dans le dossier du projet.
             * 
             * CRITÈRE EXTRA : 
             * - Le seul chiffre qui peut apparaître dans votre code est le chiffre 2
             */


            /*
             * Je n'ai pas la réponse absolue (mais quand même proche). Surprenez-moi! :-)
             */

            Console.Write("Entrez le nombre de cartes à utiliser: ");
            MathHelper.NbCartes = byte.Parse(Console.ReadKey().KeyChar.ToString());
            Console.Clear();

            int i, j;
        }
    }
}
