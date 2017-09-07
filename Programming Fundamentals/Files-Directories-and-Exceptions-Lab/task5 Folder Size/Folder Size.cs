using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task5_Folder_Size
{
    public class task5_Folder_Size
    {
        public static void Main()
        {

            //var dir = Directory.GetFiles("TestFolder");
            //long sum = 0l;

            //foreach (var item in dir)
            //{
            //    var fileinfo = new FileInfo(item);
            //    sum += fileinfo.Length;
            //}
            //Console.WriteLine(sum/1024.0/1024.0);


            //същото решение
            var dir = Directory.GetFiles("TestFolder")
                .Select(f => new FileInfo(f))
                .Sum(n => n.Length / 1024.0 / 1024.0);

            Console.WriteLine(dir);

        }
    }
}
