using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace SteganographyExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			while (true)
			{
				string caset = Console.ReadLine();
				switch(caset){
					case "h":{
							var bit = new Bitmap(Console.ReadLine());
                            string textLoc = Console.ReadLine();
							string imName = Console.ReadLine();
                            
							var em = Steganography.SteganographyHelper.embedText(File.ReadAllText(textLoc), bit);
                            
							em.Save(imName, ImageFormat.Jpeg);
							break;
						}
					case "e":{
							string file = Console.ReadLine();

							Console.WriteLine(Steganography.SteganographyHelper.extractText(new Bitmap(file)));
							break;
						}
				}


			}
        }
    }
}
