using System;

namespace csharp3
{
    class Person
    {
        int[] age = { 23, 32, 43 };
        static void Main(string[] args)
        {

            //string[] name = new string[4];
            //for (int i = 0; i < 4; i++) {
            //Console.Write("Ad daxil edin:");
            //name[i] = Console.ReadLine();
            // }
            //Console.WriteLine("Telebe adlari");
            // for(int i = 0; i < 4; i++)
            //{
            //Console.WriteLine(name[i]);
            //}
            //Console.Read();




            //int[] reqem = new int[10];
            //for (int i = 0; i < 10; i++) {
            //Console.Write((i+1).ToString()+".Reqem daxil edin: ");
            //reqem[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.Read();




            //int[] number = new int[5];
            //for(int i = 0; i < 5; i++)
            //{
            // Console.Write((i + 1).ToString() + ".Reqemi daxil edin: ");
            // number[i] = Convert.ToInt32(Console.ReadLine());
            // }
            // int max;
            //max = number[0];

            //for (int i = 0; i < 5; i++) {
            //if (max < number[i])
            //{
            //max = number[i];
            //}
            //}
            //Console.Write("En boyuk eded: " + max);
            //onsole.Read();

            Person Mehriban = new Person();
            Person Eziz = new Person();
            Person Teymur = new Person();

            Console.WriteLine("Mehwibanin yawi "+ Mehriban.age[0]);
            Console.WriteLine("Ezizin yawi "+ Eziz.age[1]);
            Console.WriteLine("Teymurun yawi " + Teymur.age[2]);

            Console.Read();


        }
    }
}
