using Assets.Scripts.Slots;

namespace Assets.Scripts.Interfaces
{
    public interface ISpaceship
    {
        int Health { get; set; }
        int Level { get; set; }

        LightSlot LightSlot_1 { get; set; }
        LightSlot LightSlot_2 { get; set; }
    }
}
