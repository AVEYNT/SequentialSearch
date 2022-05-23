using System;

class Pro
{
    static int [] data = new int[4] { 10, 24, 3, 5 };
    static int x;

    static void Main (String [] args)
    {
    carilagi:
        Console.WriteLine("Masukan Data");
        x = Int32.Parse(Console.ReadLine());

        cari(x, data);
        goto carilagi;
    }
    private static void cari(int x, int [] data)
    {
        for(int i=0; i<data.Length; i++)
        {
            if (data[i] == x)
            {
                Console.WriteLine("Data "+ x+" ditemukan\n=================");
                Environment.Exit(1);// exit
            }
        }
    }
}
