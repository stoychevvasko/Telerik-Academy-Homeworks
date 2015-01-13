namespace GameLibrary
{
    public class Player : Agent
    {
        public int experience { get; private set; }

        public int mojo { get; private set; }

        public Inventory inventory { get; private set; }
    }
}