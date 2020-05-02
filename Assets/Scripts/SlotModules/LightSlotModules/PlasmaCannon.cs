using Assets.Scripts.SlotModules.GunParticles;
using Assets.Scripts.Slots;
using UnityEngine;

namespace Assets.Scripts.SlotModules.LightSlotModules
{
    public class PlasmaCannon : LightSlot
    {
        public override int Health { get; set; } = 10;
        public int Barrel { get; set; } = 1;
        private readonly Plasma _plasma;

        public PlasmaCannon(Plasma plasma)
        {
            _plasma = plasma;
        }

        public override void Action()
        {
            if (Health > 0)
            {
                Debug.Log("Plasma cannon is shooting.");
            }
            else
            {
                Debug.Log("Can't shoot from plasma cannon, it's broken.");
            }
        }
    }
}