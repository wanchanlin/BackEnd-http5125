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
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost(template:"ProcessString")]
        public string ProcessString([FromQuery] string input)
        {
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            StringBuilder resultString = new StringBuilder();

            // Convert the input into a character array
            char[] inpArray = input.ToCharArray();

            // Create a new StringBuilder to handle modifications
            StringBuilder inpBuilder = new StringBuilder(new string(inpArray));

            for (int i = 1; i < inpBuilder.Length; i++) // Start from index 1 to avoid out-of-bounds in i-1
            {
                if (letters.Contains(inpBuilder[i]))
                {
                    if (numbers.Contains(inpBuilder[i - 1]))
                    {
                        inpBuilder.Insert(i, '*');
                        i++; // Increment to skip over inserted '*' to avoid endless loop
                    }
                }
            }

            // Remove the first character (like inp.pop(0) in Python)
            if (inpBuilder.Length > 0)
                inpBuilder.Remove(0, 1);

            // Append the remaining characters to resultString
            resultString.Append(inpBuilder.ToString());

            // Replace strings according to Python logic
            resultString.Replace("*+", " tighten ");
            resultString.Replace("*-", " loosen ");
            resultString.Replace("*", "\n");

            // Return the final processed string
            return resultString.ToString();
        }

    }
}
