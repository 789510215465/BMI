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
            // double rate = 0;
            // 顯示匯率
            // Console.WriteLine("目前匯率值 : {0} ", rate);

            // 輸入金額
            // Console.Write("請輸入烏干達幣金額 : ");
            // string input = Console.ReadLine();

            // 換算
            // double total = double.Parse(input) * rate;

            // 結果
            // Console.WriteLine("換算成鬼島幣金額 :{0}", +total);
            
            // BMI = 體重(公斤) /身高*身高(公尺*公尺)
            double height = 0 ;
            double weight = 0 ;
            double bmi = 0 ;
            
            Console.WriteLine("請輸入身高(公尺) : {0} ", height);
            string height = Console.ReadLine();
           
            Console.WriteLine("請輸入體重(公斤) : {0} ", weight);
            string weight = Console.ReadLine();
           
            
            double h = double.Parse(height)*double.Parse(height);
            double bmi = double.Parse(weight) / h;
            
            Console.WriteLine("你的BMI值為: {0}", + bmi);
            Console.ReadLine();    
                
            if 18.5≦bmi＜24
            
            
            
            
            
            
            
            
                
        }
    }
}
