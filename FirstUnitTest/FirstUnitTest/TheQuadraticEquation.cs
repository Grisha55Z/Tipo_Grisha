using System.Security.Cryptography.X509Certificates;

namespace FirstUnitTest
{
    public class TheQuadraticEquation
    { 
        private int Diskcremenant;
        public int a;
        public int b;
        public int c;
        public double[] roots;
        public TheQuadraticEquation(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            FindRoots();
        }
        public void FindRoots()
        {
            Diskcremenant = b * b - 4 * a * c;
            if (Diskcremenant < 0)
            {
                roots = new double[0];
                return;
            }
            if(Diskcremenant == 0 ) 
            {
                roots = new double[1];
                roots[0] = -1 * b / 2 * a;
                return;
            }
            roots = new double[2];
            roots[0] = (-1 * b + Diskcremenant) / 2 * a;
            roots[1] = (-1 * b - Diskcremenant) / 2  * a;
        }
    }
}