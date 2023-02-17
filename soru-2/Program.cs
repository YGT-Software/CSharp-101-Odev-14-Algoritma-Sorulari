namespace soru_2;
class Program
{
    static void Main(string[] args)
    {
        //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

        Console.WriteLine("Lütfen iki tane pozitif sayı giriniz:");
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        if (n <= 0 && m <= 0)
        {
            Console.WriteLine("Pozitif sayı girmediniz. Lütfen iki tane pozitif sayı giriniz:");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
        }
        int[] sayilar = new int[n];
        Console.WriteLine("Lütfen " + n +" adet pozitif sayı giriniz:");
        for (int i = 0; i < n; i++)
        {   
            
            int z = int.Parse(Console.ReadLine());
            sayilar[i] = z;

        }


       foreach (var item in sayilar)
       {
         if (item % m == 0)
         {
            Console.WriteLine(item);
         }
       }

    }
}
