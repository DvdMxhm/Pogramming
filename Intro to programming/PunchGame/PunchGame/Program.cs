namespace Punch_Game
{
    class Attack
    {
        public string name;
        public int damage;
    }

    class Program
    {

        static void Main(string[] args)

        {
            Console.WriteLine("a deep miasma of black follows as you continue down the night streets, stopping only to acknoledge the sinister gnashes coming from beyond a brick wall...");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("George Butch appeared!");
            Console.ForegroundColor = ConsoleColor.White;
            int EnemyHealth = 55;
            int PlayerHealth = 34;

            List<Attack> attacks = new List<Attack>();

            Attack elbow = new Attack();
            elbow.name = "Elbow";
            elbow.damage = 10;

            attacks.Add(elbow);

            // MAKES PLAYER AWARE OF VARIABLES

            while (PlayerHealth > 0 || EnemyHealth > 0)
            {
                Console.WriteLine("You have " + PlayerHealth + " health.");
                Console.WriteLine("George Butch has " + EnemyHealth + " health.");
                Console.WriteLine(" ");
                Console.WriteLine("what will you do?");

                //Get the players choice
                string choice = Console.ReadLine();

                if (choice == "attack")
                {

                }
             
            }
          
        }
    }
}