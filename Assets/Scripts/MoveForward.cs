using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed;

    private const int LeftMouseButton = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton))
        {
            Debug.Log("Left mouse click");
            Debug.Log(Input.mousePosition.x);
            Debug.Log(Input.mousePosition.y);
        }
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
