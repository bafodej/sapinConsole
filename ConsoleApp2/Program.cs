// See https://aka.ms/new-console-template for more information
// Exercice sapin de noel 

string tronc = (" ||| ");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" ---------------------------------");
Console.WriteLine("|  Bonjour et joyeuse fetes  :)   |");
Console.WriteLine("|                                 |");
Console.WriteLine("|  Entez la hauteur de votre sapin|");
Console.WriteLine("|    s'il vous plait    ^_^       |");
Console.WriteLine("|                                 |");
Console.WriteLine(" --------------------------------- ");

char feuille = '*';

int hauteurSapin = int.Parse(Console.ReadLine());
/*string afficherSapin(int hauteurSapin){*/










Console.WriteLine("Saisissez la taille du sapin ");
hauteurSapin = int.Parse(Console.ReadLine());
for (int i = 1; i <= hauteurSapin; i += 2)
{
    for (int k = i; k <= hauteurSapin; k++)
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= i; j++)
    {
        Console.Write($"{feuille}" + " ");

/*        for (int m = 1; m <= hauteurSapin / 3; m++)
        {
            Console.WriteLine($"{tronc}");
        }
        for (int l = 1; l <= hauteurSapin / 3; l++)
        {
            Console.WriteLine($"{tronc}");*/

            /* string dessinerFeuille(hauteurSapin)
            {


                Console.WriteLine($"{hauteurSapin * feuille}");
            }
            */
            /*for (int i = 0; i >= hauteurSapin; i += 2) ;
            {
               Console.WriteLine($"{hauteurSapin * '*' }");
            }*/






            /*string ajouterTronc(int hauteurSapin)
        {*/
            /*      for (int m = 1; m <= hauteurSapin / 3; m++)
                  {
                      Console.WriteLine($"{tronc}");
                  }
                  for (int l = 1; l <= hauteurSapin / 3; l++)
                  {
                      Console.WriteLine($"{tronc}");
                  }*/
            /*}*/
            /* ajouterTronc (hauteurSapin);*/
        }
        /*    for (int k = 1; k <= hauteurSapin; ++k)
            {
                Console.Write(" ||| ");
            }*/
        Console.WriteLine();

    }




/*afficherSapin(hauteurSapin);*/