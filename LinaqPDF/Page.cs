using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinaqPDF
{
    public class Page : IDisposable
    {
        internal string Id;
        public Page()
        {
            Id = Guid.NewGuid().ToString();
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
            GC.Collect();
        }
    }
}
