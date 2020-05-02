using Assets.Scripts.Interfaces;
using Assets.Scripts.SlotModules.GunParticles;
using Assets.Scripts.Slots;
using UnityEngine;

namespace Assets.Scripts.SlotModules.LightSlotModules
{
    public class MachineGun : LightSlot, IGun
    {
        public override int Health { get; set; } = 10;
        public int Barrels { get; set; } = 1;
        private readonly Bullets _bullets;

        public MachineGun(Bullets bullets)
        {
            _bullets = bullets;
        }

        public override void Action()
        {
            if (Health > 0)
            {
                Debug.Log("Machine gun is shooting.");
            }
            else
            {
                Debug.Log("Can't shoot from machine gun, it's broken.");
            }
        }
    }
}