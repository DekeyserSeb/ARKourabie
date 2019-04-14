using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KourabieWhole_Borken_Sugar_Init : MonoBehaviour
{
    public GameObject Kourabie;
    public GameObject Kourabie_Broken;
    public GameObject Sugar_Particles;

    // Start is called before the first frame update
    void Start()
    {
        if (Kourabie != null && Kourabie_Broken != null && Sugar_Particles != null)
        {
            //to get only the good objects actives
            Kourabie.SetActive(true);
            Kourabie_Broken.SetActive(false);
            Sugar_Particles.SetActive(false);
        }
    }
}
