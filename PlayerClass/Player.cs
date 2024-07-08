namespace PlayerClass
{
    public class Player
    {
        private Dictionary<Type, int> bonusDamage = new Dictionary<Type, int>();
        private Dictionary<Type, int> weaknessDamage = new Dictionary<Type, int>();

        public Dictionary<Type, int> getBonusDamage() => bonusDamage;
        public Dictionary<Type, int> getWeaknessDamage() => weaknessDamage;



        private ClassPlayer classPlayer;


        public int MaxHp { get; init; }
        public int MaxShield { get; init; }
        public int MaxEnergy { get; init; }



        private int hp;
        public int Hp { get { return hp; } set { hp = value >= this.MaxHp ? this.MaxHp : value; } }

        private int shield;
        public int Shield { get { return shield; } set { shield = value >= this.MaxShield ? this.MaxShield : value; } }

        private int energy;
        public int Energy { get { return energy; } set { energy = value >= this.MaxEnergy ? this.MaxEnergy : value; } }

        public Player(ClassPlayer _classPlayer, int maxHp, int maxEnergy, int maxShield = 0)
        {
            classPlayer = _classPlayer;
            MaxHp = maxHp;
            MaxShield = maxShield;
            MaxEnergy = maxEnergy;
        }

        public void showInfo()
        {
            Console.WriteLine($"Class: {classPlayer}");
            Console.WriteLine($"MaxHp: {MaxHp}");
            Console.WriteLine($"Hp: {Hp}");
            Console.WriteLine($"MaxShield: {MaxShield}");
            Console.WriteLine($"Shield: {Shield}");
            Console.WriteLine($"MaxEnergy: {MaxEnergy}");
            Console.WriteLine($"Energy: {Energy}");

            Console.WriteLine();
            Console.WriteLine("All bonus damage:");
            foreach (var element in bonusDamage)
                Console.WriteLine($"Type: {element.Key.Name} | Percent bonus damage: {element.Value}");

            Console.WriteLine();
            Console.WriteLine("All weakness damage:");
            foreach (var element in weaknessDamage)
                Console.WriteLine($"Type: {element.Key.Name} | Percent weakness damage: {element.Value}");

        }

    }
}
