using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static ParticleScript instance;
    void Awake()
    {
         if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return ;
        }

        DontDestroyOnLoad(gameObject);
    }
}
