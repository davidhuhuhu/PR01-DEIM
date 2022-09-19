using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuevoMetodo : MonoBehaviour


{
    [SerializeField] float shield = 100;
    [SerializeField] float hp = 100;
    [SerializeField] bool alive = true;
    [SerializeField] int ammo = 200;
    [SerializeField] int lifes = 3;
    [SerializeField] string message = "holi";

    // Start is called before the first frame update
    void Start()
    {
        lifes = 3;
        shield = 100f;
        
   


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Han pulsado el espacio");
            if(alive)
             Impacto();


        }
    }

    //Nuevo mtodo

    public void Impacto()
    {
    
        hp = Random.Range(1f, 100f);
        shield -= hp;
        

        if(shield < 0)
        {

            lifes--;
            if (lifes == 0) 
            {
                message = "has morido";
                alive = false;

            }
            else
            {
                shield = 100f;
                message = "Una vida menos crack, te quedan" + lifes;
                //Invoke("impacto", 10f);

            }
         
         
        }
        //-1 vida pero no he muerto todavia
        else
        {
            shield = 100f;
            message = "te han impactado" + hp + "te queda " + shield + "de vida";
            //Invoke("impacto", 10f);
            // La variable "n" debe valer lo que vale el numero de vidas que has asignado anteriormente, en este caso la variable "lifes"
            //Esto es un bucle

            for (int n = lifes; n > 0; n--)
            {
                print("parpadea la vida" + n);
            }
        }

       

        print(message);


      

    }

}

