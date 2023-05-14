using EntityFramework;

class MainEntryPoint
{
    static void Main()
    {
        bool quit = false;
        do
        {
            Console.WriteLine("Che operazione vuoi eseguire?");
            Console.WriteLine("[1] Aggiungi un team");
            Console.WriteLine("[2] Aggiungi un giocatore");
            Console.WriteLine("[3] Ricerca un giocatore");
            Console.WriteLine("[4] Termina il programma");
            int selector = Convert.ToInt16(Console.ReadLine());

            switch (selector)
            {
                case 1:
                    Console.WriteLine("A");
                    break;
                case 2:
                    Console.WriteLine("A");
                    break;
                case 3:
                    Console.WriteLine("A");
                    break;
                case 4:
                    quit = true;
                    break;
                default: 
                    Console.WriteLine("Operazione non valida!");
                    break;
            }

        } while (!quit);
    }
}