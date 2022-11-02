using System;
using System.Numerics;
using System.Threading.Channels;

namespace classtask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username;
            string password;
            int ay = 12;
            int faiz = 18;
            int illikOdenillecekMebleg = 0;
            int ayliqOdenis = 100;

            Console.WriteLine("username:");
            username = Console.ReadLine();
            Console.WriteLine("password:");
            password = Console.ReadLine();

         
            if (username == "naciye" && password == "1224" )
            {
                Console.WriteLine();
                a:
                Console.WriteLine("1. Kredit goturmek \n 2. Kredit odemek \n 3. Hesabat \n");
                Console.Write("Emeliyyat:");
                 int emeliyyat = Int32.Parse(Console.ReadLine());
                
              

                   if (emeliyyat == 1)
                    {

                        Console.Write("Ayliq odenis:" );
                        ayliqOdenis = Int32.Parse(Console.ReadLine());
                        Console.Write("Odemek uchun 1 basin:");
                        int odemekUchun1basin = Int32.Parse(Console.ReadLine());
                        Console.Write("ODENIOS UGURLU OLDU!");
                        string odenishgugurluoldu = Console.ReadLine();
                        Console.Write("Qaliq borc:");
                        string qaliqborc = Console.ReadLine();
                        Console.Write("Qalan ay:" + (--ay));
                        string qalanay =Console.ReadLine();
                        goto a;

                    }

                    else if (emeliyyat == 2)
                    {
                        Console.Write("Ayliq odenis:");
                        ayliqOdenis = Int32.Parse(Console.ReadLine());
                        Console.Write("Meblegi daxil edin:" +(2000));
                        string meblegidaxiledin = Console.ReadLine();
                    Console.Write("Qalan ay: "+ (--ay));
                    
                    Console.Write("Razisiniz");
                        int razisiniz = Int32.Parse(Console.ReadLine());
                        Console.Write("1. Beli");
                        string beli = Console.ReadLine();
                        Console.Write("2. Xeyr");
                        string xeyr = Console.ReadLine();
                        Console.Write("Emeliyyat ugurlu oldu!");
                        string emeliyyatugurluoldu = Console.ReadLine();
                        goto a;
                    }
                    else if (emeliyyat == 3)
                    {
                        Console.Write("Ayliq odenis:" );
                        ayliqOdenis = Int32.Parse(Console.ReadLine());
                        Console.Write("Meblegi daxil edin:" + (1000));
                        string meblegidaxiledin = Console.ReadLine();
                        Console.Write("Borcunuz:");
                        string borcunuz = Console.ReadLine();
                        Console.Write("Qalan ay:" +(--ay));
                        string beli = Console.ReadLine();
                        Console.Write("Menyuya qayitmaq ucun o click edin: ");
                        string menyu = Console.ReadLine();
                        goto a;
                    }
                    else if (emeliyyat == 2)
                    {
                        Console.Write("Ayliq odenis:" );
                        ayliqOdenis = Int32.Parse(Console.ReadLine());
                        Console.Write("Meblegi daxil edin:" +(100));
                        string meblegidaxiledin = Console.ReadLine();
                        Console.Write("Borcunuz: yoxdur");
                        string borcunuz = Console.ReadLine();
                        Console.Write("Qalan ay:"+ (0));
                        string beli = Console.ReadLine();
                        goto a;
                    }

                
            }
        }
    }
}
