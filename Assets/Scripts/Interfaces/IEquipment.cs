using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Interfaces
{
    public interface IEquipment
    {
        int Health { get; set; }

        void Use();
    }
}