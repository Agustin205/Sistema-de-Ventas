using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class BEFormControl
    {
        public BEFormControl(BEForm pForm, BEControl pControl)
        {
            Form = pForm;
            Control = pControl;
        }
        public BEForm Form { get; set; }
        public BEControl Control { get; set; }
    }
}
