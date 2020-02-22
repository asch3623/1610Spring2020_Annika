using UnityEngine;

[RequireComponent(typeof(Camera))]

public class CameraController : MonoBehaviour
{
    //tutorial from https://www.youtube.com/watch?v=cfjLQrMGEb4, makes camera move with keys
    public float moveSpeed = 20f;
    // how far mouse goes before camera moves
    public float moveBorder = 10f;

    public Vector2 moveLimit;

    public float scrollSpeed = 20f;
    public float minY =20f;
    public float maxY = 120f;

    private Camera myCamera;

    void Update()
    {
        myCamera = GetComponent<Camera>();

        Vector3 pos = transform.position;

        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - moveBorder)
        {
            pos.z += moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey("s") || Input.mousePosition.y <= moveBorder)
        {
            pos.z -= moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - moveBorder)
        {
            pos.x += moveSpeed * Time.deltaTime;
        }

        if (Input.GetKey("a") || Input.mousePosition.x <= moveBorder)
        {
            pos.x -= moveSpeed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        pos.y -= scroll * scrollSpeed * 100f * Time.deltaTime;

        // designates a limit to values on which the variable can be

        pos.x = Mathf.Clamp(pos.x, -moveLimit.x, moveLimit.x);
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        pos.z = Mathf.Clamp(pos.z, -moveLimit.y, moveLimit.y);

        transform.position = pos;
    }
}
