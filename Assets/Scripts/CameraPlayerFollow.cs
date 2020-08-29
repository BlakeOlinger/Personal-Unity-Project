using UnityEngine;

public class CameraPlayerFollow : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;

    // Update is called once per frame
    public void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x + offset.x,
            player.transform.position.y + offset.y,
            player.transform.position.z + offset.z);
    }
}
