using UnityEngine;
using System.Collections;

public class IRONSIGHTscript : MonoBehaviour

{
    // Use this for initialization
    void Start()

    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider IronSight)
    {
        Debug.Log("Mag Collision Hit");

        if (IronSight.gameObject.tag == "AttachementIronSight")
        {
            IronSight.transform.parent = transform;
            IronSight.transform.localPosition = new Vector3(0f, 0f, 0f);
            Debug.Log("Ironsight parenting Successful");
        }
    }
}
