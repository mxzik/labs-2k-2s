using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    sealed class CTextBox
    {
        public CTextBox()
        {
        }
        public CTextBox(string text)
        {
            Text = text;
        }

        public string Text { get; set; } = "";

        public override bool Equals(object obj)
        {
            CTextBox temp = obj as CTextBox;
            if (temp != null)
            {
                return temp.Text == this.Text;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Math.Abs(base.GetHashCode());

        }
        public override string ToString() => string.Format($"string: {Text}");
    }
}
