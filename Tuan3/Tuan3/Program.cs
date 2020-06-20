using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Tu_Dien_AV = new Dictionary<string, string>();
            Tu_Dien_AV.Add("Hello", "xin chao");
            Tu_Dien_AV.Add("goodbye", "tam biet");
            string Tu_Tieng_Anh;
            Console.Write("Nhap tu tieng anh can tra: ");
            Tu_Tieng_Anh = Console.ReadLine();
            if(!Tu_Dien_AV.ContainsKey(Tu_Tieng_Anh))
            {
                Console.WriteLine("Khong co trong tu dien");
            }
            else
            {
                string Nghia_Tieng_Viet = Tu_Dien_AV[Tu_Tieng_Anh];
                Console.WriteLine("Nghia tieng Viet cua {0} la: {1}", Tu_Tieng_Anh, Nghia_Tieng_Viet);
            }
            Console.ReadKey();
        }
    }
}
