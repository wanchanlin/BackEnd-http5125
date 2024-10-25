using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Assigment2_N01712482.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J3Controller : ControllerBase
    {
        ///<summary>
        /// Processes the input string to insert specific markers and replace symbols.
        /// GET:J3/ProcessString
        /// </summary>
        /// <remarks>
        /// This method processes a given string based on a few specific rules:
        /// 1. It inserts a '*' character whenever a letter follows a number in the string.
        /// 2. It replaces certain symbols:
        ///     - A '+' is replaced with the word "tighten".
        ///     - A '-' is replaced with the word "loosen".
        ///     - A '*' is replaced with a newline character ('\n').
        /// The method uses a `StringBuilder` to efficiently handle string modifications and returns the processed result as a string. 
        /// This function could be useful for formatting commands or processing input where the relationship between letters and numbers, as well as specific symbols, needs to be expressed in a human-readable format.
        /// The logic is based on the Canadian Computing Competition Junior 2022 problem set.
        /// </remarks>
        /// <param name="input">The input string to be processed, containing letters, numbers, and symbols.</param>
        /// <returns>
        /// A processed string with '*' inserted between numbers and letters, specific symbols replaced, and formatted for readability.
        /// </returns>

        [HttpGet(template: "ProcessString")]
        public string ProcessString([FromQuery] string input)
        {
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            StringBuilder resultString = new StringBuilder();

            char[] inpArray = input.ToCharArray();
            StringBuilder inpBuilder = new StringBuilder(new string(inpArray));

            for (int i = 1; i < inpBuilder.Length; i++)
            {
                if (letters.Contains(inpBuilder[i]) && numbers.Contains(inpBuilder[i - 1]))
                {
                    inpBuilder.Insert(i, '*');
                    i++; 
                }
            }

         

            // Process the string: replace specific symbols
            resultString.Append(inpBuilder.ToString())

                        .Replace("+", " tighten ")
                        .Replace("-", " loosen ")
                        .Replace("*", "\n");

            // Return the final processed string
            return resultString.ToString();
        }
    }

}
