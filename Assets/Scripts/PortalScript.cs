using UnityEngine;
using UnityEngine.UIElements;

public class PortalScript : MonoBehaviour
{
    public bool isRed;

    //player cameras & transform
    public Camera player1RedCamera;
    public Transform player1RedTransform;
    public Vector3 player1RedPosition;
    public Quaternion player1RedRotation;

    public Camera player2BlueCamera;
    public Transform player2BlueTransform;
    public Vector3 player2BluePosition;
    public Quaternion player2BlueRotation;


    //player portal cameras & transform
    public Camera player1RedPortalCamera;
    public Transform player1RedPortalCameraTransform;
    public Vector3 player1RedPortalCameraPosition;
    public Quaternion player1RedPortalCameraRotation;

    public Camera player2BluePortalCamera;
    public Transform player2BluePortalCameraTransform;
    public Vector3 player2BluePortalCameraPosition;
    public Quaternion player2BluePortalCameraRotation;


    //Portal transform
    public Transform redPortalTransform;
    public Vector3 redPortalPosition;
    public Quaternion redPortalRotation;

    public Transform bluePortalTransform;
    public Vector3 bluePortalPosition;
    public Quaternion bluePortalRotation;


    void Start()
    {
        //player cameras & transform
        player1RedCamera = GameObject.Find("CameraRed").GetComponentInChildren<Camera>();
        player1RedTransform = GameObject.Find("CameraRed").GetComponent<Transform>();

        player2BlueCamera = GameObject.Find("CameraBlue").GetComponentInChildren<Camera>();
        player2BlueTransform = GameObject.Find("CameraBlue").GetComponent<Transform>();

        if (gameObject.name == "Red Portal")
        {
            isRed = true;
            //player portal cameras & transform
            player1RedPortalCamera = GameObject.Find("PlayerRedViewOutRed").GetComponent<Camera>();
            player1RedPortalCameraTransform = GameObject.Find("PlayerRedViewOutRed").GetComponent<Transform>();
            
            player2BluePortalCamera = GameObject.Find("PlayerBlueViewOutRed").GetComponent<Camera>();
            player2BluePortalCameraTransform = GameObject.Find("PlayerBlueViewOutRed").GetComponent<Transform>();
            
            //portal transforms needs updates
            redPortalTransform = GameObject.Find("Red Portal").GetComponent<Transform>();
            
            bluePortalTransform = GameObject.Find("Blue Portal").GetComponent<Transform>();
            
        }
        else
        {
            isRed = false;
            //player portal cameras & transform
            player1RedPortalCamera = GameObject.Find("PlayerRedViewOutBlue").GetComponent<Camera>();
            player1RedPortalCameraTransform = GameObject.Find("PlayerRedViewOutBlue").GetComponent<Transform>();

            player2BluePortalCamera = GameObject.Find("PlayerBlueViewOutBlue").GetComponent<Camera>();
            player2BluePortalCameraTransform = GameObject.Find("PlayerBlueViewOutBlue").GetComponent<Transform>();

            //portal transforms needs updates
            redPortalTransform = GameObject.Find("Red Portal").GetComponent<Transform>();

            bluePortalTransform = GameObject.Find("Blue Portal").GetComponent<Transform>();
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //player cameras & transform
        player1RedPosition = player1RedTransform.transform.position;
        player1RedRotation = player1RedTransform.transform.rotation;

        player2BluePosition = player2BlueTransform.transform.position;
        player2BlueRotation = player2BlueTransform.transform.rotation;

        //player portal cameras & transform
        player1RedPortalCameraPosition = player1RedPortalCameraTransform.position;
        player1RedPortalCameraRotation = player1RedPortalCameraTransform.rotation;

        player2BluePortalCameraPosition = player2BluePortalCameraTransform.position;
        player2BluePortalCameraRotation = player2BluePortalCameraTransform.rotation;

        //portal transforms needs updates
        redPortalPosition = player1RedPortalCameraTransform.position;
        redPortalRotation = player1RedPortalCameraTransform.rotation;

        bluePortalPosition = bluePortalTransform.position;
        bluePortalRotation = bluePortalTransform.rotation;

        if (isRed)
        {
            player1RedPortalCameraTransform.transform.position = bluePortalTransform.position + player1RedTransform.position - redPortalTransform.position;
            player1RedPortalCameraTransform.transform.rotation = bluePortalRotation * player1RedRotation;
            Vector3.Distance(player1RedTransform.position, redPortalTransform.position);
        }
        else
        {
            Debug.Log("test");
        }
    }
}
