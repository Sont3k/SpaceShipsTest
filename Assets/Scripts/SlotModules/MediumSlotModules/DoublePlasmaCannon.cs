using Assets.Scripts.SlotModules.GunParticles;
using Assets.Scripts.Slots;
using UnityEngine;

namespace SpaceshipsTest.Assets.Scripts.SlotModules.MediumSlotModules
{
    public class DoublePlasmaCannon : MediumSlot
    {
        public override int Health { get; set; } = 20;
        public int Barrel { get; set; } = 2;

        private readonly Plasma _plasma;

        public DoublePlasmaCannon(Plasma plasma)
        {
            _plasma = plasma;
        }

        public override void Action()
        {
            if (Health > 0)
            {
                for(int i = 0; i < Barrel; i++)
                {
                    Debug.Log("Double plasma cannon is shooting.");
                }
            }
            else
            {
                Debug.Log("Can't shoot from double plasma cannon, it's broken.");
            }
        }
    }
}