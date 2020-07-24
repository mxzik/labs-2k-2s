using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    interface IFile
    {
        void ToFile();
        void DeleteFile();
    }

    class TextBox : IComparable<TextBox>, IFile
    {
        public TextBox()
        {
        }
        public TextBox(string text)
        {
            Text = text;
        }

        public string Text { get; set; } = "";

        public override bool Equals(object obj)
        {
            TextBox temp = obj as TextBox;
            if (temp != null)
            {
                return temp.Text == this.Text;
            }
            return false;
        }

        public int CompareTo(TextBox other)
        {
            if (this.Text == other.Text)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public override int GetHashCode()
        {
            return Math.Abs(base.GetHashCode());

        }
        public override string ToString() => string.Format($"string: {Text}");
        public void ToFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + @"/Info.txt", true))
                {
                    sw.WriteLine($"{Text}");
                    sw.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DeleteFile()
        {
            try
            {
                File.Delete(Directory.GetCurrentDirectory() + @"/Info.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
