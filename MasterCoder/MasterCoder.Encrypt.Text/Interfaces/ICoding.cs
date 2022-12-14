using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCoder.Encrypt.Text.Interfaces
{
    public interface ICoding
    {
        /// <summary>
        /// Checks if encoding is true.
        /// </summary>
        /// <param name="text">
        /// The string to verification.
        /// </param>
        /// <returns>
        /// Returns true if the input text is a valid library encryption.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// This error occurs when the input parameter is null or empty.
        /// </exception>
        bool IsEncrypt(string textEncoding);
    }
}
