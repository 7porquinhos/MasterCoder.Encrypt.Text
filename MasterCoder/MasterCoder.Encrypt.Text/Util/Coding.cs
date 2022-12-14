using MasterCoder.Encrypt.Text.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MasterCoder.Encrypt.Text.Util
{
    internal abstract class Coding : Converter, ICoding, IDecoding, IEncoding
    {
        public String Decoding(string text)
        {
            if (text is null || text == string.Empty)
                throw new ArgumentNullException("Parameter cannot be null.");

            return Text(text);
        }
        public String Encoding(string text)
        {
            if (text is null || text == string.Empty)
                throw new ArgumentNullException("Parameter cannot be null.");

            return ASCII(text);
        }
        public bool IsEncrypt(string textEncoding)
        {
            if (textEncoding is null || textEncoding == string.Empty)
                throw new ArgumentNullException("Parameter cannot be null.");

            //Variaveis
            bool porcentagem = false;
            bool ponto = false;
            bool doisPontos = false;
            bool valid = false;
            int numberFake = 0;
            int numberTrue = 0;
            int numberChecker = 0;
            //Atribuindo Variaveis
            porcentagem = textEncoding.Contains("%");
            ponto = textEncoding.Contains(".");
            doisPontos = textEncoding.Contains(":");

            if (porcentagem && ponto && doisPontos)
            {
                foreach (var resultSplit in textEncoding.Split("%"))
                {
                    string resultEnd = resultSplit.Split(":")[0];

                    if (!string.IsNullOrEmpty(resultSplit))
                    {
                        numberChecker = Convert.ToInt32(resultSplit.Split(":")[1]);
                        numberFake = Convert.ToInt32(resultEnd.Substring(0, resultEnd.IndexOf(".")));
                        numberTrue = Convert.ToInt32(resultEnd.Substring(resultEnd.IndexOf(".") + 1));
                        if (numberTrue.ToString().Length != numberChecker)
                        {
                            return valid;
                        }
                    }
                }
                valid = true;
            }
            else
                valid = false;
            return valid;
        }
    }
}
