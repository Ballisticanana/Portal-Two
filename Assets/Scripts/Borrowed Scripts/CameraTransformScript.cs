using UnityEngine;

public class CameraTransformScript : MonoBehaviour
{
    public Transform playerCameraTransform;
    public Transform portalTransform;
    public Transform otherPortalTransform;
    void Update()
    {
        var vectorRelation = playerCameraTransform.position - otherPortalTransform.position;
        Debug.DrawLine(otherPortalTransform.position, otherPortalTransform.position + vectorRelation);
        vectorRelation = Quaternion.AngleAxis(-otherPortalTransform.eulerAngles.y + portalTransform.eulerAngles.y, Vector3.up) * vectorRelation;
        Debug.DrawLine(portalTransform.position, portalTransform.localPosition + new Vector3(-vectorRelation.x, vectorRelation.y, -vectorRelation.z));
        transform.position = portalTransform.localPosition + new Vector3(-vectorRelation.x, vectorRelation.y, -vectorRelation.z);
        transform.eulerAngles = playerCameraTransform.eulerAngles + (portalTransform.eulerAngles - otherPortalTransform.eulerAngles) + new Vector3(0, 180, 0);
    }
}
//
