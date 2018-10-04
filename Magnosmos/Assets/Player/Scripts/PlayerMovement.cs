using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [HideInInspector]
    public Rigidbody2D body;
    public float maxHorizontalMovement;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    public void SetHorizontalMovement(float speed)
    {
        if (Mathf.Abs(body.velocity.x) > maxHorizontalMovement)
        {
            body.velocity = new Vector2(body.velocity.x * (maxHorizontalMovement / Mathf.Abs(body.velocity.x)), body.velocity.y);
        }
        else
        {
            body.AddForce(Vector2.right * body.mass * speed, ForceMode2D.Impulse);
        }
    }

    public void AddVerticalMovement(float speed)
    {
        body.AddForce(Vector2.up * body.mass * speed, ForceMode2D.Impulse);
    }

    internal void BrakeHorizontalMovement(float brakeSpeed)
    {
        body.velocity = new Vector2(body.velocity.x * (1f - (brakeSpeed/100f)), body.velocity.y);
    }
}