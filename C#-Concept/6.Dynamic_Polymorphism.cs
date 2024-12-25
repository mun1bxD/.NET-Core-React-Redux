using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace Dynamic_Polymorphism002
{
    public abstract class Files
    {
        public string Filename { get; set; }
        public string Filetype { get; set; }

        public Files(string filename)
        {
            Filename = filename;
        }

        public abstract void Open();
        public void Close(string Filename)
        {
            Console.WriteLine(Filename + " close");
        }
    }
    public class TextFile:Files
    {
        public TextFile(string filename) : base(filename) 
        {
            Filetype = "text";
        }

        public override void Open()
        {
            string content=File.ReadAllText(Filename);
            Console.Write(content);
        }

    }
    public class ImageFile : Files
    {
        public ImageFile(string filename) : base(filename)
        {
            Filetype = "image";
        }
        public override void Open()
        {
            Process.Start(new ProcessStartInfo(Filename) { UseShellExecute = true });
        }
    }

    public class VideoFile : Files
    {
        public VideoFile(string filename) : base(filename)
        {
            Filetype = "video";
        }
        public override void Open()
        {
            Process.Start(new ProcessStartInfo(Filename) { UseShellExecute = true });
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            TextFile textFile =new TextFile("C:\\Users\\hp\\Desktop\\New Text Document.txt");

            textFile.Open();

            ImageFile imageFile=new ImageFile("C:\\Users\\hp\\Desktop\\mr.robot.jpg");
            imageFile.Open();
            
            VideoFile videoFile=new VideoFile("C:\\Users\\hp\\Desktop\\Video_2024-08-24_200758.wmv");
            videoFile.Open();
            Console.ReadKey();

        }
    }
}
