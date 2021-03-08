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

        }

        public List<Page> Pages { get; set; }

        private async void GenerateAndSaveContent(string path)
        {
            await Task.Run(() =>
            {
                using (StreamWriter file = new StreamWriter(path, append: true))
                {
                    file.WriteLineAsync("Test line");
                }
            });
        }

        public void SaveToFile(string path)
        {
            if (string.IsNullOrWhiteSpace(path))
                throw new ArgumentException("Path can not be empty.", nameof(path));

            if (File.Exists(path))
                File.Delete(path);

            GenerateAndSaveContent(path);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            GC.Collect();
        }
    }
}
