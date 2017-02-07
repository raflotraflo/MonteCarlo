using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarlo
{
    public class ComboboxItem
    {
        public ComboboxItem(int v)
        {
            Value = v;
        }
        public string Text { get; set; }
        public int Value { get; set; }
        public override string ToString() { return Text ?? Value.ToString(); }
    }
}
