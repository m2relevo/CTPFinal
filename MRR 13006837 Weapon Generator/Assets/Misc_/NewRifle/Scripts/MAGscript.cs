using UnityEngine;
using System.Collections;

public class MAGscript : MonoBehaviour

{
	// Use this for initialization
	void Start ()

    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    void OnTriggerEnter(Collider MAG)
    {
        Debug.Log("Mag Collision Hit");

        if (MAG.gameObject.tag == "AttachementMagazine")
        {
            MAG.transform.parent = transform;
            MAG.transform.localPosition = new Vector3(0f, 0f, 0f);
            Debug.Log("MAG parenting Successful");
        }
    }
}
