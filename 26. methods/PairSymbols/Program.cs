using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PairSymbols {
    class Program {
        static void Main(string[] args) {
            CheckPairs("namespace ConsoleApplication1 {class Program {static void Main(string[] args) {}", "{", "}");
            CheckPairs("graphics = e.Graphics;graphics.SmoothingMode = SmoothingMode.AntiAlias;graphics.Clear(Color.FromArgb(0x44444400));DrawCar(carX, 200);", "(", ")");

            Console.ReadLine();
        }
    }
}
