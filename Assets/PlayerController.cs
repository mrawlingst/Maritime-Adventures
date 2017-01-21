using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float MoveSpeed = 20;
    public float RotateSpeed = 50;
    public bool Movable = true;

	void Update()
    {
        if (!Movable)
            return;
        // Movement with keyboard
        float rotate = Input.GetAxis("Horizontal") * Time.deltaTime * RotateSpeed;
        float move = Input.GetAxis("Vertical") * Time.deltaTime * MoveSpeed;

        transform.Rotate(0, rotate, 0);
        transform.Translate(0, 0, move);
	}
}
