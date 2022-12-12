using System;

namespace Adventure_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to My Adventure Game");
            Console.WriteLine("What is your name?");
            Beginner Player = new Beginner();
            Player.Name = Console.ReadLine();
            Console.Clear();
            string bReady;
            
            do{
                Console.WriteLine($"Hi {Player.Name}, Ready to begin the game? [yes/no]");            
                bReady = Console.ReadLine();
                if(bReady != "yes" && bReady != "no")
                {
                Console.WriteLine("Input yang anda masukkan salah");
                }
            }

            
            while(bReady != "yes" && bReady != "no");

            if(bReady == "yes")
            {
                Console.Clear();
                Console.WriteLine(Player.Name+" is entering the World...");
                Enemy1 enemy1 = new Enemy1("Minion");
                Console.WriteLine(Player.Name+" was exploring the world");
                Console.WriteLine(Player.Name+" found a monster "+enemy1.Name);
                Console.WriteLine(enemy1.Name+" is attacking you...");
                Console.WriteLine($"Your Health {Player.Health} | Enemy Health : {enemy1.Health}");
                Console.WriteLine("Your energy skill is :"+Player.SkillSlot);
                Console.WriteLine("Choose your action :");
                Console.WriteLine("1. Single Attack");
                Console.WriteLine("2. Swing Attack");
                Console.WriteLine("3. Defend");
                Console.WriteLine("4. Run Away");

                while (!Player.Dead && !enemy1.Dead)
                {
                    string PlayerAction = Console.ReadLine(); 
                    switch (PlayerAction)
                    {
                        case "1" :
                        Console.WriteLine(Player.Name+" is doing single attack.. ");
                        enemy1.Attack(enemy1.AttackPower);                      
                        Player.Experience += 0.3f;
                        Player.GetHit(enemy1.AttackPower);
                        enemy1.GetHit(Player.AttackPower);
                        Player.Experience += 0.3f;
                        Console.WriteLine($"Your Health {Player.Health} | Enemy Health : {enemy1.Health}");
                        Console.WriteLine("Your energy skill is :"+Player.SkillSlot);
                        break;

                        case "2" :
                        Player.Swing();                        
                        enemy1.Attack(enemy1.AttackPower);
                        Player.GetHit(enemy1.AttackPower);
                        enemy1.GetHit(Player.AttackPower);
                        Console.WriteLine($"Your Health {Player.Health} | Enemy Health : {enemy1.Health}");
                        Console.WriteLine("Your energy skill is :"+Player.SkillSlot);

                        break;

                        case "3" :
                        Player.Rest();
                        Console.WriteLine("Energy is being restored..");
                        enemy1.Attack(enemy1.AttackPower);
                        Player.GetHit(enemy1.AttackPower);
                        Console.WriteLine($"Your Health {Player.Health} | Enemy Health : {enemy1.Health}");
                        Console.WriteLine("Your energy skill is :"+Player.SkillSlot);
                        break;

                        case "4" :
                        Console.WriteLine(Player.Name+" is Running away...");
                        return;  
                    }
                    
                    
                }
                Console.WriteLine($"You get {Player.Experience} experience point from kill {enemy1.Name}");
                Console.WriteLine("You wiinn...");

                Console.ReadLine();
                Console.Clear();
                
            }else if(bReady == "no")
            {
                Console.WriteLine("GoodByee!!");
                Console.Read();
            }
            
        }
    }

    class Beginner
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public int SkillSlot { get; set; }
        public bool Dead { get; set; }
        public float Experience { get; set; }
        Random rnd = new Random();

        public Beginner()
        {
            Health = 100;
            AttackPower = 1;
            SkillSlot = 0;
            Experience = 0f;

        }
        
        public void Swing()
        {
            if(SkillSlot > 0){
                Console.WriteLine("SWIINGGG!!");
                AttackPower = AttackPower + rnd.Next(2,8);
                Experience += 0.5f;
                SkillSlot--;
            }else{
                Console.WriteLine("You dont have enough energy!");
                Console.WriteLine("Doing single attack..");
            }
            
        }

        public void GetHit(int HitValue)
        {
            Console.WriteLine(Name+" Get hit by "+HitValue);
            Health = Health - HitValue;

            if(Health <= 0){
                Health = 0;
                Die();
            }
        }

        public void Rest()
        {
            SkillSlot = 3;
            AttackPower = 1;
        }

        public void Die()
        {
            Console.Clear();
            Console.WriteLine("You Are dead.. Game overr..");
            Dead = true;
        }

    }
    
    class Enemy1
    {
        public int Health { get; set; }
        public string Name { get; set; }
        public int AttackPower { get; set; }
        public bool Dead { get; set; }
        Random rnd = new Random();

        public Enemy1(string name)
        {
            Health = 50;
            Name = name;

        }
        
        public void Attack(int damage)
        {
            AttackPower = rnd.Next(3,6);
        }

        public void GetHit(int HitValue)
        {
            Console.WriteLine(Name+" Get hit by "+HitValue);
            Health = Health - HitValue;

            if(Health <= 0){
                Health = 0;
                Die();
            }
        }

        public void Die()
        {
            Console.WriteLine(Name+" is Dead");
            Dead = true;
        }

    }
}
