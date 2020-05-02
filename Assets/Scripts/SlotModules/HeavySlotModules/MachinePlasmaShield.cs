using Assets.Scripts.SlotModules.GunParticles;
using Assets.Scripts.SlotModules.LightSlotModules;
using Assets.Scripts.SlotModules.MediumSlotModules;
using Assets.Scripts.Slots;
using UnityEngine;

namespace Assets.Scripts.SlotModules.HeavySlotModules
{
    public class MachinePlasmaShield : HeavySlot
    {
        public override int Health { get; set; }

        private MachineGun machineGun = new MachineGun(new Bullets());
        private PlasmaCannon plasmaCannon = new PlasmaCannon(new Plasma());
        private EnergyShield energyShield = new EnergyShield();

        public override int Level { get; set; } = 5;

        private void Start() {
            InitLevel();
        }

        public override void InitLevel()
        {
            Health *= Level;
            // Here can be specification increasing for included objects
        }

        public override void Action()
        {
            if (Health > 0)
            {
                Debug.Log("Machine gun is shooting.");
                Debug.Log("Plasma cannon is shooting.");
                Debug.Log("Energy shield is on.");
            }
            else
            {
                Debug.Log("Can't shoot from machine gun, it's broken.");
                Debug.Log("Can't shoot from plasma cannon, it's broken.");
                Debug.Log("Can't enable energy shield, it has no energy.");
            }
        }
    }
}