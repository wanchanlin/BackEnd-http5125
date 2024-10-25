using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace Assigment2_N01712482.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class J2_2022Controller : ControllerBase
    {

        /// <summary>
        /// GET:J2-2022/Fergusonball
        /// https://cemc.uwaterloo.ca/sites/default/files/documents/2022/2022CCCJrProblemSet.html
        /// Calculates the number of players whose performance exceeds a defined threshold based on their points and fouls.
        /// </summary>
        /// <remarks>
        /// This method processes a space- or comma-separated string of integers representing the number of players, followed by pairs of points and fouls for each player.
        /// 
        /// The player's performance is evaluated using the following formula to calculate their star rating:
        /// - StarRating = (5 * points) - (3 * fouls)
        /// 
        /// The method checks how many players have a star rating above a predefined threshold of 40.
        /// - If all players exceed the threshold, the result includes a '+' symbol.
        /// - If any player fails to exceed the threshold, only the count of players above the threshold is returned.
        /// 
        /// The input string must follow this format:
        /// 1. The first value represents the number of players.
        /// 2. The subsequent values alternate between points and fouls for each player.
        /// The method validates the input to ensure it matches the expected format, returning an error message for invalid input.
        /// </remarks>
        /// <param name="input">A space- or comma-separated string of integers representing the number of players and their corresponding points and fouls.</param>
        /// <returns>
        /// A string representing the number of players whose star rating exceeds the threshold, with a '+' if all players exceed it. Returns error messages for invalid input.
        /// </returns>

        [HttpGet(template: "Fergusonball")]
        public string Fergusonball([FromQuery] string input)
        {
            // Validate the input before parsing
            if (string.IsNullOrEmpty(input))
            {
                return "Invalid input: No data provided.";
            }

            int[] inputData;
            try
            {
                inputData = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
            }
            catch (FormatException)
            {
                return "Invalid input: Please ensure all input values are integers.";
            }

           
            int numberOfPlayers = inputData[0];

            if (inputData.Length != 1 + (2 * numberOfPlayers))
            {
                return "Invalid input: The number of points and fouls does not match the number of players.";
            }

            int cnt = 0;
            bool allAboveThreshold = true; 
            const int threshold = 40; 

           
            for (int i = 0; i < numberOfPlayers; i++)
            {
                int playerPoints = inputData[2 * i + 1];  
                int playerFouls = inputData[2 * i + 2];  

                int starRating = (5 * playerPoints) - (3 * playerFouls);

                if (starRating > threshold)
                {
                    cnt++;
                }
                else
                {
                    allAboveThreshold = false; 
                }
        
            return cnt.ToString() + (allAboveThreshold ? "+" : "");
        }

    }
}
