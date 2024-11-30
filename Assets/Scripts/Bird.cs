using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float flyPower;
    private float minY;
    private float maxY;
    
    private Rigidbody2D rb;
    private GameManager gm;



    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

        // 카메라 범위 가져오기
        minY = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y + 0.07f;
        maxY = Camera.main.ScreenToWorldPoint(new Vector3(0,Screen.height, 0)).y - 0.07f;
    }

    public void Update()
    {
        // 점프시키기
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fly();
        }

        // 화면 밖으로 나가지 않게
        Vector3 position = transform.position;
        position.y = Mathf.Clamp(position.y, minY, maxY);
        transform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Game Over");
    }

    private void Fly()
    {
        rb.velocity = Vector2.up * flyPower;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            gm.GameOver();
        }
    }
}
