using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing;

namespace DeberParalelismo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"C:\Users\usuario\Desktop\fotos1\";
            string path2 = @"C:\Users\usuario\Desktop\fotos2\";

            string[] lst = Directory.GetFiles(path1);
            int a= 1;
            foreach (var archivo in lst)
            {
                File.Copy(archivo, path2 + "a"+ a+ ".jpg");
                a++;

                Console.WriteLine("Proceso completado");
                Console.ReadKey();
            }
        }
    }
}
