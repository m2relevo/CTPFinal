using UnityEngine;
using System.Collections;

public class ACOGscript : MonoBehaviour

{
    // Use this for initialization
    void Start()

    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider ACOG)
    {
        Debug.Log("ACOG Collision Hit");

        if (ACOG.gameObject.tag == "AttachementACOG")
        {
            ACOG.transform.parent = transform;
            ACOG.transform.localPosition = new Vector3(0f, 0f, 0f);
            Debug.Log("ACOG parenting Successful");
        }
    }
}
