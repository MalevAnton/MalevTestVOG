using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalevTest
{
    public class Calculation
    {
        static void Main(string[] args) // я разработал WPF
        {
        }

        public int GetTicketForAge(int productType, int ticketType, int age)
        {
            int res = 0; // результат

            float human = age; // сколько человеку лет

            float promres = 0;

            if (res < 0) // если результат меньше нуля, то будет ошибка
            {
                return -1;
            }

            switch (productType)
            {
                case 1: // Взнос членского билета для нижегородцев
                    {
                        switch (ticketType) // билет
                        {
                            case 1: // для человека, которому старше 18 лет
                                {
                                    if (age >= 18) // если больше 18, то 150 руб
                                    {
                                        promres = 150; // 150 рублей - для тех, кто старше 18 лет

                                        res = (int) Math.Ceiling(promres); // считывание результата
                                    }

                                    return res;
                                }

                            case 2: // для человека, которому старше 30 лет
                                {
                                    if (age >= 30) // если больше 30, то 100 руб
                                    {
                                        promres = 100; // 100 рублей - для тех, кто старше 30 лет.

                                        res = (int)Math.Ceiling(promres); // считывание результата
                                    }

                                    return res;
                                }

                            case 3: // для человека, которому старше 50 лет
                                {
                                    if (age >= 50) // если больше 50, то 50 руб
                                    {
                                        promres = 50; // 50 рублей - для тех, кто старше 50 лет.

                                        res = (int)Math.Ceiling(promres); // считывание результата
                                    }

                                    return res;
                                }

                            default:
                                {
                                    return -1;
                                }
                        }
                    }

                case 2: // Ежегодная плата членского билета для нижегородцев
                    {
                        switch (ticketType) // билет
                        {
                            case 1: // для человека, которому старше 18 лет.
                                {
                                    if (age >= 18) // если больше 18, то 100 руб
                                    {
                                        promres = 100; // 100 рублей - для тех, кто старше 18 лет.

                                        res = (int)Math.Ceiling(promres); // считывание результата
                                    }

                                    return res;
                                }

                            case 2: // для человека, которому старше 30 лет
                                {
                                    if (age >= 30) // если больше 30, то 75 руб
                                    {
                                        promres = 75; // 75 рублей - для тех, кто старше 30 лет.

                                        res = (int)Math.Ceiling(promres); // считывание результата
                                    }

                                    return res;
                                }

                            case 3: // для человека, которому старше 50 лет
                                {
                                    if (age >= 50) // если больше 30, то 50 руб
                                    {
                                        promres = 50; // 50 рублей - для тех, кто старше 50 лет.

                                        res = (int)Math.Ceiling(promres); // считывание результата
                                    }

                                    return res;
                                }

                            default:
                                {
                                    return -1;
                                }
                        }
                    }

                case 3: // Обновление членского билета для нижегородцев
                    {
                        switch (ticketType) // билет
                        {
                            case 1: // для человека, которому исполнилось 30 лет, когда уже получил в 18 лет, то нужно будет обновить членский билет
                                {
                                    if (age == 30) // если исполнилось 30 лет, то 100 руб
                                    {
                                        promres = 100; // 100 рублей - для тех, которому исполнилось 30 лет

                                        res = (int)Math.Ceiling(promres);
                                    }

                                    return res;
                                }

                            case 2: // для человека, которому исполнилось 50 лет, когда уже обновил в 30 лет, то нужно будет еще раз обновить членский билет
                                {
                                    if (age == 50) // если больше 30, то 50 руб
                                    {
                                        promres = 50; // 50 рублей - для тех, которому исполнилось 50 лет.

                                        res = (int)Math.Ceiling(promres); // считывание результата
                                    }

                                    return res;
                                }

                            default:
                                {
                                    return -1;
                                }
                        }
                    }

                default:
                    {
                        return -1;
                    }
            }
        }
    }
}
