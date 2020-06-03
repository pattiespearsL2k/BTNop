using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNop
{
    class CBBItem
    {
        private int _Val;
        private string _Text;

        public int Val { get => _Val; set => _Val = value; }
        public string Text { get => _Text; set => _Text = value; }


        public override string ToString()
        {
            return Text;
        }
    }
}

