using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ООО_Ткани.Model;

namespace ООО_Ткани.ViewModel
{
    internal class AdminViewModel
    {
        public void PrintInfoFabric(DataGrid dataGrid)
        {



            List<string> lines = File.ReadAllLines("C://Users/white/Desktop/ООО Ткани/Source/fabrics.txt").ToList();
            List<Fabric> fabricList = new List<Fabric>();
            foreach (string line in lines)
            {

                string[] words1 = line.Split(',');
                fabricList.Add(new Fabric
                {
                    Name = words1[0],
                    Colour  = words1[1],
                    Type  = words1[2],
                    Length  = words1[3],
                    Price  = words1[4]
                });
            }
            dataGrid.ItemsSource = fabricList;


        }
    }
}
