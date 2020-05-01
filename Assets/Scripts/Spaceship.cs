using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    private IWeapon weapon { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        IWeapon weapon = (IWeapon)GetComponent(typeof(IWeapon));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
