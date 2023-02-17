namespace soru_3;
class Program
{
    static void Main(string[] args)
    {
        //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

        Console.WriteLine("Lütfen bir pozitif sayı giriniz:");
        int n = int.Parse(Console.ReadLine());


        if (n > 0)
        {
            string[] kelimeler = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen " + (n-i) + " adet kelime giriniz:");
                string z = Console.ReadLine();
                kelimeler[i] = z;
            }
        Array.Reverse(kelimeler);
        foreach (var item in kelimeler)
        {
            Console.WriteLine(item);
        }
        }
        else
        {
            Console.WriteLine("Pozitif bir sayı girmediniz, lütfen tekrar deneyiniz:");
            n = int.Parse(Console.ReadLine());
        }
    }
}
