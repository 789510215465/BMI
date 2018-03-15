using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double rate = 0;
            // 顯示匯率
            Console.WriteLine("目前匯率值 : {0} ", rate);

            // 輸入金額
            Console.Write("請輸入烏干達幣金額 : ");
            string input = Console.ReadLine();

            // 換算
            double total = double.Parse(input) * rate;

            // 結果
            Console.WriteLine("換算成鬼島幣金額 :{0}", +total);
        }
    }
}
