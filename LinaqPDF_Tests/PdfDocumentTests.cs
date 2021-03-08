using LinaqPDF;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaqPDF_Tests
{
    [TestClass]
    public class PdfDocumentTests
    {
        [TestMethod]
        public void SaveToFileTest()
        {
            PdfDocument doc = new PdfDocument();
            doc.SaveToFile("test.pdf");
        }
    }
}
