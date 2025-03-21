using StarterAssets;
using UnityEngine;

public class DisableTurret : MonoBehaviour
{
    public Turret Linkedturret;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player2Blue")
        {
           Linkedturret.enabled = false;
            Debug.Log("hi");
        }
    }

}
