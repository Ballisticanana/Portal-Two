using UnityEngine;

public class RedPortalScript : MonoBehaviour
{
    #region Store Values
    //player cameras & transform
    //player 1
    public Camera player1_Camera;
    public Transform player1_Transform;
    public Vector3 player1_Position;
    public Quaternion player1_Rotation;

    //player 2
    public Camera player2_Camera;
    public Transform player2_Transform;
    public Vector3 player2_Position;
    public Quaternion player2_Rotation;

    public string oooooooooooooooooooooooooooooooooooooooooooo;
    
    //player portal cameras & transform
    //player 1
    public Camera player1_ViewFromBlueCamera_Camera;
    public Transform player1_ViewFromBlueCamera_Transform;
    public Vector3 player1_ViewFromBlueCamera_Position;
    public Quaternion player1_ViewFromBlueCamera_Rotation;
    public Vector3 player1_ViewFromBlueCamera_NewPos;
    
    //player 2
    public Camera player2_ViewFromBlueCamera_Camera;
    public Transform player2_ViewFromBlueCamera_Transform;
    public Vector3 player2_ViewFromBlueCamera_Position;
    public Quaternion player2_ViewFromBlueCamera_Rotation;
    public Vector3 player2_ViewFromBlueCamera_NewPos;

    public string ooooooooooooooooooooooooooooooooooooooooooooo;
    
    //Portal transform
    //Red Portal
    public Transform redPortal_Transform;
    public Vector3 redPortal_Position;
    public Quaternion redPortal_Rotation;

    //Blue Portal
    public Transform bluePortal_Transform;
    public Vector3 bluePortal_Position;
    public Quaternion bluePortal_Rotation;
    #endregion

    void Start()
    {
        #region Set Values
        //player cameras & transform
        //player 1
        player1_Camera = GameObject.Find("Camera Player1").GetComponentInChildren<Camera>();
        player1_Transform = GameObject.Find("Camera Player1").GetComponent<Transform>();
        player1_Position = player1_Transform.transform.position;
        player1_Rotation = player1_Transform.transform.rotation;

        //player 2
        player2_Camera = GameObject.Find("Camera Player2").GetComponentInChildren<Camera>();
        player2_Transform = GameObject.Find("Camera Player2").GetComponent<Transform>();
        player2_Position = player2_Transform.transform.position;
        player2_Rotation = player2_Transform.transform.rotation;


        //player portal cameras & transform
        //player 1
        player1_ViewFromBlueCamera_Camera = GameObject.Find("ViewFromBlue Player1").GetComponent<Camera>();
        player1_ViewFromBlueCamera_Transform = GameObject.Find("ViewFromBlue Player1").GetComponent<Transform>();
        player1_ViewFromBlueCamera_Position = player1_ViewFromBlueCamera_Transform.transform.position;
        player1_ViewFromBlueCamera_Rotation = player1_ViewFromBlueCamera_Transform.transform.rotation;

        //player 2
        player2_ViewFromBlueCamera_Camera = GameObject.Find("ViewFromBlue Player2").GetComponent<Camera>();
        player2_ViewFromBlueCamera_Transform = GameObject.Find("ViewFromBlue Player2").GetComponent<Transform>();
        player2_ViewFromBlueCamera_Position = player2_ViewFromBlueCamera_Transform.transform.position;
        player2_ViewFromBlueCamera_Rotation = player2_ViewFromBlueCamera_Transform.transform.rotation;


        //portal transforms
        //Red Portal
        redPortal_Transform = GameObject.Find("Red Portal").GetComponent<Transform>();
        redPortal_Position = redPortal_Transform.transform.position;
        redPortal_Rotation = redPortal_Transform.transform.rotation;

        //Blue Portal
        bluePortal_Transform = GameObject.Find("Blue Portal").GetComponent<Transform>();
        bluePortal_Position = bluePortal_Transform.transform.position;
        bluePortal_Rotation = bluePortal_Transform.transform.rotation;
        #endregion
    }

    void Update()
    {
        #region Update Values
        //player cameras & transform
        //player 1
        player1_Position = player1_Transform.transform.position;
        player1_Rotation = player1_Transform.transform.rotation;

        //player 2
        player2_Position = player2_Transform.transform.position;
        player2_Rotation = player2_Transform.transform.rotation;


        //player portal cameras & transform
        //player 1
        player1_ViewFromBlueCamera_Position = player1_ViewFromBlueCamera_Transform.transform.position;
        player1_ViewFromBlueCamera_Rotation = player1_ViewFromBlueCamera_Transform.transform.rotation;

        //player 2
        player2_ViewFromBlueCamera_Position = player2_ViewFromBlueCamera_Transform.transform.position;
        player2_ViewFromBlueCamera_Rotation = player2_ViewFromBlueCamera_Transform.transform.rotation;


        //portal transforms
        //Red Portal
        redPortal_Position = redPortal_Transform.transform.position;
        redPortal_Rotation = redPortal_Transform.transform.rotation;

        //Blue Portal
        bluePortal_Position = bluePortal_Transform.transform.position;
        bluePortal_Rotation = bluePortal_Transform.transform.rotation;
        #endregion
        #region Manipulate Values
        player1_ViewFromBlueCamera_Transform.position = bluePortal_Transform.position;
        Vector3 newRot = bluePortal_Transform.eulerAngles;
        player1_ViewFromBlueCamera_Transform.eulerAngles = new Vector3(newRot.x, -newRot.y, newRot.z);
        Vector3 newPos = redPortal_Transform.TransformDirection(player1_Position - redPortal_Position);
        player1_ViewFromBlueCamera_Transform.localPosition -= new Vector3(newPos.x, newPos.y, newPos.z);
        //player1_ViewFromBlueCamera_Transform.eulerAngles = player1_Transform.eulerAngles + (bluePortal_Transform.eulerAngles - redPortal_Transform.eulerAngles) + new Vector3(0, 180, 0);
        #endregion
    }
}
//TransformDirection(bluePortal_Transform.position - redPortal_Transform.TransformDirection(redPortal_Transform.position - player1_Position));
//NOT TESTED
//player1_ViewFromBlueCamera_Transform.position = bluePortal_Transform.localPosition + redPortal_Transform.TransformDirection(redPortal_Transform.position - player1_Position);
//Debug.Log(Vector2.Distance(new Vector2(player1_Position.x, player1_Position.z), new Vector2(redPortal_Position.x, redPortal_Position.z)));
//Vector3 testVector = redPortal_Transform.TransformDirection(player1_Position - redPortal_Transform.localPosition).normalized;
//player1_ViewFromBlueCamera_Transform.position = bluePortal_Position + testVector;
//player1_ViewFromBlueCamera_Transform.eulerAngles = player1_Transform.eulerAngles + redPortal_Transform.eulerAngles - bluePortal_Transform.eulerAngles + new Vector3(0,180,0);
//Play with this tommorrow
