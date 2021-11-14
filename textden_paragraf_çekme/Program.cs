using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace textden_paragraf_çekme
{
    class Program
    {
        class Class1
        {
         
            public static string replace_text(string text)
            {
                text = text.Replace("ü", "u").Replace("&#246;", "ö").Replace("&#231;", "ç").Replace("&#220;", "Ü").Replace("&#199;", "Ç").Replace("&#214;", "Ö").Replace("&#351;", "ş").Replace("&#350;", "Ş").Replace("&#304;", "İ").Replace("&#305;", "i").Replace("&#287;", "ğ").Replace("&#286;", "Ğ").Replace("&amp;", "&");

                Console.WriteLine("text replaced is {0}", text);
                return text;
            }
               static void Main(string[] args)
            {
                StreamReader objReader = new StreamReader("C:/Users/Fatih/Desktop/ornek.txt");
                string sLine = "";
                ArrayList arrText = new ArrayList();

                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                        arrText.Add(replace_text(sLine));
                }
                objReader.Close();

                foreach (string sOutput in arrText)
                    Console.WriteLine(sOutput);
                Console.ReadLine();
            }
        }
    }
}
            
        
    
