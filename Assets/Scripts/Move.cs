using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Move : MonoBehaviour

    
{

    bool move = true;
    string entrada = string.Empty;
    int contador = 0;
    bool direction = false;


    public bool moveUp = true;
    public bool moveDown = true;
    public bool moveRight = true;
    public bool moveLeft = true;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (move)
        {
            
            if (Input.GetKey("right") && moveRight)
            {
                entrada = "right";
                move = false;
                contador++;
            }
            
            else if (Input.GetKey("left") && moveLeft)
            {
                entrada = "left";
                move = false;
                contador++;
            }

            else if (Input.GetKey("up") && moveUp)
            {
                entrada = "up";
                move = false;
                contador++;
            }

            else if (Input.GetKey("down") && moveDown)
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
                    direction = moveRight;
                    break;

                case "left":
                    gameObject.transform.Translate(-0.00485f, 0, 0);
                    direction = moveLeft;
                    break;
                case "up":
                    gameObject.transform.Translate(0,0.00485f,0);
                    direction = moveUp;
                    break;

                case "down":
                    gameObject.transform.Translate(0,-0.00485f, 0);
                    direction = moveDown;
                    break;

            }

            contador++;
            if (contador >= 100) {

                if (direction) {
                    contador = 1;
                }
                else
                {
                    contador = 0;
                    move = true;
                }
                
            }


        }

        

    }

}
