using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ООО_Ткани.Model;

namespace ООО_Ткани.ViewModel
{
    internal class PersonViewModel
    {
        public void OrderInFabric(ComboBox comboBox)
        {
            //List<string> lines = File.ReadAllLines("C://Users/white/Desktop/ООО Ткани/Source/fabrics.txt").ToList();

            //foreach (string line in lines)
            //{
            //StreamReader st = new StreamReader("C://Users/white/Desktop/ООО Ткани/Source/fabrics.txt");
            //string[] words1;

            //while (!st.EndOfStream)
            //{
            //    string line = st.ReadLine();
            //    words1 = line.Split(',');


            //    List<Fabric> fabricList = new List<Fabric>
            //{
            //        new Fabric{Name = words1[0],
            //        Colour = words1[1],
            //        Type = words1[2], }

            //    };
            //    //}
            //    comboBox.ItemsSource = fabricList;

            //}

            List<Fabric> fabricList = new List<Fabric>();
            using (StreamReader reader = new StreamReader("C://Users/white/Desktop/ООО Ткани/Source/fabrics.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    fabricList.Add(new Fabric
                    {
                        Name = parts[0],
                        Colour = parts[1],
                        Type = parts[2],                        
                    });
                }
            }
            comboBox.ItemsSource = fabricList;
            comboBox.DisplayMemberPath = "Name";
             
        }
    }
}
