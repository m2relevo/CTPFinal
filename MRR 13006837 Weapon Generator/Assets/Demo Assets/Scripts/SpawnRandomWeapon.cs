using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnRandomWeapon : MonoBehaviour
{
    public List<GameObject> ListWeaponGen;

	// Use this for initialization
	void Start ()
    {
       /* if (GameObject.FindGameObjectWithTag("Weapon") == null)
        {
            WeaponSpawner();
        }*/
	}
	
	// Update is called once per frame
	void Update ()
    {
        {
           if (GameObject.FindGameObjectWithTag("Weapon") == null)
            {
                WeaponSpawner();
            }
        }
    }

    void WeaponSpawner()
    {
        int RNG = Random.Range(0, ListWeaponGen.Count);
        GameObject WeaponGen = (GameObject)Instantiate(ListWeaponGen[RNG]);
    }
}
