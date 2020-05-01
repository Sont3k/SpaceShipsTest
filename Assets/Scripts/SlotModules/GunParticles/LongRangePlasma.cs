using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.SlotModules.GunParticles
{
    public class LongRangePlasma : MonoBehaviour, IGunParticles
    {
        [SerializeField] private float _damage = 20;
        [SerializeField] private float _range = 1000;

        public float Damage { get => _damage; set { _damage = value; } }
        public float Range { get => _range; set { _range = value; } }
    }
}