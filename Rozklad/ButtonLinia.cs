using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Rozklad
{
    class ButtonLinia : Label
    {
        public gtf.Routes linia= new gtf.Routes();
        public string i;
        public gtf.Stops przystanek;
    }
}
