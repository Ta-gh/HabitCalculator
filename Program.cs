using System;

namespace HabitCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Бесконечный цикл для постоянной работы программы
            while (true)
            {
                Console.Clear(); // Очищаем консоль перед каждым выводом меню
                Console.WriteLine("╔════════════════════════════════════════╗");
                Console.WriteLine("║    КАЛЬКУЛЯТОР ПОЛЕЗНЫХ ПРИВЫЧЕК     ║");
                Console.WriteLine("╚════════════════════════════════════════╝");
                Console.WriteLine();
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("  1. 🚶 Подсчет шагов (Студент 1)");
                Console.WriteLine("  2. 💧 Подсчет выпитой воды (Студент 2)");
                Console.WriteLine("  3. 📖 Подсчет прочитанных страниц (Студент 3)");
                Console.WriteLine("  4. 🔥 Подсчет калорий (Студент 4)");
                Console.WriteLine("  5. 🧘 Подсчет минут медитации (Студент 5)");
                Console.WriteLine("  6. 🏋️ Подсчет приседаний (Студент 6)");
                Console.WriteLine("  0. ❌ Выход");
                Console.WriteLine();
                Console.Write("👉 Ваш выбор: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                // ====================================================================
                // БЛОК SWITCH-CASE ДЛЯ ОБРАБОТКИ ВЫБОРА ПОЛЬЗОВАТЕЛЯ
                // ====================================================================
                // ВНИМАНИЕ, СТУДЕНТЫ!
                // Каждый студент должен найти СВОЙ case по номеру и заменить
                // строку с Console.WriteLine на вызов своей функции.
                // ====================================================================

                switch (choice)
                {
                    // ==================== СТУДЕНТ 1: ШАГИ ====================
                    case "1":
                        // TODO: СТУДЕНТ 1 - ЗАМЕНИТЕ СЛЕДУЮЩУЮ СТРОКУ
                        // Вместо этого временного сообщения вызовите ваш метод CalculateSteps()
                       // Console.WriteLine("Функция подсчета шагов пока не реализована.");
                        // После замены должно быть:
                        CalculateSteps();
                        break;

                    // ==================== СТУДЕНТ 2: ВОДА ====================
                    case "2":
                        // TODO: СТУДЕНТ 2 - ЗАМЕНИТЕ СЛЕДУЮЩУЮ СТРОКУ
                        // Вместо этого временного сообщения вызовите ваш метод CalculateWater()
                        CalculateWater();
                        // После замены должно быть:
                         break;

                    // ==================== СТУДЕНТ 3: СТРАНИЦЫ ====================
                    case "3":
                        // TODO: СТУДЕНТ 3 - ЗАМЕНИТЕ СЛЕДУЮЩУЮ СТРОКУ
                        // Вместо этого временного сообщения вызовите ваш метод CalculatePages()
                       // Console.WriteLine("Функция подсчета страниц пока не реализована.");
                        // После замены должно быть:
                        CalculatePages();
                        break;

                    // ==================== СТУДЕНТ 4: КАЛОРИИ ====================
                    case "4":
                        // TODO: СТУДЕНТ 4 - ЗАМЕНИТЕ СЛЕДУЮЩУЮ СТРОКУ
                        // Вместо этого временного сообщения вызовите ваш метод CalculateCalories()
                        //Console.WriteLine("Функция подсчета калорий пока не реализована.");
                        // После замены должно быть:
                        CalculateCalories();
                        break;

                    // ==================== СТУДЕНТ 5: МЕДИТАЦИЯ ====================
                    case "5":
                        // TODO: СТУДЕНТ 5 - ЗАМЕНИТЕ СЛЕДУЮЩУЮ СТРОКУ
                        // Вместо этого временного сообщения вызовите ваш метод CalculateMeditation()
                       // Console.WriteLine("Функция подсчета медитации пока не реализована.");
                        // После замены должно быть:
                        CalculateMeditation();
                        break;

                    // ==================== СТУДЕНТ 6: ПРИСЕДАНИЯ ====================
                    case "6":
                        // TODO: СТУДЕНТ 6 - ЗАМЕНИТЕ СЛЕДУЮЩУЮ СТРОКУ
                        // Вместо этого временного сообщения вызовите ваш метод CalculateSquats()
                        CalculateSquats();

                        // После замены должно быть:
                        // CalculateSquats();
                        break;

                    // ==================== ВЫХОД ====================
                    case "0":
                        Console.WriteLine("👋 До свидания! Хорошего дня!");
                        Console.WriteLine("Нажмите любую клавишу для выхода...");
                        Console.ReadKey();
                        return; // Выход из программы

                    // ==================== НЕВЕРНЫЙ ВВОД ====================
                    default:
                        Console.WriteLine("❌ Ошибка: неверный выбор!");
                        Console.WriteLine("Пожалуйста, выберите число от 0 до 6.");
                        break;
                }

                // Пауза перед возвратом в меню
                Console.WriteLine();
                Console.WriteLine("════════════════════════════════════════");
                Console.WriteLine("Нажмите любую клавишу для возврата в меню...");
                Console.ReadKey();
            }
        }

        // ====================================================================
        // БЛОК ДЛЯ ДОБАВЛЕНИЯ МЕТОДОВ СТУДЕНТАМИ
        // ====================================================================
        // ВНИМАНИЕ, СТУДЕНТЫ!
        // КАЖДЫЙ СТУДЕНТ ДОЛЖЕН ДОБАВИТЬ СВОЙ МЕТОД НИЖЕ ЭТОЙ СТРОКИ!
        // Не изменяйте и не удаляйте методы других студентов.
        // Добавляйте свой метод после всех существующих методов.
        // ====================================================================

        // --------------------------------------------------------------------
        // МЕТОДЫ СТУДЕНТОВ (ДОБАВЛЯЙТЕ СВОЙ МЕТОД ЗДЕСЬ)
        // --------------------------------------------------------------------

        // 📍 СТУДЕНТ 1: Добавьте сюда метод CalculateSteps()

        static void CalculateSteps()
{
    Console.Write("Введите количество шагов за сегодня: ");
    int steps = int.Parse(Console.ReadLine());
    
    double kilometers = steps * 0.75 / 1000; // перевод в км
    double calories = steps * 0.04;
     Console.WriteLine($"\n Результаты:");
    Console.WriteLine($"Пройдено: {kilometers:F2} км");
    Console.WriteLine($"Сожжено: {calories:F0} ккал");
     Console.Write("\n Рекомендация: ");
    if (steps < 5000)
        Console.WriteLine("Мало двигаетесь! Постарайтесь проходить минимум 5000 шагов.");
    else if (steps < 10000)
        Console.WriteLine("Хороший результат! Но до нормы 10000 шагов еще немного.");
    else
        Console.WriteLine("Отлично! Вы выполнили норму шагов!");
}

        
      
        // 📍 СТУДЕНТ 2: Добавьте сюда метод CalculateWater()
        static void CalculateWater()
        {
            Console.Write("Сколько стаканов воды (250 мл) вы выпили сегодня? ");
            int glasses = int.Parse(Console.ReadLine());
            double liters = glasses * 0.25;
            double norm = 2.0; // норма в литрах
            double percent = (liters / norm) * 100;
            Console.WriteLine($"\n Результаты:");
            Console.WriteLine($"Выпито: {liters:F1} литров");
            Console.WriteLine($"Выполнено: {percent:F0}% от нормы (2 литра)");
            Console.Write("\n Рекомендация: ");
            if (liters < 1.0)
                Console.WriteLine("Пейте больше воды! Это важно для здоровья.");
            else if (liters < 2.0)
                Console.WriteLine("Хорошо, но до нормы еще немного. Выпейте еще ста-кан!");
            else
                Console.WriteLine("Отлично! Вы поддерживаете водный баланс!");
        };



        // 📍 СТУДЕНТ 3: Добавьте сюда метод CalculatePages()
