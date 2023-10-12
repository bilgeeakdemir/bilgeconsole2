namespace bilgeconsole2
{
    internal class Program
    {
        static void Main(string[] args) //Console programlarının ilk giriş noktası burasıdır.
        {
            // İlk tanımlamalar yapılıyor
            string name = ""; // ben burada hem değişgeni tanımladım hem de ilk değeri atadım

            string nameDesc;

            string Name;

            string NameDesc;

            // Değişgenlere değerler atanıyor

            name = "Bilge Akdemir"; // name isimli değişgene değer atadım.

            nameDesc = "Benim adım :";

            NameDesc = "Kızımın adı :";

            Name = "Mayıs";

            //Şimdi bunları yazdıralım

            Console.WriteLine(nameDesc + name); //dynamic kullanım

            Console.WriteLine("Bilge Akdemir"); //static kullanım

            Console.ReadKey();




            Console.WriteLine("Hello, World!");
        }
    }
}