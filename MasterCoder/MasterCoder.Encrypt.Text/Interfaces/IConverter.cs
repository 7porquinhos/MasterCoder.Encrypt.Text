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
        /// <summary>
        /// Converts input text to an ASCII string of characters.
        /// </summary>
        /// <param name="text">
        /// Input parameter to be converted.
        /// </param>
        /// <returns>
        /// Returns encrypted input text following library standards.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// This error occurs when the input parameter is null or empty.
        /// </exception>
        String ASCII(string text);
        /// <summary>
        /// Converts encrypted input text to a string.
        /// </summary>
        /// <param name="text">
        /// Input parameter to be converted.
        /// </param>
        /// <returns>
        /// Returns decrypted input text.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// This error occurs when the input parameter is null or empty.
        /// </exception>
        String Text(string text);
    }
}
