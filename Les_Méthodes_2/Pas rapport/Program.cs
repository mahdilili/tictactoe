namespace Pas_rapport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[,,] byNombres = new byte[3,2,2];
            byte z = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j   = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        byNombres[i, j, k] = z ;
                        z++;
                    }
                }
            }
        }
    }
}