using System;
using System.Collections.Generic;
using System.Text;

namespace purporse
{
    public class PurporseMonght
    {
        public List<TargetMonght> List { get; set; }
        public void AddTarget()
        {
            Console.Write("Введите Цель:");
            string name = Console.ReadLine();
            Console.Write("Введите Результат выполнения цели:");
            string result = Console.ReadLine();
            Console.Write("Введите измеримость, в чем измеряется достижение цели:");
            string measurable = Console.ReadLine();
            Console.Write("Сколько времени потребуется на выполнение цели:");
            int takesTime = Int32.Parse(Console.ReadLine());
            Console.Write("Сколько денег необхожимо для достижения цели:");
            int needMoney = Int32.Parse(Console.ReadLine());
            Console.Write("Введите насколько значима для вас цель от 1 до 10:");
            int relevant = Int32.Parse(Console.ReadLine());
            Console.Write("Введите Дедлайн для цели:");
            DateTime deedline = DateTime.Parse(Console.ReadLine());

            List.Add(new TargetMonght
            {
                Id = List.Count + 1,
                Name = name,
                Result = result,
                Measurable = measurable,
                TakesTime = takesTime,
                NeedMoney = needMoney,
                Relevant = relevant,
                Deedline = deedline,


            });
        }
        public void TargetList()
        {
            if (List == null)
            {
                Console.WriteLine("У вас пока нет целей.");
            }
            else
            {
                foreach (var i in List)
                {
                    Console.WriteLine(i.Name);
                    Console.WriteLine(i.Result);
                    Console.WriteLine(i.Measurable);
                    Console.WriteLine(i.TakesTime);
                    Console.WriteLine(i.NeedMoney);
                    Console.WriteLine(i.Relevant);
                    Console.WriteLine(i.Deedline);
                }
            }
        }
    }
    public class TargetMonght
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Result { get; set; }
        public string Measurable { get; set; }
        public int TakesTime { get; set; }
        public int NeedMoney { get; set; }
        public int Relevant { get; set; }
        public DateTime Deedline { get; set; }

        public TargetMonght()
        {
            Id = 1;
            Name = string.Empty;
            Result = string.Empty;
            Measurable = string.Empty;
            TakesTime = 0;
            NeedMoney = 0;
            Relevant = 0;
            Deedline = DateTime.Now;
        }
    }
}
