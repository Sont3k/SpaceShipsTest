using Assets.Scripts.Interfaces;
using Assets.Scripts.Weapons;
using UnityEngine;

namespace Assets.Scripts
{
    public class Spaceship : MonoBehaviour, ISpaceship
    {
        
        [Header("Light Slots")]
        [SerializeField] private LightSlot _lightSlot_1;
        [SerializeField] private LightSlot _lightSlot_2;

        [Header("Medium Slots")]
        [SerializeField] private MediumSlot _mediumSlot;

        [Header("Heavy Slots")]
        [SerializeField] private HeavySlot _heavySlot;

        // Weapon properties
        public LightSlot LightSlot_1 { get => _lightSlot_1; set { _lightSlot_1 = value; } }
        public LightSlot LightSlot_2 { get => _lightSlot_2; set { _lightSlot_2 = value; } }
        public MediumSlot MediumSlot { get => _mediumSlot; set { _mediumSlot = value; } }
        public HeavySlot HeavySlot { get => _heavySlot; set { _heavySlot = value; } }

        [Header("Health")]
        [SerializeField] private int _health;
        public int Health { get => _health; set { _health = value; } }

        // Update is called once per frame
        void Update()
        {
            Lifecyclehook();
        }

        void Lifecyclehook()
        {
            if(Health <= 0)
            {
                DestroySpaceship();
            }
        }

        void DestroySpaceship()
        {
            SendMessage("DestroyObject", gameObject);
        }
    }
}