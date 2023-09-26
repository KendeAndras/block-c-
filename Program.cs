namespace kiskoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //be
            int db;
            //ki
            bool was;
            //ellenorzeshez
            bool error;
            string inputText;
            //beolvasas (darabszam)

            do
            {
                Console.WriteLine("hanyan vettek reszt(egesz szam): ");
                inputText = Console.ReadLine();
                error = !int.TryParse(inputText, out db) || db < 0;
                if (error)
                {
                    Console.WriteLine("egesz szam battya...egesz szam...");
                }

            } while (error);

            //tomb deklaralas

            int[] participants = new int[db+ 1];

            //beolvasas (tomb)

            int i;// geci c# csak igy viszi, a ciklusbol valamiert kintre is ertelmezi ezt a szart
            for (i = 1; i <= db ; i++)
            {
                do
                {
                    Console.WriteLine("add meg {0}. eletkort, 10-100 kozotti egesz szam", i);
                    inputText = Console.ReadLine();
                    error = !int.TryParse (inputText, out participants[i]) || 10 > participants[i] || participants[i] > 100;

                    if (error)
                    {
                        Console.WriteLine("egesz szam 10-100 kozott...mi nem egyertelmu?");
                    }

                } while (error);
            }

            //feldolgozas

            i = 1;
            
            while (i <= db && participants[i] >= 18)
            {
                i++;
            }

            was = i <= db;

            //Kiiras
            if (was)
            {
                Console.WriteLine("volt gyerek");
            }
            else {

                Console.WriteLine("nem volt gyerek");

                }

        }
    }
}