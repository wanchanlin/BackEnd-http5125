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
        /// https://cemc.uwaterloo.ca/sites/default/files/documents/2022/2022CCCJrProblemSet.html
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>ll([FromQuery] string input)

        [HttpGet(template: "Fergusonball")]
        public string Fergusonball([FromQuery] string input)
        {
            // Validate the input before parsing
            if (string.IsNullOrEmpty(input))
            {
                return "Invalid input: No data provided.";
            }

            // Split the input string into an array of integers, handle potential parsing errors
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

            // The first value should be the number of players
            int numberOfPlayers = inputData[0];

            // Check if the input length is as expected
            if (inputData.Length != 1 + (2 * numberOfPlayers))
            {
                return "Invalid input: The number of points and fouls does not match the number of players.";
            }

            int cnt = 0; // Counter for players above the threshold
            bool allAboveThreshold = true; // Track if all players are above the threshold
            const int threshold = 40; // Define the threshold (could also be a parameter)

            // Iterate through the points and fouls for each player
            for (int i = 0; i < numberOfPlayers; i++)
            {
                // Points and fouls are interleaved starting from index 1
                int playerPoints = inputData[2 * i + 1];  // Points for player `i`
                int playerFouls = inputData[2 * i + 2];   // Fouls for player `i`

                // StarRating calculation
                int starRating = (5 * playerPoints) - (3 * playerFouls);

                // Check if the starRating exceeds the threshold
                if (starRating > threshold)
                {
                    cnt++; // Increment count if above threshold
                }
                else
                {
                    allAboveThreshold = false; // If any player is below the threshold
                }
            }

            // Return the count of players above the threshold and '+' if all players exceed it
            return cnt.ToString() + (allAboveThreshold ? "+" : "");
        }







    }
}
