using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class MyString
    {
        private string value;

        public MyString(string value)
        {
            this.value = value;
        }

        public string Concatenate(MyString other)
        {
            return value + other.value;
        }

        public int FindSubstring(string substring)
        {
            int i;
            for (i = 0; i <= value.Length - substring.Length; i++)
            {
                bool found = true;
                int j;
                for (j = 0; j < substring.Length; j++)
                {
                    if (value[i + j] != substring[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    return i;
                }
            }
            return -1;
        }

        public string ReplaceSubstring(string oldSubstring, string newSubstring)
        {
            int pos = FindSubstring(oldSubstring);
            if (pos == -1)
            {
                return value;
            }
            string result = "";
            result = result + value.Substring(0, pos) + newSubstring + value.Substring(pos + oldSubstring.Length);
            return result;
        }

        public string GetValue()
        {
            return value;
        }
    }
}
