namespace AS2324._3G.RandazzoDiego.PSArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("anno scolastico 2023/2024, Randazzo Diego 3G, verifica sugli array paralleli");
            Console.WriteLine("inserisci la dimensione dell'array");
            int nVoti=Convert.ToInt32(Console.ReadLine());
            double[] voti = new double[nVoti];
            int[] pesi = new int[nVoti];
            double max = 0, min = 11;
            int posmax=0, posmin=0;
            CaricaVettori(ref voti, ref pesi);
            StampaVotiPesi(ref voti, ref pesi);
            StampaVotiDispariMaggioriDi4(ref voti, ref pesi);
            MediaPonderata(voti, pesi, ref max, ref posmax, ref min, ref posmin);
            double mediaP = MediaPonderata; 
            Console.WriteLine($"la media ponderata è {mediaP}");
            Console.WriteLine($"il valore minimo è {min} in posizione {posmin} e il valore più grande è {max} in posizione {posmax}");
            OrdinaPerVoto(ref voti, ref pesi, nVoti);
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
        static void StampaVotiPesi(ref double[] voti, ref int[] pesi)
        {
            for (int i = 0;i < voti.Length; i++)
            {
                Console.WriteLine($"il voto {i + 1} è {voti[i]}" );
                Console.WriteLine($"il peso {i + 1} è {pesi[i]}");
            }
        }
        static void StampaVotiDispariMaggioriDi4(ref double[] voti, ref int[] pesi)
        {
            
            for(int i = 0; i<voti.Length; i++)
            {
                if (i % 2 == 0)
                {
                   if(voti[i] > 4)
                   {
                      StampaVotiPesi(ref voti, ref pesi);
                   }

                }
                
            }
        }
        static double MediaPonderata(double[] voti, int[] pesi, ref double max, ref int posmax, ref double min, ref int posmin)
        {
            double num=0;
            double somma = 0;
            for(int i=0; i<voti.Length; i++)
            {
                num += voti[i] * pesi[i];
                somma += pesi[i];
                if (voti[i] > max)
                {
                    max= voti[i];
                    posmax = i;
                }
                if (voti[i] < min)
                {
                    min = voti[i];
                    posmin = i;
                }
                
            }
            double mediaP = num / somma;
            return mediaP;
            StampaVotiPesi(ref voti, ref pesi);
        }
        static void OrdinaPerVoto(ref double[] voti, ref int[] pesi, int nVoti)
        {
            for (int i = 0; i < voti.Length - 1; i++)
            {
                for (int j = 0; j < voti.Length - i - 1; j++)
                {
                    double temp = voti[j];
                    voti[j] = voti[j + 1];
                    voti[j + 1] = temp;
                }
            }
            StampaVotiPesi(ref voti, ref pesi);
        }
    }
}
