using UnityEngine;
using UnityEngine.InputSystem;

public class MoverCoiso : MonoBehaviour
{
    public Rigidbody jogador;
    
    void Start()
    {
        
    }

    void Update()
    {
      jogador.AddForce(0,0,0);
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            jogador.AddForce(-2,0,0);
        }    
        if (Keyboard.current.rightArrowKey.isPressed)
         {
            jogador.AddForce(2,0,0);
        }    
         if (Keyboard.current.upArrowKey.isPressed)
        {
            jogador.AddForce(0,0,2);
        }    
        if (Keyboard.current.downArrowKey.isPressed)
         {
            jogador.AddForce(0,0,-2);
        }    
    }
}
