using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        double sumUsd, sumRub, sumUah, convSumUsd, convSumRub, convSumUah;
        string firstValue, secondValue;
        Console.WriteLine("Конвектор валют \n");

        Console.Write("Сколько у тебя USD? > ");
        sumUsd = Convert.ToSingle(Console.ReadLine());

        Console.Write("Сколько у тебя RUB? > ");
        sumRub = Convert.ToSingle(Console.ReadLine());

        Console.Write("Сколько у тебя UAH? > ");
        sumUah = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("\n Если будет выйти напиши \"Выйти\" \n ");

        while (true)
        {
            Console.Write("\n1)USD\n2)RUB\n3)UAH");
            Console.Write("\nИз какой валюты вы хотите перевести? (Писать число) > ");
            firstValue = Console.ReadLine();
            if (firstValue.ToLower() == "выйти")
            {
                break;
            }

            Console.Write("\nВ какой валюту вы хотите перевести? > ");
            secondValue = Console.ReadLine();
            if (firstValue.ToLower() == "выйти")
            {
                break;
            }

            //Конвертацию в одну и ту же валюту
            if (firstValue == "1" && secondValue == "1" || firstValue == "2" && secondValue == "2" || firstValue == "3" && secondValue == "3")
            {
                Console.WriteLine("\nНельзя переводить в одну и туже валюту");
            }

            //Перевод из доллааров в рубли
            else if (firstValue == "1" && secondValue == "2")
            {
                Console.Write("\nСколько вы отдаёте долларов? > ");
                convSumUsd = Convert.ToSingle(Console.ReadLine());
                if (convSumUsd > sumUsd)
                {
                    Console.WriteLine("\n У вас нету такого кол-ва долларов!\n_____________");
                }
                else
                {
                    Console.WriteLine("\nАктуальный курс доллара к рублю: 91.31");
                    sumUsd -= convSumUsd;
                    sumRub += convSumUsd * 91.31;
                    Console.WriteLine("Теперь у вас на счету " + sumUsd.ToString("0.00") + " долларов и " + sumRub.ToString("0.00") + " рублей");
                }
            }

            //Перевод из доллааров в гривни
            else if (firstValue == "1" && secondValue == "3")
            {
                Console.Write("\nСколько вы отдаёте долларов? > ");
                convSumUsd = Convert.ToSingle(Console.ReadLine());
                if (convSumUsd > sumUsd)
                {
                    Console.WriteLine("\nУ тебя нету такого кол-ва долларов!\n_____________");
                }
                else
                {
                    Console.WriteLine("\nАктуальный курс доллара к гривне: 39.29");
                    sumUsd -= convSumUsd;
                    sumUah += convSumUsd * 39.29;
                    Console.WriteLine("Теперь у вас на счету " + sumUsd.ToString("0.00") + " долларов и " + sumUah.ToString("0.00") + " гривен");
                }
            }

            //Перевод из рублей в доллар
            else if (firstValue == "2" && secondValue == "1")
            {
                Console.Write("\nСколько вы отдаёте рублей? > ");
                convSumRub = Convert.ToSingle(Console.ReadLine());
                if (convSumRub > sumRub)
                {
                    Console.WriteLine("\nУ тебя нету такого кол-ва рублей!\n_____________");
                }
                else
                {
                    Console.WriteLine("\nАктуальный курс рубля к доллару: 0.01");
                    sumRub -= convSumRub;
                    sumUsd += convSumRub / 0.01;
                    Console.WriteLine("Теперь у вас на счету " + sumRub.ToString("0.00") + " рублей и " + sumUsd.ToString("0.00") + " долларов");
                }
            }

            //Перевод из рублей в гривны
            else if (firstValue == "2" && secondValue == "3")
            {
                Console.Write("\nСколько вы отдаёте рублей? > ");
                convSumRub = Convert.ToSingle(Console.ReadLine());
                if (convSumRub > sumRub)
                {
                    Console.WriteLine("\nУ тебя нету такого кол-ва рублей!\n_____________");
                }
                else
                {
                    Console.WriteLine("\nАктуальный курс рубля к гривне: 0.43");
                    sumRub -= convSumRub;
                    sumUah += convSumRub / 0.43;
                    Console.WriteLine("Теперь у вас на счету " + sumRub.ToString("0.00") + " рублей и " + sumUah.ToString("0.00") + " гривен");
                }
            }

            //Перевод из гривен в доллары
            else if (firstValue == "3" && secondValue == "1")
            {
                Console.Write("\nСколько вы отдаёте гривен? > ");
                convSumUah = Convert.ToSingle(Console.ReadLine());
                if (convSumUah > sumUah)
                {
                    Console.WriteLine("\nУ тебя нету такого кол-ва гривен!\n_____________");
                }
                else
                {
                    Console.WriteLine("\nАктуальный курс гривны к доллару: 0.025");
                    sumUah -= convSumUah;
                    sumUsd += convSumUah / 0.025;
                    Console.WriteLine("Теперь у вас на счету " + sumRub.ToString("0.00") + " рублей и " + sumUah.ToString("0.00") + " гривен");
                }
            }

            //Перевод из гривен в рубли
            else if (firstValue == "3" && secondValue == "2")
            {
                Console.Write("\nСколько вы отдаёте гривен? > ");
                convSumUah = Convert.ToSingle(Console.ReadLine());
                if (convSumUah > sumUah)
                {
                    Console.WriteLine("\nУ тебя нету такого кол-ва гривен!\n_____________");
                }
                else
                {
                    Console.WriteLine("\nАктуальный курс гривны к рублю: 2.32");
                    sumUah -= convSumUah;
                    sumRub += convSumUah * 2.32;
                    Console.WriteLine("Теперь у вас на счету " + sumUsd.ToString("0.00") + " долларов и " + sumRub.ToString("0.00") + " рублей");
                }
            }
        }
       
    }
}
