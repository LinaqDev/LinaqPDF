using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaqPDF
{
    public class PdfDocument : IDisposable
    {
        public PdfDocument()
        {
            Pages = new List<Page>();
        }

        public List<Page> Pages { get; private set; }

        public Page AddNewPage()
        {
            Page p = new Page();
            Pages.Add(p);
            return p;
        }

        public void RemovePage(Page page)
        {
            Pages.Remove(Pages.FirstOrDefault(x => x.Id == page.Id));
            page.Dispose();
        }

        private async void GenerateAndSaveContent(string path)
        { 
            using (StreamWriter file = new StreamWriter(path, append: true))
            {
                await file.WriteLineAsync("Test line");
            }
        }

        public void SaveToFile(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Path can not be empty.", nameof(path));

            if (File.Exists(path))
                path = Helpers.GetUniqueFilePath(path);

            GenerateAndSaveContent(path);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            GC.Collect();
        }
    }
}
