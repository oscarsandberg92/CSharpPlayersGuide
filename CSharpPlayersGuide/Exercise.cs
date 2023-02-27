namespace CSharpPlayersGuide
{
    public abstract class Exercise
    {
        public string Name { get; }

        public Exercise(string name)
        {
            Name = name;
        }

        public virtual void Run() 
        {
            HandyConsole.WaitForUser("Not yet implemented..", ConsoleColor.DarkGray);
        }
    }
}