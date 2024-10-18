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
        /// https://cemc.uwaterloo.ca/sites/default/files/documents/2022/2022CCCJrProblemSet.html
        /// to  seperate the tring got  
        /// </summary>

        /// Convert the input into a character array
        /// Create a new StringBuilder to handle modifications
        //// Start from index 1 to avoid out-of-bounds in i-1
        /// <returns></returns>
        [HttpGet(template: "ProcessString")]
        public string ProcessString([FromQuery] string input)
        {
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            StringBuilder resultString = new StringBuilder();

            char[] inpArray = input.ToCharArray();
            StringBuilder inpBuilder = new StringBuilder(new string(inpArray));

            // Insert '*' when a letter follows a number
            for (int i = 1; i < inpBuilder.Length; i++)
            {
                if (letters.Contains(inpBuilder[i]) && numbers.Contains(inpBuilder[i - 1]))
                {
                    inpBuilder.Insert(i, '*');
                    i++; // Skip over the inserted '*' to avoid an infinite loop
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
