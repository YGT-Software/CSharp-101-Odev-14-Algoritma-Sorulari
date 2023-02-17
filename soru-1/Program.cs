namespace soru_1;
class Program
{
    static void Main(string[] args)
    {
        //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

        Console.WriteLine("Lütfen bir pozitif sayı giriniz:");
        int sayi = int.Parse(Console.ReadLine());

        if (sayi > 0)
        {
            int[] sayilar = new int[sayi];
            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine("Lütfen bir pozitif sayı giriniz:");
                int sayiN = int.Parse(Console.ReadLine());
                if (sayiN > 0)
                {
                    sayilar[i] = sayiN;
                }
                else
                {
                    Console.WriteLine("Pozitif bir sayı girmediniz, lütfen tekrar deneyiniz:");
                    sayiN = int.Parse(Console.ReadLine());
                    sayilar[i] = sayiN;
                }
            }
            foreach (var item in sayilar)
            {

                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }

        }
        else
        {
            Console.WriteLine("Pozitif bir sayı girmediniz, lütfen tekrar deneyiniz:");
            sayi = int.Parse(Console.ReadLine());
        }




    }
}
