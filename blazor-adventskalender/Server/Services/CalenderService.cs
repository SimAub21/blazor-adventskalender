using System;
using blazor_adventskalender.Shared.Models;

namespace blazor_adventskalender.Server.Services
{
    internal class CalenderService
    {
        /// <summary>
        /// Check if the day of the current door is already reached
        /// </summary>
        /// <param name="oneDoor"></param>
        /// <returns>true if the day is already reached</returns>
        internal bool CheckIfUnlocked(OneDoorModel oneDoor)
        {
            return oneDoor.Date > DateTime.Now;
        }
    }
}
