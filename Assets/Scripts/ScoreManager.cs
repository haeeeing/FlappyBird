using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private GameManager gm;

    public void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Bird"))
        {
            gm.IncreaseScore();
            Debug.Log("+");
        }
    }
}
