using Assets.Scripts.Interfaces;
using Assets.Scripts.Weapons;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Spaceship : MonoBehaviour, ISpaceship
    {
        public LightWeapon Lweapon_1 { get; set; }
        public LightWeapon Lweapon_2 { get; set; }
        public MediumWeapon Mweapon_1 { get; set; }
        public HeavyWeapon Hweapon_1 { get; set; }

        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}