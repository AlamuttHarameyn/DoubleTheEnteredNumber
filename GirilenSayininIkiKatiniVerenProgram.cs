using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._9_SozDizilimiVeTemelProgramlama
{
    class GirilenSayininIkiKatiniVerenProgram
    {
        static void Main(string[] args)
        {
            int x = 2; //X 2 olarak tanımlanıyor.Girilen sayı 2
            int y = 2 * x; //Y 2*x olarak tanımlanıyor.
            Console.WriteLine(y); //Kodu sonlandırıyor. artık program çalıştırılabilir.
            Console.ReadKey(); //Program kapanmadan önce bir tuşa basmamı istesin.
        }
    }
}
