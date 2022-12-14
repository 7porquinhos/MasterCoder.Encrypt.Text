using MasterCoder.Encrypt.Text.Interfaces;
using MasterCoder.Encrypt.Text.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCoder.Encrypt.Text
{
    public sealed class Encrypt
    {
        //Propriedades
        public ICoder Coder { get; set; }
        //Construtores
        public Encrypt() => Coder = new Coder();
    }
}
