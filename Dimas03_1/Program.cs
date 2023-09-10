using System;
using System.Timers;

namespace BackupScheduler
{
    class Program
    {
        static Timer timer;

        static void Main(string[] args)
        {
            // Установите интервал выполнения резервного копирования (в миллисекундах)
            int interval = 24 * 60 * 60 * 1000; // 24 часа

            // Создание таймера
            timer = new Timer(interval);
            timer.Elapsed += TimerElapsed;

            // Запуск таймера
            timer.Start();

            // Чтобы программа не завершилась сразу
            Console.WriteLine("Программа запущена. Нажмите любую клавишу для выхода.");
            Console.ReadKey();

            // Остановка таймера
            timer.Stop();
        }

        static void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            // Здесь вызывайте функцию для выполнения резервного копирования
            // Например:
            PerformBackup();
        }

        static void PerformBackup()
        {
            // Здесь разместите код для выполнения резервного копирования.
            // Например, копирование файлов или базы данных.

            Console.WriteLine("Выполнено резервное копирование: " + DateTime.Now);
        }
    }
}