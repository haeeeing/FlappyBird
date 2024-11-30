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

        // ī�޶� ���� ��������
        minY = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y + 0.07f;
        maxY = Camera.main.ScreenToWorldPoint(new Vector3(0,Screen.height, 0)).y - 0.07f;
    }

    public void Update()
    {
        // ������Ű��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Fly();
        }

        // ȭ�� ������ ������ �ʰ�
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
