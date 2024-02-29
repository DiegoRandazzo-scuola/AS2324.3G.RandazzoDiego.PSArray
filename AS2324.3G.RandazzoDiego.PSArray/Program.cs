namespace AS2324._3G.RandazzoDiego.PSArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("anno scolastico 2023/2024, Randazzo Diego 3G, verifica sugli array paralleli");
            Console.WriteLine("inserisci la dimensione dell'array");
            int dim=Convert.ToInt32(Console.ReadLine());
            double[] voti = new double[dim];
            int[] peso = new int[dim];
            CaricaVettori(ref voti, ref peso);
            StampaVotiPesi(ref voti, ref peso);
            StampaVotiDispariMaggioriDi4(ref voti, ref peso);
        }
        static void CaricaVettori(ref double[] voti, ref int[] peso)
        {
            Random random = new Random();
            for (int i = 0; i < voti.Length; i++)
            {
                voti[i] = random.Next(1, 11);
                peso[i] = random.Next(0, 101);
            }
        }
        static void StampaVotiPesi(ref double[] voti, ref int[] peso)
        {
            for (int i = 0;i < voti.Length; i++)
            {
                Console.WriteLine($"il voto {i + 1} è {voti[i]}" );
                Console.WriteLine($"il peso {i + 1} è {peso[i]}");
            }
        }
        static void StampaVotiDispariMaggioriDi4(ref double[] voti, ref int[] peso)
        {
            for(int i = 0; i<voti.Length; i+=2)
            {
                if(voti[i] > 4)
                {
                    StampaVotiPesi(ref voti, ref peso);
                }
            }
        }
    }
}
