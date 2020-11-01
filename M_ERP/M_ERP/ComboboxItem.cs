using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_ERP
{
    public class ComboboxItem
    {
        public string Text { get; set; }
        public Int32 Value { get; set; }

        public override string ToString()
        {
            return Text;
        }

        public ComboboxItem(String Text, Int32 ID) {
            this.Text = Text;
            this.Value = ID;
        }
    }
}
