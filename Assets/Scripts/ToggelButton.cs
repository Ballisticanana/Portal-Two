using UnityEngine;

public class ToggelButton : MonoBehaviour
{
    public bool isRed;
    private bool isPressed=false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player1Red"&& isRed && !isPressed)
        {
            isPressed = true;
            transform.Translate(0,-.1f,0);
        }
        else if (other.gameObject.name == "Player2Blue" && !isRed && !isPressed)
        {
            isPressed = true;
            transform.Translate(0, -.1f, 0);
        }
    }
}
