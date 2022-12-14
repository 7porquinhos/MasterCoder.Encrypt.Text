using MasterCoder.Encrypt.Text.Entities;
using MasterCoder.Encrypt.Text.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MasterCoder.Encrypt.Text.Util
{
    public class EncryptUtil : ICoder
    {
        public String Decoding(string text)
        {
            if (text is null || text == string.Empty )
                throw new ArgumentNullException("Parameter cannot be null.");

            Converter converter = new Converter();
            return converter.Text(text);
        }

        public String Encoding(string text)
        {
            if (text is null || text == string.Empty)
                throw new ArgumentNullException("Parameter cannot be null.");


            //Step 1: Converte texto para caracteres ASCII.
            Converter converter = new Converter();
            return converter.ASCII(text);
        }

        public bool IsEncrypt(string textEncoding)
        {
            if (textEncoding is null || textEncoding == string.Empty)
                throw new ArgumentNullException("Parameter cannot be null.");

            Coding coding = new Coding();
            return coding.IsEncrypt(textEncoding);
        }
    }
}
