using System;
using System.Collections.Generic;

namespace purporse
{
    class Program
    {
        static void Main(string[] args)
        {
            PurporseMonght purporseMonght = new PurporseMonght();
            purporseMonght.List = new List<TargetMonght>();

            PurporseOnYear purporseOnYear = new PurporseOnYear();
            purporseOnYear.List = new List<TargetOnYear>();

            ModelTargetOnYear modelTargetOnYear = new ModelTargetOnYear();
            modelTargetOnYear.List = new List<TargetOnYear>();

            ModelTargetMonght modelTargetMonght = new ModelTargetMonght();
            modelTargetMonght.List = new List<TargetMonght>();

            modelTargetOnYear.Proverka(purporseOnYear);
            modelTargetMonght.Proverka(purporseMonght);

            Console.WriteLine("Органайзер by Studiovr v0.1");
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Мои Цели на год  \n2. Мои цели на текущий месяц  \n3. План на сегодняшний день  \n4. Заметки и идеи дня  " +
                    "\n5. Доска визуализации  \n6. Анализ недели  \n7. Списки   \n8. Выход");
                int changeMenu = Int32.Parse(Console.ReadLine());

                if (changeMenu == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("1. Cписок целей на год  \n2. Добавить цели  \n3. Цели предыдущего года  \n4. Поиск по годам \n5. Выход");
                        int changeTargetYear = Int32.Parse(Console.ReadLine());
                        if (changeTargetYear == 1)
                        {
                            purporseOnYear.TargetList();
                            
                        }

                        else if (changeTargetYear == 2)
                        {
                            purporseOnYear.AddTarget();
                            modelTargetOnYear.SaveTargetOnYear(purporseOnYear);
                        }

                        else if (changeTargetYear == 3)
                        {

                        }

                        else if (changeTargetYear == 4)
                        {

                        }

                        else
                        {
                            break;
                        }
                    }
                }

                else if (changeMenu == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("1. Cписок целей на текущий месяц  \n2. Добавить цели  \n3. Цели предыдущего месяца  \n4. Поиск по месяцам \n5. Выход");
                        int changeTargetMonth = Int32.Parse(Console.ReadLine());
                        if (changeTargetMonth == 1)
                        {
                            purporseMonght.TargetList();
                        }

                        else if (changeTargetMonth == 2)
                        {
                            purporseMonght.AddTarget();
                            modelTargetMonght.SaveTargetMonght( purporseMonght);
                        }

                        else if (changeTargetMonth == 3)
                        {

                        }

                        else if (changeTargetMonth == 4)
                        {

                        }

                        else
                        {
                            break;
                        }
                    }
                }

                else if (changeMenu == 3)
                {
                    while (true)
                    {
                        Console.WriteLine("1. Составить план  \n2. Посмотреть план  \n3. Архив  \n4. Изменить план \n5. Выход");
                        int changeSchedule = Int32.Parse(Console.ReadLine());
                        if (changeSchedule == 1)
                        {
                           
                        }

                        else if (changeSchedule == 2)
                        {
                       
                        }

                        else if (changeSchedule == 3)
                        {

                        }

                        else if (changeSchedule == 4)
                        {

                        }

                        else
                        {
                            break;
                        }
                    }
                }

                else if (changeMenu == 4)
                {

                }

                else if (changeMenu == 5)
                {

                }

                else if (changeMenu == 6)
                {

                }

                else if (changeMenu == 7)
                {

                }

                else
                {
                    break;
                }

            }
        }
        
    }
}
