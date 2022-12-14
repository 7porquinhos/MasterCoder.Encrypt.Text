using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCoder.Encrypt.Text.Interfaces
{
    public interface IEncoding
    {
        /// <summary>
        /// Encode the input text.
        /// </summary>
        /// <param name="text">
        /// The string to encoding.
        /// </param>
        /// <returns>
        /// Returns encrypted input text following library standards.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// This error occurs when the input parameter is null or empty.
        /// </exception>
        String Encoding(string text);
    }
}
