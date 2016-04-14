using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeaponGenerator : MonoBehaviour
{
    public string ModelType;
    public GameObject WeaponSpawnLocation = null;
    public bool CustomSword = false;
    public List<GameObject> ListBlade;
    public List<GameObject> ListGuard;
    public List<GameObject> ListHilt;

    public bool CustomGun = false;
    public List<GameObject> ListScope;
    public List<GameObject> ListMag;
    public List<GameObject> ListBarrelExt;
    public List<GameObject> ListSideMount;
    public List<GameObject> ListUnderMount;

    public GameObject SourceSword = null;
    public GameObject SourceBlade = null;
    public GameObject SourceGuard = null;
    public GameObject SourceHilt = null;

    public GameObject SourceGun = null;
    public GameObject SourceScope = null;
    public GameObject SourceMag = null;
    public GameObject SourceBarrelExt = null;
    public GameObject SourceSideMount = null;
    public GameObject SourceUnderMount = null;

    bool Bladeonce;
    bool Guardonce;
    bool hiltonce;

    bool Magonce;
    bool Scopeonce;
    bool BarrelExtonce;
    bool BarrelSideMountonce;
    bool BarrelUnderMountonce;

    // Use this for initialization
    void Start()
    {
        if (ModelType == "Sword")
        {
            GameObject SwordSource = Instantiate(SourceSword);
            SwordSource.transform.parent = WeaponSpawnLocation.transform;
            SwordSource.transform.localPosition = new Vector3(0f, 0f, 0f);

            if (Bladeonce == false)
            {
                Bladegen();
                Bladeonce = true;
            }
            if (Guardonce == false)
            {
                Guardgen();
                Guardonce = true;
            }
            if (hiltonce == false)
            {
                Hiltgen();
                hiltonce = true;
            }

            if (GameObject.FindGameObjectsWithTag("SwordBladePart") != null && GameObject.FindGameObjectsWithTag("SwordGuardPart") != null && GameObject.FindGameObjectsWithTag("SwordHiltPart") != null)
            {
                Debug.Log("Sword has been made");
            }
        }

        if (ModelType == "Gun")
        {
            GameObject GunSource = (GameObject)Instantiate(SourceGun);
            GunSource.transform.parent = WeaponSpawnLocation.transform;
            GunSource.transform.localPosition = new Vector3(0f, 0f, 0f);

            if (Scopeonce == false)
            {
                Scopegen();
                Scopeonce = true;
            }

            if (Magonce == false)
            {
                Maggen();
                Magonce = true;
            }

            if (BarrelExtonce == false)
            {
                BarrelExtgen();
                BarrelExtonce = true;
            }

            if (BarrelSideMountonce == false)
            {
                BarrelSideMountgen();
                BarrelSideMountonce = true;
            }

            if (BarrelUnderMountonce == false)
            {
                BarrelUnderMountgen();
                BarrelUnderMountonce = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Bladegen()
    {
        if (CustomSword == false)
        {
            if (GameObject.FindGameObjectWithTag("SwordBladeSource") != null)
            {
                SourceBlade = null;
                SourceBlade = GameObject.FindGameObjectWithTag("SwordBladeSource");
            }
        }

        int RNG = Random.Range(0, ListBlade.Count);

        Debug.Log("Blade RNG=" + RNG);

        {
            GameObject Blade = (GameObject)Instantiate(ListBlade[RNG]);
            Blade.transform.parent = SourceBlade.transform;
            Blade.transform.localPosition = new Vector3(0f, 0f, 0f);
            Debug.Log("Blade Spawned");
        }
    }

    void Guardgen()
    {
        if (CustomSword == false)
        {
            if (GameObject.FindGameObjectWithTag("SwordGuardSource") != null)
            {
                SourceGuard = null;
                SourceGuard = GameObject.FindGameObjectWithTag("SwordGuardSource");
            }
        }

        int RNG = Random.Range(0, ListGuard.Count);
        Debug.Log("Guard RNG=" + RNG);

        {
            GameObject Guard = (GameObject)Instantiate(ListGuard[RNG]);
            Guard.transform.parent = SourceGuard.transform;
            Guard.transform.localPosition = new Vector3(0f, 0f, 0f);
            Debug.Log("Guard1 Spawned");
        }
    }

    void Hiltgen()
    {
        if (CustomSword == false)
        {
            if (GameObject.FindGameObjectWithTag("SwordHiltSource") != null)
            {
                SourceHilt = null;
                SourceHilt = GameObject.FindGameObjectWithTag("SwordHiltSource");
            }
        }

        int RNG = Random.Range(0, ListHilt.Count);
        Debug.Log("Hilt RNG=" + RNG);
        
        {
            GameObject Hilt = (GameObject)Instantiate(ListHilt[RNG]);
            Hilt.transform.parent = SourceHilt.transform;
            Hilt.transform.localPosition = new Vector3(0f, 0f, 0f);
            Debug.Log("Hilt1 Spawned");
        }
    }

    void Scopegen()
    {
            if (CustomGun == false)
            {
                if (GameObject.FindGameObjectWithTag("GunScopeSource") != null)
                {
                    SourceScope = null;
                    SourceScope = GameObject.FindGameObjectWithTag("GunScopeSource");
                }
            }

            int RNG = Random.Range(0, ListScope.Count);
            Debug.Log("Scope RNG =" + RNG);

            {
                GameObject Scope = (GameObject)Instantiate(ListScope[RNG]);
                Scope.transform.parent = SourceScope.transform;
                Scope.transform.localPosition = new Vector3(0f, 0f, 0f);
            }
    }

    void Maggen()
    {
        if (CustomGun == false)
        {
            if (GameObject.FindGameObjectWithTag("GunMagSource") != null)
            {
                SourceMag = null;
                SourceMag = GameObject.FindGameObjectWithTag("GunMagSource");
            }
        }

        int RNG = Random.Range(0, ListMag.Count);
        Debug.Log("Mag RNG =" + RNG);
        
        {
            GameObject Mag = (GameObject)Instantiate(ListMag[RNG]);
            Mag.transform.parent = SourceMag.transform;
            Mag.transform.localPosition = new Vector3(0f, 0f, 0f);
            Debug.Log("Mag has spawned");
        }
    }

    void BarrelExtgen()
    {
        if (CustomGun == false)
        {
            if (GameObject.FindGameObjectWithTag("GunBarrelExtensionSource") != null)
            {
                SourceBarrelExt = null;
                SourceBarrelExt = GameObject.FindGameObjectWithTag("GunBarrelExtensionSource");
            }
        }

        int RNG = Random.Range(0, ListBarrelExt.Count);
        Debug.Log("Barrel Ext RNG =" + RNG);

        {
            GameObject BarrelExt = (GameObject)Instantiate(ListBarrelExt[RNG]);
            BarrelExt.transform.parent = SourceBarrelExt.transform;
            BarrelExt.transform.localPosition = new Vector3(0f, 0f, 0f);
            Debug.Log("Gun Barrel Extension has spawned");
        }
    }

    void BarrelSideMountgen()
    {
        if (CustomGun == false)
        {
            if (GameObject.FindGameObjectWithTag("GunSideMountSource") != null)
            {
                SourceSideMount = null;
                SourceSideMount = GameObject.FindGameObjectWithTag("GunSideMountSource");
            }
        }

        int RNG = Random.Range(0, ListSideMount.Count);
        Debug.Log("Mag RNG =" + RNG);

        {
            GameObject SideMount = (GameObject)Instantiate(ListSideMount[RNG]);
            SideMount.transform.parent = SourceSideMount.transform;
            SideMount.transform.localPosition = new Vector3(0f, 0f, 0f);
            Debug.Log("Gun Side Mount Extension has spawned");
        }
    }

    void BarrelUnderMountgen()
    {
        if (CustomGun == false)
        {
            if (GameObject.FindGameObjectWithTag("GunUnderMountSource") != null)
            {
                SourceUnderMount = null;
                SourceUnderMount = GameObject.FindGameObjectWithTag("GunUnderMountSource");
            }
        }

        int RNG = Random.Range(0, ListUnderMount.Count);
        Debug.Log("Mag RNG =" + RNG);

        {
            GameObject UnderMount = (GameObject)Instantiate(ListUnderMount[RNG]);
            UnderMount.transform.parent = SourceUnderMount.transform;
            UnderMount.transform.localPosition = new Vector3(0f, 0f, 0f);
            Debug.Log("Gun Under Mount Extension has spawned");
        }
    }
}