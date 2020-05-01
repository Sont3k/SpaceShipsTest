using Assets.Scripts.Interfaces;

namespace SpaceshipsTest.Assets.Scripts.SlotModules.GunParticles
{
    public class ArmorPiercingBullets : IGunParticles
    {
        public float Damage { get; set; } = 100;
    }
}