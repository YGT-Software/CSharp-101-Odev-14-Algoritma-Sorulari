namespace soru_4;
class Program
{
    static void Main(string[] args)
    {
        //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        Console.WriteLine("Lütfen bir cümle yazınız:");
        string cumle = Console.ReadLine();

        string[] kelimeler = cumle.Split(' ');
        int kelime = kelimeler.Count();

        char[] bosuluksuzCumle = cumle.Replace(" ", string.Empty).ToCharArray();
        int harf = bosuluksuzCumle.Count();

        Console.WriteLine("Toplam Kelime Sayısı: " + kelime + " Toplam Harf Sayısı: " + harf);
    }
}
