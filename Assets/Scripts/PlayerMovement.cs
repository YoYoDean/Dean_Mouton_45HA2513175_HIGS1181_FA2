using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speedBoost = 5f;
    [SerializeField]
    private float sprintBoost = 10f;            //Declaring variables

    // Update is called once per frame
    void Update()
    {

        PlayerMove();//calling the move method
        
    }

    public void PlayerMove()
    {
        if (Keyboard.current.wKey.isPressed)//checking keyboard input
        {
            if (Keyboard.current.leftShiftKey.isPressed)//checking if sprint
            {
                transform.Translate(sprintBoost * Time.deltaTime * Vector2.up.normalized);//move up sprint
            }
            else
            {
                transform.Translate(speedBoost * Time.deltaTime * Vector2.up.normalized);//move up walk
            }

        }
        if (Keyboard.current.sKey.isPressed)//checking keyboard input
        {
            if (Keyboard.current.leftShiftKey.isPressed)//checking if sprint
            {
                transform.Translate(sprintBoost * Time.deltaTime * Vector2.down.normalized);//move down sprint
            }
            else
            {
                transform.Translate(speedBoost * Time.deltaTime * Vector2.down.normalized);//move down walk
            }
        }
        if (Keyboard.current.aKey.isPressed)//checking keyboard input
        {
            if (Keyboard.current.leftShiftKey.isPressed)//checking if sprint
            {
                transform.Translate(sprintBoost * Time.deltaTime * Vector2.left.normalized);//move left sprint
            }
            else
            {
                transform.Translate(speedBoost * Time.deltaTime * Vector2.left.normalized);//move left walk
            }
        }
        if (Keyboard.current.dKey.isPressed)//checking keyboard input
        {
            if (Keyboard.current.leftShiftKey.isPressed)//checking if sprint
            {
                transform.Translate(sprintBoost * Time.deltaTime * Vector2.right.normalized);//move right sprint
            }
            else
            {
                transform.Translate(speedBoost * Time.deltaTime * Vector2.right.normalized);//move right walk
            }
        }

    }
}
