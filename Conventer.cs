using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Conventer
{
    internal class Conventer
    {

        public void Conventiryem(string fileToPath)
        {
            bool IsDone = true;
            

            string[] strokastrochenyka = File.ReadAllLines(fileToPath);
            List<Figura> figyri = new List<Figura>();

           

            /* for (int i = 0; i < strokastrochenyka.Length; i += 3)
             {
                 Figura figure = new Figura
                 {
                     Name = strokastrochenyka[i],
                     Weight = strokastrochenyka[i + 1],
                     Height = strokastrochenyka[i + 2]
                 };

                 figyri.Add(figure);
             }*/

            Console.Clear();
            Console.WriteLine("Содержание файла:");
            Console.WriteLine("------------------------------------------------------------------");
            foreach (var stroka in strokastrochenyka)
            {
                Console.WriteLine(stroka);
            }
            /*foreach (Figura figure in figyri)
            {
                Console.WriteLine($"Название: {figure.Name}, Высота: {figure.Height}, Ширина: {figure.Weight}");
            }*/
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Введите в какой формат нужно перезаписать \'json\'\'xml\'\'txt\'");
            Console.WriteLine("------------------------------------------------------------------");
            string choiseFormat = Console.ReadLine();

            if (choiseFormat.ToLower() == "json")
            {
                JsonConventer(figyri);
            }

            if (choiseFormat == "xml")
            {
                XmlConventer(figyri);
            }
        }
        private void JsonConventer(List<Figura> figyri)
        {
            Console.Clear();
            string newJsonFile = JsonConvert.SerializeObject(figyri);
            Console.WriteLine("Введите новый путь файла(на конце нужно написать расширение\'.json\'");
            Console.WriteLine("------------------------------------------------------------------");
            string NewPathJson = Console.ReadLine();
            File.WriteAllText(NewPathJson, newJsonFile);
        }

        private void XmlConventer(List<Figura> figyri)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Figura));
            Console.WriteLine("Введите новый путь файла(на конце нужно написать расширение\'.xml\'");
            Console.WriteLine("------------------------------------------------------------------");
            string NewPathXml = Console.ReadLine();
            using (FileStream PathXml = new FileStream(NewPathXml, FileMode.OpenOrCreate))
            {
                xml.Serialize(PathXml, figyri);
            }
        }

       /* private void TxtConventer(List<Figura> figyri)
        {
            string NewPathTxt = Console.ReadLine();
            File.WriteAllText(NewPathTxt, );
        }*/

    }
}
