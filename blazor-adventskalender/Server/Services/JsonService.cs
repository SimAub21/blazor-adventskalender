using blazor_adventskalender.Client.Components;
using blazor_adventskalender.Shared.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;


namespace blazor_adventskalender.Server.Services
{
    public class JsonService
    {
        public OneDoorModel oneDoor = new();

        List<OneDoorModel> doorList = new List<OneDoorModel>();

        internal void ReadIn()
        {
            string s;
            using (StreamReader sr = new StreamReader(@"C:\Users\kaisers\Desktop\days.json"))
            {
                s = sr.ReadLine();
            }

            oneDoor = JsonConvert.DeserializeObject<OneDoorModel>(s);
            doorList.Add(oneDoor);

        }

    }
}
