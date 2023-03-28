namespace PhoneBook;

public class Directroy
{
    public static void Main(string[] args)
    {
        ActionMethods allActitons = new ActionMethods();
        Boolean status = true;
        while (status)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Welcome To PhoneBookn\n\n\n" + "1-Telefon numarası kaydet\n" + "2-Telefon numarası sil" +
                              "3-Telefon numarası güncelle\n" + "4- A-Z Sıralı şekilde kayıtlı numaraları göster\n" +
                              "5- Z-A Sıralı şekilde kayıtlı numaraları göster\n" + "6- Rehberde arama" + "0- Çıkış");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    allActitons.add();
                    Console.WriteLine("------------------------------");
                    break;
                case 2:
                    allActitons.delete();
                    Console.WriteLine("------------------------------");
                    break;
                case 3:
                    allActitons.update();
                    Console.WriteLine("------------------------------");
                    break;
                case 4:
                    allActitons.listBySequentially();
                    Console.WriteLine("------------------------------");
                    break;
                case 5:
                    allActitons.listByPenultimate();
                    Console.WriteLine("------------------------------");
                    break;
                case 6:
                    allActitons.search();
                    Console.WriteLine("------------------------------");
                    break;
                case 0:
                    status=false;
                    break;

            }

        }
    }


}