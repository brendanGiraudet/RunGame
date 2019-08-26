using UnityEngine;

public class FollowVehicule : MonoBehaviour
{
    public Transform Vehicule;
    public Vector3 offSet;
    // Update is called once per frame
    void Update()
    {
        transform.position = Vehicule.position + offSet;
    }
}
