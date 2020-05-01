using Assets.Scripts.Interfaces;
using Assets.Scripts.Weapons;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Spaceship : MonoBehaviour, ISpaceship
    {
        [Header("Weapons")]
        [SerializeField] private LightWeapon _lightWeapon_1;
        [SerializeField] private LightWeapon _lightWeapon_2;
        [SerializeField] private MediumWeapon _mediumWeapon;
        [SerializeField] private HeavyWeapon _heavyWeapon;

        public LightWeapon LightWeapon_1 { get => _lightWeapon_1; set { _lightWeapon_1 = value; } }
        public LightWeapon LightWeapon_2 { get => _lightWeapon_2; set { _lightWeapon_2 = value; } }
        public MediumWeapon MediumWeapon { get => _mediumWeapon; set { _mediumWeapon = value; } }
        public HeavyWeapon HeavyWeapon { get => _heavyWeapon; set { _heavyWeapon = value; } }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // Debug.Log("Something");
        }
    }
}