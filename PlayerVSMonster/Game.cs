using System;

namespace PlayerVSMonster
{
    internal class Game
    {
        public static void Main(string[] args)
        {
            // Игра Игрок против Монстра
            
            // Первоначальная статистика игрока
            var Player = new
            {
                HP = 100,
                DAMAGE = 1,
                PROTECTION = 1
            };
            
            // Первоначалььная статистика монстра
            var Monster = new
            {
                HP = 1000,
                DAMAGE = 1,
                PROTECTION = 1
            };
            
            // Начало игры
            Console.WriteLine($"Статистика Игрока: Здоровье {Player.HP} | Урон {Player.DAMAGE} | Защита {Player.PROTECTION}");
            Console.WriteLine($"Статистика Монстра: Здоровье {Monster.HP} | Урон {Monster.DAMAGE} | Защита {Monster.PROTECTION}");

            // Процесс игры
            double MonsterHP = (Monster.HP + Monster.PROTECTION) - (Player.DAMAGE);
            double PlayerHP = (Player.HP + Player.PROTECTION) - (Monster.DAMAGE) ;
            double playerActualDamage = (MonsterHP / Player.DAMAGE) - (MonsterHP - PlayerHP);
            double monsterActualDamage = (PlayerHP / Monster.DAMAGE) - 0;

            Console.WriteLine("============================================");

            // Конец игры
            if (PlayerHP > MonsterHP)
            {
                Console.WriteLine($"Победил Игрок!");
                Console.WriteLine($"Итоги игры ---- Игрок нанёс монстру: {playerActualDamage} урона | Монстр нанёс игроку: {monsterActualDamage} урона");
            }

            if (MonsterHP > PlayerHP)
            {
                Console.WriteLine($"Победил Монстр!");
                Console.WriteLine($"Итоги игры ---- Игрок нанёс монстру: {playerActualDamage} урона | Монстр нанёс игроку: {monsterActualDamage} урона");
            }

            if (MonsterHP == PlayerHP)
            {
                Console.WriteLine("У них ничья");
                Console.WriteLine($"Итоги игры ---- Игрок нанёс монстру: {playerActualDamage} урона | Монстр нанёс игроку: {monsterActualDamage} урона");
            }
  
        }
    }
}