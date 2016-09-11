using System;

namespace ConsoleApplication
{
    public class Program
    {
        /// <summary>
        /// Public la che do cong khai dug cho cac class khac co the tham chieu
        /// Main la class khoi chay dau tien khi chay cua ung dung
        /// void la phuong thuc khng co gia tri tra ve
        /// static:
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world");

            var name = "thuy bui";//var la khai bao bien no tuong duong voi
            string name2 = "thuybui";//2 dong nay y nghix tuong duong nhua deu co ngia la khai ba 1 bien string
            Console.WriteLine($"Hello {name}+{name2}");
            Console.ReadLine();//lenh dung man hinh khi chay chuong trinh

        }
        public static void chuoistring()
        {
            string name1;//khoi tao ban dau la null
            string name2 = "thuy";
            name1 = "thuththt";//khoi tao luc sau gan cho name1 =""
            
    
        }
    }
}