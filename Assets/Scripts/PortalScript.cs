using UnityEngine;

public class PortalScript : MonoBehaviour
{
    public bool isRed = true;
    public Camera player1RedCamera;
    public Camera player2BlueCamera;
    public Camera player1RedPortalCamera;
    public Camera player2BluePortalCamera;
    public Vector3 RedPortalPosition;
    public Quaternion RedPortalRotation;
    public Vector3 BluePortalPosition;
    public Quaternion BluePortalRotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player1RedCamera = GameObject.Find("Player1Red").GetComponentInChildren<Camera>();
        player2BlueCamera = GameObject.Find("Player2Blue").GetComponentInChildren<Camera>();
        if (gameObject.name == "Red Portal")
        {
            isRed = true;
            player1RedPortalCamera = GameObject.Find("PlayerRedViewOutRed").GetComponent<Camera>();
            player2BluePortalCamera = GameObject.Find("PlayerBlueViewOutRed").GetComponent<Camera>();
            RedPortalPosition = transform.position;
            RedPortalRotation = transform.rotation;
            BluePortalPosition = GameObject.Find("Blue Portal").transform.position;
            BluePortalRotation = GameObject.Find("Blue Portal").transform.rotation;
        }
        else
        {
            isRed = false;
            player1RedPortalCamera = GameObject.Find("PlayerRedViewOutBlue").GetComponent<Camera>();
            player2BluePortalCamera = GameObject.Find("PlayerBlueViewOutBlue").GetComponent<Camera>();
            BluePortalPosition = transform.position;
            BluePortalRotation = transform.rotation;
            RedPortalPosition = GameObject.Find("Red Portal").transform.position;
            RedPortalRotation = GameObject.Find("Red Portal").transform.rotation;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isRed)
        {
            player1RedPortalCamera.transform.position = RedPortalPosition + (player1RedCamera.transform.position - BluePortalPosition);
            player1RedPortalCamera.transform.LookAt(RedPortalPosition);
            player2BluePortalCamera.transform.position = BluePortalPosition + (player2BlueCamera.transform.position - RedPortalPosition);
            player2BluePortalCamera.transform.LookAt(BluePortalPosition);
        }
        //player1RedPortalCamera.transform.position = BluePortalPosition + (player2BlueCamera.transform.position - RedPortalPosition);
        //player2BluePortalCamera.transform.position = RedPortalPosition + (player1RedCamera.transform.position - BluePortalPosition);
    }
}
