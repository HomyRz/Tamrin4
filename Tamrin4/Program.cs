using System;
namespace Tamrin4
{
    public class Paper
    {
        public int Lengh;
        public int Hight;
        public int Width;
        public Paper(int Lengh, int Hight)
        {
            this.Lengh = Lengh;
            this.Hight = Hight;
        }
        public Paper(int Lengh, int Hight, int Width)
        {
            this.Lengh = Lengh;
            this.Hight = Hight;
           this.Width = Width;
        }
        public int CalcVolume()
        {
            return (Lengh * Lengh)* Width;
        }
        public int CalcArea()
        {
            return Lengh * Hight;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Paper Area = new Paper(5,8);
            int a=Area.CalcArea();
            Console.WriteLine("Area:" + a);
            Paper Volume = new Paper(5, 8, 2);
            int v = Volume.CalcVolume();
            Console.WriteLine("Volume:"+v);
        }
    }
}