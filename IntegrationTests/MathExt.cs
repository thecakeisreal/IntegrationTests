namespace IntegrationTests
{
    /// <summary>
    /// Définit quelques algorithmes mathématiques simples
    /// </summary>
    public static class MathExt
    {
        /// <summary>
        /// Applique la méthode du PGCD de knuth pour déterminer le plus
        /// grand commun divisieur
        /// </summary>
        /// <param name="a">Le premier nombre</param>
        /// <param name="b">Le second nombre</param>
        /// <returns>Le pgcd des deux nombres ou -1 si les nombres sont invalides</returns>
        public static int PGCD(int a, int b)
        {
            if (a < 1 || b < 1)
            {
                return -1;
            }

            int t;
            while (b != 0)
            {
                t = b;
                b = a % b;
                a = t;
            }

            return a;
        }

        /// <summary>
        /// Trouve le plus petit commun multiple de deux nombres
        /// </summary>
        /// <param name="a">Le premier nombre</param>
        /// <param name="b">Le second nombre</param>
        /// <returns>Le PPCM des deux nombres passés en entrée</returns>
        public static int PPCM(int a, int b)
        {
            return (a * b) / PGCD(a, b);
        }
    }
}
