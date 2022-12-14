using MasterCoder.Encrypt.Text.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCoder.Encrypt.Text.Util
{
    public class Coding : ICoding
    {
        public bool IsEncrypt(string textEncoding)
        {
            //Variaveis
            bool porcentagem = false;
            bool ponto = false;
            bool doisPontos = false;
            int numberFake = 0;
            int numberTrue = 0;
            int numberChecker = 0;
            var sb = new StringBuilder();
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
                        if (numberTrue.ToString().Length == numberChecker)
                            sb.Append(true);
                        else
                            sb.Append(false);
                    }
                }
            }
            bool valid = !sb.ToString().Contains("False");
            return valid;
        }
    }
}
