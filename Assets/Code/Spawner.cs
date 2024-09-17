using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Declaro el temporizador, Serialized establece que no puede ser modificado ni accedido fuera de este script
    [SerializeField] public float timeRemaining = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            //Aquí el spawneo
            timeRemaining = 30;
        }
    }
}
