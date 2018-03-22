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
            double height = 0 ;
            double weight = 0 ;
            double bmi = 0 ;
            
            // 輸入身高
            Console.WriteLine("請輸入身高(公尺) : {0} ", height);
            string height = Console.ReadLine();
           
            // 輸入體重
            Console.WriteLine("請輸入體重(公斤) : {0} ", weight);
            string weight = Console.ReadLine();
        
            // BMI = 體重(公斤) /身高*身高(公尺*公尺)
            double h = double.Parse(height)*double.Parse(height);
            double bmi = double.Parse(weight) / h;
            
            // 輸出結果
            Console.WriteLine("你的BMI值為: {0}", + bmi);
            Console.ReadLine();    
             
            // 顯示健康狀況
            if ( bmi < 18.5 )
	        {
	        Console.WriteLine("過輕");
	        Console.ReadLine();
	        }

            else if ( bmi >= 18.5 || bmi <24 )
	        {
	        Console.WriteLine("正常");
	        Console.ReadLine();
	        }

            else if ( bmi >= 24 )
	        {
	        Console.WriteLine("胖");
	        Console.ReadLine();
	        }   
        }
    }
}
