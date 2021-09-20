using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AimlabDataManager.Controller
{
    class MainController
    {
        public string search = Utils.GetTasksJsonFromFile();
        
       
    
        public string selectedTask;
        public string last100;
        public string deviation;
        public string showAvg;
        public string showRecord;

        public MainController( string selecedTask,  string last100, 
             string deviation,  string showAvg,  string showRecord)
        {
       
            this.last100 = last100;
            this.deviation = deviation;
            this.showAvg = showAvg;
            this.showRecord = showRecord;
            Console.WriteLine("constructor ok");
           
        }
        public void sarasa()
        {
            Utils.DeserializaJsonFile(search);
        }
        public string getLasts100(string search)
        {
            JsonTextReader reader = new JsonTextReader(new StringReader(search));



            return null;

        }


    }
}
