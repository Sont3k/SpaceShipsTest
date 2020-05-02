using Assets.Scripts.Interfaces;
using Assets.Scripts.SlotModules.GunParticles;
using Assets.Scripts.SlotModules.MediumSlotModules;
using Assets.Scripts.Slots;
using UnityEngine;

namespace Assets.Scripts.SlotModules.HeavySlotModules
{
    public class DoubleMachineGunAndDoublePlasmaCannon : HeavySlot, IGun
    {
        public override int Health { get; set; } = 50;
        public int Barrels { get; set; } = 4;

        private DoubleMachineGun machineGun = new DoubleMachineGun(new Bullets());
        private DoublePlasmaCannon plasmaCannon = new DoublePlasmaCannon(new Plasma());

        public override void Action()
        {
            if (Health > 0)
            {
                for(int i = 0; i < Barrels; i++)
                {
                    Debug.Log("Double machine gun is shooting.");
                    Debug.Log("Double plasma cannon is shooting.");
                }
            }
            else
            {
                Debug.Log("Can't shoot from double machine gun, it's broken.");
                Debug.Log("Can't shoot from double plasma cannon, it's broken.");
            }
        }
    }
}