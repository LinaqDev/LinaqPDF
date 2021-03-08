using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaqPDF
{
    public class PdfDocument
    {
        public void SaveToFile(string path)
        {
            File.WriteAllText(path,"test");
        }
    }
}
