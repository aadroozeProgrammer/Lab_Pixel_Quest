using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeoController : MonoBehaviour
{
    private Rigidbody2D rb;
    public int speed = 5;
    public string nextLevel = "Scene_2";
    private SpriteRenderer _spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
        _spriteRenderer.color = Color.red;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
        _spriteRenderer.color = Color.green;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _spriteRenderer.color = Color.blue;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Coin":
                {
                    Destroy(collision.gameObject);
                    break;
                }
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }

    }

}