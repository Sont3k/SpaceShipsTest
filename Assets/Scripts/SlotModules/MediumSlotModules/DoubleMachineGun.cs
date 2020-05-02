using Assets.Scripts.Interfaces;
using Assets.Scripts.SlotModules.GunParticles;
using Assets.Scripts.Slots;
using UnityEngine;

namespace Assets.Scripts.SlotModules.MediumSlotModules
{
    public class DoubleMachineGun : MediumSlot, IGun
    {
        public override int Health { get; set; } = 20;
        public int Barrels { get; set; } = 2;
        public int Damage { get; set; } = 100;
        public int Rapidity { get; set; } = 60;
        public int Clip { get; set; } = 140;
        public float ClipReloadTime { get; set; } = 30.8f;
        public override int Level { get; set; } = 1;

        private readonly Bullets _bullets;

        public DoubleMachineGun(Bullets bullets)
        {
            _bullets = bullets;
        }

        private void Start() {
            InitLevel();
        }

        public override void InitLevel()
        {
            Health *= Level;
            Damage *= Level;
            Rapidity *= Level;
            Clip *= Level;
            ClipReloadTime *= Level;
        }

        public override void Action()
        {
            if (Health > 0)
            {
                for(int i = 0; i < Barrels; i++)
                {
                    Debug.Log("Double machine gun is shooting.");
                }
            }
            else
            {
                Debug.Log("Can't shoot from double machine gun, it's broken.");
            }
        }
    }
}