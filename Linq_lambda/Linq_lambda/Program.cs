using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_lambda
{
    /// <summary>
    /// vi du cho mot danh sach cac so nguyen
    /// Bieu thuc lamblda dau tien danh gia tri binh phuong cho moi phan tu {x => x*x}
    /// bieu thuc thu hai duoc su dung de tim gia tri nao chia het cho 3
    /// </summary>
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> Ds = new List<int>() { 36,71,12,15,29,18,26,17,9,34};

            // in cach phan tu trong danh sach
            foreach (int s in Ds)
            {
                Console.Write(" "+s);
            }
            Console.WriteLine();
            // gan gia tri binh phuong cho moi phan tu
            var number = Ds.Select(x => x*x);


            foreach(int s in number)
            {
                Console.Write(" " + s);
            }
            Console.WriteLine();
            var check = number.Where(x => (x % 3) == 0);

            foreach (int s in check)
            {
                Console.Write(" " + s);
            }
        } 


    }
    

 
   
}
