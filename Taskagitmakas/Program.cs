using System.ComponentModel.Design;

namespace Taskagitmakas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tas, Kagit , Makas oyununa hosgeldiniz.");
            Console.WriteLine("Uc kez kazanan oyunu kazanir.");
            
            
            int oyuncuKazanma = 0;
            int bilgisayarKazanama = 0;
            bool dongu = true;
            while (dongu)
            {
                do
                {
                    Console.WriteLine("Seciminizi yapiniz");
                    string oyuncuSecimi = Console.ReadLine();
                    Random random = new Random();
                    int bilgisayarSecimi = random.Next(1, 4);

                    switch (bilgisayarSecimi)
                    {
                        case 1:
                            {

                                Console.WriteLine("Bilgisayar Tas secti");
                                if (oyuncuSecimi == "Tas")
                                {
                                    Console.WriteLine("Berabere");
                                }
                                else if (oyuncuSecimi == "Kagit")
                                {
                                    Console.WriteLine("Oyuncu Kazandi");
                                    oyuncuKazanma++;
                                }
                                else
                                {
                                    Console.WriteLine("Bilgisayar Kazandi");
                                    bilgisayarKazanama++;
                                }

                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Bilgisayar Kagit Secti");
                                if (oyuncuSecimi == "Tas")
                                {
                                    Console.WriteLine("Bigisayar Kazandi");
                                    bilgisayarKazanama++;
                                }
                                else if (oyuncuSecimi == "Kagit")
                                {
                                    Console.WriteLine("Berabere");
                                }
                                else
                                {
                                    Console.WriteLine("Oyuncu Kazandi");
                                    oyuncuKazanma++;
                                }

                                break;

                            }

                        case 3:
                            {
                                Console.WriteLine("Bilgisayar Makas Secti");
                                if (oyuncuSecimi == "Tas")
                                {
                                    Console.WriteLine("Oyuncu Kazandi");
                                    oyuncuKazanma++;
                                }
                                else if (oyuncuSecimi == "Kagit")
                                {
                                    Console.WriteLine("Bilgisayar Kazandi");
                                    bilgisayarKazanama++;
                                }
                                else
                                {
                                    Console.WriteLine("Berabera");
                                }
                                break;
                            }




                    }
                } while (bilgisayarKazanama < 3 && oyuncuKazanma < 3);

                Console.WriteLine("Tekrar oynamak ister misiniz?(e/h)");
                char tekrarOynama = Convert.ToChar(Console.ReadLine());
                if (tekrarOynama == 'e')
                {
                    dongu = true;
                }
                else
                {
                    dongu = false;
                }
            }
                
            Console.ReadLine();
        }
    }
}