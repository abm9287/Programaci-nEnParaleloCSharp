using System;
using System.Threading.Tasks;
using System.IO;

namespace ProgramacionEnParalelo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programación en paralelo
            string path1 = @"C:\Users\venom\OneDrive\Escritorio\Tercer Semestre\fotos1";
            string path2 = @"C:\Users\venom\OneDrive\Escritorio\Tercer Semestre\fotos2";



            string[] lst = Directory.GetFiles(path1);
            Random r = new Random(10000);
            Parallel.ForEach(lst, (archivo) =>
            {
                int a = r.Next();

                File.Copy(archivo, path2 + "a" + a + ".png");
            });
        }
    }
}
