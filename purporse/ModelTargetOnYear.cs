using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace purporse
{
    class ModelTargetOnYear
    {
        public List<TargetOnYear> List  { get; set; }
        public DateTime Date = DateTime.Now;

        public void SaveTargetOnYear(PurporseOnYear purporseOnYear)
        {          
            List = purporseOnYear.List;

            if (List == null)
            {
                List = new List<TargetOnYear>();
            }

            using (StreamWriter sw = new StreamWriter($"TargetOnYear\\TargetOnYear{Date.Year}.json", false))
            {
                string l = JsonConvert.SerializeObject(List);
                sw.Write(l);
            }
        }

        public void Proverka(PurporseOnYear purporseOnYear)
        {   
            DirectoryInfo dirInfo = new DirectoryInfo("TargetOnYear");
            dirInfo.Create();
            if (File.Exists($"TargetOnYear\\TargetOnYear{Date.Year}.json"))
            {
                
                var reader = new StreamReader($"TargetOnYear\\TargetOnYear{Date.Year}.json");
                List = JsonConvert.DeserializeObject<List<TargetOnYear>>(reader.ReadToEnd());
                reader.Close();
                if (List == null) { }
                else { purporseOnYear.List = List; }
                
            }

            else
            {
                using (StreamWriter sw = new StreamWriter($"TargetOnYear\\TargetOnYear{Date.Year}.json", false)) ;
            }
        }

    }
}
