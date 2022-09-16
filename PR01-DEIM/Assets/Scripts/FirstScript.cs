using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
    // Para combiar el nombre de todas las variables es RMB en la declarada al principio y cambiar nombre
    // == comparar, = es declarar
{
    [SerializeField] float shield = 100;
    [SerializeField] float hp = 100;
    [SerializeField] bool alive;
    [SerializeField] int ammo = 200;
    [SerializeField] int lifes = 3;
    [SerializeField] string message = "holi";

    //variables de Unity

    [SerializeField] Vector3 MyVector;
    [SerializeField] GameObject MyObject;
    int n = 0;
    


    void Start()
    {
        print(hp);
        hp = 100f;
        if (hp > 0) alive = true;
        if (hp <= 0) alive = false;
        if (alive == false) Destroy(MyObject);




        /*
        float PowerUp = 50f;
        shield = shield + PowerUp;
        message = "tu escudo es:" + shield + "flops";
        print(shield);
        */



    }

    // Update is called once per frame
    void Update()
    {
        print("fotograma: " + n);
        n++;
        if (n <= 500)
        {
            print("Ha llegado a 500");
        }

        else if(n <= 1000)
        {
            print("Hemos llegado a 1000");
        }
    
    
    
    }
}
