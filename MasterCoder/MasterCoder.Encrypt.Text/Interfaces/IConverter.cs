using MasterCoder.Encrypt.Text.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCoder.Encrypt.Text.Interfaces
{
    public interface IConverter
    {
        String ASCII(string text);
        String Text(string text);
    }
}
