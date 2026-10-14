namespace Boucles;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : faire un compteur qui va de 1 à 10
        int compteur = 0;
        int compteur2 = 5;
        for (int i = 0; i < 10; i++)
        {
            compteur++;
            Console.WriteLine(compteur);
        }
        // Etape 2 : faire un décompte qui va de 5 à 1 puis qui dit "Bonne année !"
        for (int o = 0; o < 5; o++)
        {

            Console.WriteLine(compteur2);
            compteur2--;




        }
        Console.WriteLine("Bonne année");

        // Etape 3 : faire un compteur qui va de -4 à 2
        int compteur3 = -4;
        for (int j = 0; j < 7; j++)
        {
            Console.WriteLine(compteur3);
            compteur3++;

        }

        // Etape 4 : faire un compteur qui compte 2 par 2 de 0 à 15
        int compteur4 = 0;
        for (int p = 0; p < 7; p++)
        {
            compteur4 += 2;
            Console.WriteLine(compteur4);
            if (compteur4 == 14)
            {
                compteur4 += 1;
                Console.WriteLine(compteur4);
            }

        }


        // Etape 5 : faire une boucle qui se répète à chaque fois que l'utilisateur écrit autre chose que "oui"

        while (true)
        {
            string Reponse = Console.ReadLine();

            if (Reponse != "oui")
            {
                Console.WriteLine(compteur);
                Console.WriteLine(compteur2);
                Console.WriteLine(compteur3);
                Console.WriteLine(compteur4);


            }

        }



        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}