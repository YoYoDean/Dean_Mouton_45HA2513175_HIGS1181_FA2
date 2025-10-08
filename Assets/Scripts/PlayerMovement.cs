using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speedBoost = 5f;
    [SerializeField]
    private float sprintBoost = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Keyboard.current.wKey.isPressed)
        {   if (Keyboard.current.leftShiftKey.isPressed)
            {
                transform.Translate(sprintBoost * Time.deltaTime * Vector2.up.normalized);
            }
            else
            {
                transform.Translate(speedBoost * Time.deltaTime * Vector2.up.normalized);
            }
            
        }
        if (Keyboard.current.sKey.isPressed)
        {
           if (Keyboard.current.leftShiftKey.isPressed)
            {
                transform.Translate(sprintBoost * Time.deltaTime * Vector2.down.normalized);
            }
            else
            {
                transform.Translate(speedBoost * Time.deltaTime * Vector2.down.normalized);
            }
        }
        if (Keyboard.current.aKey.isPressed)
        {
           if (Keyboard.current.leftShiftKey.isPressed)
            {
                transform.Translate(sprintBoost * Time.deltaTime * Vector2.left.normalized);
            }
            else
            {
                transform.Translate(speedBoost * Time.deltaTime * Vector2.left.normalized);
            }
        }
        if (Keyboard.current.dKey.isPressed)
        {
            if (Keyboard.current.leftShiftKey.isPressed)
            {
                transform.Translate(sprintBoost * Time.deltaTime * Vector2.right.normalized);
            }
            else
            {
                transform.Translate(speedBoost * Time.deltaTime * Vector2.right.normalized);
            }
        }
        
       
    }
}
