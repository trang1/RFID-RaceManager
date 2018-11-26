using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace RaceManager.UI
{
    public class JsonHelper
    {
        public static string Serialize(object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            return json;
        }

        public static void SaveToFile(object obj, string path)
        {
            try
            {
                var text = Serialize(obj);
                File.WriteAllText(path, text);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message+e.StackTrace);
            }
        }
    }
}
