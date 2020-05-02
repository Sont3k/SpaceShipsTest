namespace Assets.Scripts.Interfaces
{
    public interface ISlot
    {
        int Health { get; set; }

        void InitLevel();

        void Action();
    }
}