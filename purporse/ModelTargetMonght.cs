using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace purporse
{
    class ModelTargetMonght
    {
        public List<TargetMonght> List { get; set; }
        public DateTime Date = DateTime.Now;

        public void SaveTargetMonght(PurporseMonght purporseMonght)
        {
            List = purporseMonght.List;

            if (List == null)
            {
                List = new List<TargetMonght>();
            }

            using (StreamWriter sw = new StreamWriter($"TargetMonght\\TargetMonght{Date.Month}.json", false))
            {
                string l = JsonConvert.SerializeObject(List);
                sw.Write(l);
            }
        }

        public void Proverka(PurporseMonght purporseMonght)
        {
            DirectoryInfo dirInfo = new DirectoryInfo("TargetMonght");
            dirInfo.Create();
            if (File.Exists($"TargetMonght\\TargetMonght{Date.Month}.json"))
            {

                var reader = new StreamReader($"TargetMonght\\TargetMonght{Date.Month}.json");
                List = JsonConvert.DeserializeObject<List<TargetMonght>>(reader.ReadToEnd());
                reader.Close();
                if (List == null) { }
                else { purporseMonght.List = List; }

            }

            else
            {
                using (StreamWriter sw = new StreamWriter($"TargetMonght\\TargetMonght{Date.Month}.json", false)) ;
            }
        }

    }
}
