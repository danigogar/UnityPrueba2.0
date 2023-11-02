using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour

    
{

    bool move = true;
    string entrada = string.Empty;
    int contador = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (move)
        {
            
            if (Input.GetKey("right"))
            {
                entrada = "right";
                move = false;
                contador++;
            }
            
            else if (Input.GetKey("left"))
            {
                entrada = "left";
                move = false;
                contador++;
            }

            else if (Input.GetKey("up"))
            {
                entrada = "up";
                move = false;
                contador++;
            }

            else if (Input.GetKey("down"))
            {
                entrada = "down";
                move = false;
                contador++;
            }
        }

        if (contador > 0) {

            // hay que sumar 0.480
            switch (entrada) {
                case "right":
                    gameObject.transform.Translate(0.00485f, 0, 0);
                    break;

                case "left":
                    gameObject.transform.Translate(-0.00485f, 0, 0);
                    break;
                case "up":
                    gameObject.transform.Translate(0,0.00485f,0);
                    break;

                case "down":
                    gameObject.transform.Translate(0,-0.00485f, 0);
                    break;

            }

            contador++;
            if (contador >= 100) { 
                contador = 0;
                move = true;
            }


        }

        

        
        
    }
}
