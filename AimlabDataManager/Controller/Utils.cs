using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimlabDataManager.Controller
{
    class Utils
    {
        private static string _path = @"E:\unity\AimlabDataManager\Data\aimlab.json";
        public static string GetTasksJsonFromFile()
        {
           
            string tasks;
            using (var reader = new StreamReader(_path))
            {
                tasks = reader.ReadToEnd();
            }

            return tasks;
        }

        public static void DeserializaJsonFile(string tasksFromJsonFile)
        {
            var tasks = JsonConvert.DeserializeObject<List<Task>>(tasksFromJsonFile);

        }

        //public static void JsonReader(string tasksFromJsonFile)
        //{
           
        //    JsonTextReader reader = new JsonTextReader(new StringReader(tasksFromJsonFile));

            

        //}
    }
}
