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
        
    }
}
