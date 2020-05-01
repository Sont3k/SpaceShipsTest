using Assets.Scripts.Weapons;
using SpaceshipsTest.Assets.Scripts.Equipment;

namespace Assets.Scripts.Interfaces
{
    public interface ISpaceship
    {
        int Health { get; set; }
        
        LightWeapon LightWeapon_1 { get; set; }
        LightWeapon LightWeapon_2 { get; set; }

        Scanner Scanner { get; set; }
    }
}
