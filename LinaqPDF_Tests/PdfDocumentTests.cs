using LinaqPDF;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
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
            Assert.IsTrue(File.Exists("test.pdf"));
        }

        [TestMethod]
        public void SaveToFileTestEmptyPath()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                PdfDocument doc = new PdfDocument();
                doc.SaveToFile("");
            });
        }

        [TestMethod]
        public void SaveToFileTestNullPath()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                PdfDocument doc = new PdfDocument();
                doc.SaveToFile(null);
            });
        }
    }
}
