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
            string FileName = "test.pdf";
            PdfDocument doc = new PdfDocument();
            doc.SaveToFile(FileName);
            Assert.IsTrue(File.Exists(FileName));
            File.Delete(FileName);
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

        [TestMethod]
        public void AddNewPageTest()
        {
            PdfDocument doc = new PdfDocument();
            var p = doc.AddNewPage();
            Assert.IsNotNull(p);
            Assert.AreEqual<int>(doc.Pages.Count, 1);
        }

        [TestMethod]
        public void RemovePageTest()
        {
            PdfDocument doc = new PdfDocument();
            var p = doc.AddNewPage();
            doc.RemovePage(p); 
            Assert.AreEqual<int>(doc.Pages.Count, 0);
        }
    }
}
