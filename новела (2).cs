using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace novela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            byte age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine($"Здраствуй, {name}! \nТы встал рано утром и увидел, что окно разбито, что ты будешь делать?");
            Console.WriteLine("1: Вызову полицию\n2: Спрячусь под кровать\n3: Пойду проверю");
            byte action_1 = Convert.ToByte(Console.ReadLine());
            if (action_1 == 1)
            {
                Console.WriteLine("Вы начали звонить в полицию, но связи нет...\nЧто-то упало на кухне\nВаши дейсвтия?\n1: Убежать из дома\n2: Пойти на кухню");
                byte run_attack = Convert.ToByte(Console.ReadLine());
                if (run_attack == 1)
                {
                    Console.WriteLine("Вы начали бежать, но дверь закрыта, что будете делать?\n1: Выбью дверьn\n2: Вылезу в разбитое окно");
                    byte open_or_no = Convert.ToByte(Console.ReadLine());
                    if (open_or_no == 1)
                    {
                        Console.WriteLine("Вы выбили дверь, но повредили ногу, но все жесмогли сбежать хэпи хэпи хэпи");
                    }
                    else {
                        Console.WriteLine("Вы пошли к окну, но вас увидел грабитель...\nНо тут вдруг взялись сиерны и он начал убегать ничего не взяв с собой\nХэпи хэпи");
                    }
                }
                else
                {
                    Console.WriteLine("Вы увидели человека, что будете делать?\n1: Нападу\n2: Попобовать решить мирно"); ;
                    byte atack = Convert.ToByte(Console.ReadLine());
                    if (atack == 1)
                    {
                        Console.WriteLine($"Вы напали на грабителя, но у него был пистолет и вы умерли\nPress F вы ддостигли{age}");
                    }
                    else
                    {
                        Console.WriteLine("Вы решили проблемы мирно и выжили, но вас огрбаили :(");
                    }
                }
            }
            else if (action_1 == 2)
            {
                Console.WriteLine("Вы спрятались под кроватью");
                Console.WriteLine("Вы очень сльно захотели в туалет, пойдете?\n1: Пойду\n2: Нет");
                byte toulet = Convert.ToByte(Console.ReadLine());
                if (toulet == 1) {
                    Console.WriteLine("Вы пошли в туалет и вас ударили по голове сздаи...\nВы очнулись в больнице и вас начали расспрашиавть о грабителе");
                        }
                else {
                    Console.WriteLine("Вы не пошли в туалет и просто ждали\nПозже вы все таки решили выйти.");
                    Console.WriteLine("Куда пойдете?\n1: Кухня\n2: Гостинная");
                    byte lets_go = Convert.ToByte(Console.ReadLine());
                    if (lets_go == 1)
                    {
                        Console.WriteLine("Вы зашли на кухню и увидели китика, это был он злым грабителем");
                    }
                    else { 
                        Console.WriteLine("Вы вышли и увидели странные следы на ковре и вы пошли на кухню");
                        Console.WriteLine("Вы зашли на кухню и увидели китика, это был он злым грабителем");
                    }
                }
            }
            else
            {
                Console.WriteLine("Вы вышли прошли проверить и увидели человека, что будете делать?\n1: Нападу\n2: Убегу");
                byte run_attack2 = Convert.ToByte(Console.ReadLine());
                if (run_attack2 == 1)
                {
                    Console.WriteLine("Вы напали на грабителя\n\nВы нанесил первый удар, но тут сразу вам дали в ответ, но в конце концов вы выйграли эту битвку и вызвали полицию\nхэпи хэпи хэпи");
                }
                else { 
                Console.WriteLine("Вы побежали и споткнулись и отрубились, когда очнулись, то поняли что вы перепили и у вас была белочка \nХэпи или не хэпи решать вам");
                }

            }
        }
    }
}
