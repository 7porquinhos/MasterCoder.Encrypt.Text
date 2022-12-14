using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasterCoder.Encrypt.Text.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCoder.Encrypt.Text.Util.Tests
{
    [TestClass()]
    public class EncryptUtilTests
    {
        Encrypt obj = new Encrypt();

        [TestMethod()]
        public void DecodingTest()
        {
            string decodificada = obj.Coder.Decoding("68.69:2%107.108:3%104.105:3%100.101:3%107.108:3%31.32:2%79.80:2%100.101:3%113.114:3%100.101:3%104.105:3%113.114:3%96.97:2%31.32:2%64.65:2%107.108:3%108.109:3%100.101:3%104.105:3%99.100:3%96.97:2%");
            Assert.IsTrue(!string.IsNullOrEmpty(decodificada));
        }

        [TestMethod()]
        public void EncodingTest()
        {
            string codificada = obj.Coder.Encoding("Teste de UNIT");
            Assert.IsTrue(!string.IsNullOrEmpty(codificada));
        }

        [TestMethod()]
        public void IsEncryptTest()
        {
            bool encodingValido = obj.Coder.IsEncrypt("68.69:2%107.108:3%104.105:3%100.101:3%107.108:3%31.32:2%79.80:2%100.101:3%113.114:3%100.101:3%104.105:3%113.114:3%96.97:2%31.32:2%64.65:2%107.108:3%108.109:3%100.101:3%104.105:3%99.100:3%96.97:2%");

            Assert.IsTrue(encodingValido);
        }
    }
}