using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_類的創建
{
    internal class Vehicle
    {
        public string? brand;
        public int speed;
        public int maxSpeed;
        public float weight;

        public void Run()
        {
            Console.WriteLine("車輛行駛中.......");
        }
        public void Stop()
        {
            Console.WriteLine("車輛停下了-------");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"\n車輛資訊> " +
                              $"\n品牌: {brand}" +
                              $"\n額定速度: {speed} KM/h" +
                              $"\n最大速度: {maxSpeed} KM/h" +
                              $"\n車重: {weight} 公噸");
        }
    }
}