static void CalculatePages()
{
    Console.Write("Сколько страниц вы прочитали сегодня? ");
    int pages = int.Parse(Console.ReadLine());
    int minutesSpent = pages * 2;
    int hours = minutesSpent / 60;
    int minutes = minutesSpent % 60;
    int goal = 50; // цель в страницах
    double progress = (double)pages / goal * 100;
    Console.WriteLine($"\n Результаты:");
    Console.WriteLine($"Прочитано: {pages} страниц");
    Console.WriteLine($"Затрачено времени: {hours} ч {minutes} мин");
    Console.WriteLine($"Прогресс к цели (50 стр): {progress:F0}%");
    Console.Write("\n Рекомендация: ");
    if (pages < 20)
       Console.WriteLine("Читайте больше! 20 страниц в день - хорошая привыч-ка.");
    else if (pages < 50)
        Console.WriteLine("Отличный темп! Осталось совсем немного до цели!");
    else
        Console.WriteLine("Превосходно! Вы перевыполнили норму чтения!");
}


        // 📍 СТУДЕНТ 4: Добавьте сюда метод CalculateCalories()
static void CalculateCalories()
{
    Console.Write("Введите название блюда: ");
    string meal = Console.ReadLine();
    Console.Write("Введите количество калорий в этом блюде: ");
    int calories = int.Parse(Console.ReadLine());
    int dailyNorm = 2000;
    int remaining = dailyNorm - calories;
    Console.WriteLine($"\n Результаты:");
    Console.WriteLine($"Блюдо: {meal}");
    Console.WriteLine($"Калорийность: {calories} ккал");
    Console.Write("\n Рекомендация: ");
    if (calories > 800)
        Console.WriteLine($"Это довольно калорийно. Осталось {remaining} ккал на сегодня.");
    else if (calories > 400)
        Console.WriteLine($"Неплохо. У вас осталось {remaining} ккал.");
    else
        Console.WriteLine($"Отличный выбор! Осталось {remaining} ккал на сегодня.");
    if (remaining < 0)
        Console.WriteLine("⚠️ Внимание: вы превысили дневную норму калорий!");
}

        // 📍 СТУДЕНТ 5: Добавьте сюда метод CalculateMeditation()
        static void CalculateMeditation()
        {
         Console.Write("Сколько минут вы медитировали сегодня? ");
         int minutes = int.Parse(Console.ReadLine());
         int norm = 10; // норма в минутах
         double stressReduction = Math.Min(minutes * 10, 100); // максимум 100%
         Console.WriteLine($"\n Результаты:");
         Console.WriteLine($"Время медитации: {minutes} минут");
         Console.WriteLine($"Снижение уровня стресса: {stressReduction:F0}%");
         if (minutes >= norm)
             Console.WriteLine($" Отлично! Вы выполнили норму ({norm} минут)!");
         else
             Console.WriteLine($" До нормы осталось {norm - minutes} минут.");
         Console.Write("\n Мотивация: ");
         if (minutes < 5)
             Console.WriteLine("Начните с 5 минут в день. Это уже принесет пользу!");
         else if (minutes < 10)
             Console.WriteLine("Хороший старт! Добавьте еще немного для полной нормы.");
         else
             Console.WriteLine("Великолепно! Регулярная медитация улучшает качество жизни!");
        }

        // 📍 СТУДЕНТ 6: Добавьте сюда метод CalculateSquats()
                    static void CalculateSquats()
{
    Console.Write("Сколько приседаний вы сделали сегодня? ");
    int squats = int.Parse(Console.ReadLine());
    double caloriesBurned = squats * 0.5;
    string level;
    if (squats < 30)
        level = "Начинающий";
    else if (squats < 100)
        level = "Средний";
    else
        level = "Продвинутый";
    Console.WriteLine($"\n Результаты:");
    Console.WriteLine($"Приседаний: {squats} раз");
    Console.WriteLine($"Сожжено: {caloriesBurned:F0} ккал");
    Console.WriteLine($"Уровень: {level}");
    Console.Write("\n Рекомендация: ");
    if (squats < 30)
        Console.WriteLine("Начните с 3 подходов по 10 раз. Постепенно увеличивайте нагрузку!");
    else if (squats < 100)
        Console.WriteLine("Хороший результат! Попробуйте делать приседания с утяжелением.");
    else
        Console.WriteLine("Великолепно! Вы мастер приседаний! Не забывайте про технику.");
}

        // ====================================================================
        // КОНЕЦ БЛОКА ДЛЯ ДОБАВЛЕНИЯ МЕТОДОВ
        // ====================================================================
    }
}
