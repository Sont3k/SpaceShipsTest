namespace Assets.Scripts.Interfaces
{
    public interface IGun
    {
        int Damage { get; set; }
        int Rapidity { get; set; }
        int Clip { get; set; }
        float ClipReloadTime { get; set; }
        int Barrels { get; set; }
    }
}