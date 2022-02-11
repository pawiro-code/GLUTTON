using System;

public class Program
{
    public static void Main()
    {
        
        
        int n = int.Parse(Console.ReadLine());
        int[] wyniki = new int[n];

        for (int i = 0; i < n; i++)
        {
            string[] s = Console.ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int[] tab_czasow = new int[a];
            int[] tab_ciastka = new int[a];
            int suma_ciastek = 0;
            for(int j=0; j<a; j++)
            {

                tab_czasow[j] = int.Parse(Console.ReadLine());
                //24h = 86400s
                tab_ciastka[j] = 86400 / tab_czasow[j];
                suma_ciastek += tab_ciastka[j];

            }
            
           // int suma_ciastek = 0;
            
            if (suma_ciastek % b == 0)
            {
                Console.WriteLine(suma_ciastek / b);
            }
            else
            {
                Console.WriteLine(suma_ciastek / b + 1);
            }

        }
    }
}
