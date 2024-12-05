using UnityEngine;

public class Turret : MonoBehaviour
{



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player1Red" )
        {
            Debug.Log("I SEEEEE YOUUUUUUU");
        }
    }
}
