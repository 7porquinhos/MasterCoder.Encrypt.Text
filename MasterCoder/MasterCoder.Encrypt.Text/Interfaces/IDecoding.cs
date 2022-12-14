using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCoder.Encrypt.Text.Interfaces
{
    public interface IDecoding
    {
        /// <summary>
        /// Decoding the input text.
        /// </summary>
        /// <param name="text">
        /// The string to decoding.
        /// </param>
        /// <returns>
        /// Returns decrypted input text.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// This error occurs when the input parameter is null or empty.
        /// </exception>
        String Decoding(string text);
    }
}
