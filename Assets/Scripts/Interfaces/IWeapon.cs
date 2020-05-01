namespace Assets.Scripts.Interfaces
{
    public interface IWeapon
    {
        int Health { get; set; }

        void Shoot();
    }
}