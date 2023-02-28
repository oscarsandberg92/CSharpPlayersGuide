namespace CSharpPlayersGuide.Exercises.Hunting_The_Manticore
{
    internal class Game
    {
        public int Round { get; set; }
        public int CityMaxHealth { get; set; }
        public int CityCurrentHealth { get; set; }
        public int ManticoreMaxHealth { get; set; }
        public int ManticoreCurrentHealth { get; set; }
        public int ManticoreDistance { get; set; }

        public Game()
        {
            Round = 1;
            CityMaxHealth = 15;
            CityCurrentHealth = CityMaxHealth;
            ManticoreMaxHealth = 10;
            ManticoreCurrentHealth = ManticoreMaxHealth;
        }

        public void PlayRound()
        {
            PrintStatus();   
            int playerGuess = HandyConsole.GetInputAsInt("Enter the desired cannon range: ", minValue: 1, maxValue: 100);

            bool isHit = CheckIfHit(playerGuess);
            if (isHit)
            {
                HandyConsole.WriteLine(GetShotInfo(playerGuess),ConsoleColor.Green);
                ManticoreCurrentHealth -= GetDamage();
            }

            else
                HandyConsole.WriteLine(GetShotInfo(playerGuess),ConsoleColor.Yellow);

            HandyConsole.WriteLine("".PadRight(40,'-'));
            CityCurrentHealth--;

            if (ManticoreCurrentHealth > 0 && CityCurrentHealth > 0)
            {
                Round++;
            }
        }

        private string GetShotInfo(int playerGuess)
        {
            if (playerGuess > ManticoreDistance) return "That round OVERSHOT the target";
            else if (playerGuess < ManticoreDistance) return "That round FELL SHORT of the target";
            return "It was a DIRECT HIT!";
        }

        private void PrintStatus()
        {
            HandyConsole.WriteLine($"STATUS: Round: {Round} City: {CityCurrentHealth}/{CityMaxHealth} Manticore: {ManticoreCurrentHealth}/{ManticoreMaxHealth}");
            HandyConsole.WriteLine($"The cannon is expected to deal {GetDamage()} this round.");
        }

        private bool CheckIfHit(int playerGuess) => playerGuess == ManticoreDistance;

        private int GetDamage()
        {
            if (Round % 3 == 0 && Round % 5 == 0) return 10;
            else if (Round % 3 == 0) return 3;
            else if (Round % 5 == 0) return 3;
            else return 1;

        }
    }
}