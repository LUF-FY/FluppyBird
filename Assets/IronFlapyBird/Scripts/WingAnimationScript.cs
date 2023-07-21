using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingAnimationScript : MonoBehaviour
{
    public Rigidbody2D bird;
    public Sprite wingUp;
    public Sprite wingDown;

    private SpriteRenderer _renderer;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (bird.velocity.y <= 0)
        {
            _renderer.sprite = wingUp;
        }
        else
        {
            _renderer.sprite = wingDown;
        }
    }
}
