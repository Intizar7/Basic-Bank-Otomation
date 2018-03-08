using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public interface IQueue
    {
        void Insert(Kisi o);
        Kisi Remove();
        Kisi Peek();
        Boolean IsEmpty();
    }
}
