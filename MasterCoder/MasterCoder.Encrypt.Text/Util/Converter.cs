using MasterCoder.Encrypt.Text.Entities;
using MasterCoder.Encrypt.Text.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCoder.Encrypt.Text.Util
{
    internal abstract class Converter : IConverter
    {
        public string ASCII(string text)
        {
            //Variaveis
            var sb = new StringBuilder();
            string textEncrypt = string.Empty;
            int countNumber = 0;
            int unicode = 0;
            //Loop para realizar a encriptação de cada caracter.
            foreach (char c in text)
            {
                unicode = c;
                countNumber = unicode.ToString().Length;

                if (unicode >= 0 && unicode <= 255)
                {
                    if (text.Length % 2 == 0)
                    {
                        if (unicode == 255)
                            sb.Append($"{unicode}:{countNumber}");
                        else
                            sb.Append($"{unicode + 1}.{unicode}:{countNumber}");

                    }
                    else
                    {
                        if (unicode == 0)
                            sb.Append($"{unicode}:{countNumber}");
                        else
                            sb.Append($"{unicode - 1}.{unicode}:{countNumber}");
                    }
                }
                else
                {
                    return "Text no Convert";
                }
                sb.Append("%");
            }
            textEncrypt = sb.ToString();
            return textEncrypt;
        }
        public string Text(string text)
        {
            //Variaveis
            var sb = new StringBuilder();
            //Loop usado para fazer a Descriptação de cada caracter ASCII.
            foreach (var porcentagemSplit in text.Split("%"))
            {
                string pontoSplit = porcentagemSplit.Split(":")[0];

                string result = pontoSplit.Substring(pontoSplit.IndexOf('.') + 1);
                if (!string.IsNullOrEmpty(result))
                {
                    char character = System.Convert.ToChar(Convert.ToUInt64(result));
                    sb.Append(character);
                }

            }
            return sb.ToString();
        }
    }
}
