using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject applePrefab;
    // Start is called before the first frame update

    public float speed = 5f;
    public float leftAndRightEdge = 20f;
    public float changeDirChange = 0.0000001f;
    public float appleDropDelay = 1f;
    void Start()
    {
        // start dropping apples
        Invoke("DropApple", 2);
    }

    // Update is called once per frame
    void Update()
    {
        // basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // changing direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);

        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
    void FixedUpdate()
    {
        if (Random.value < changeDirChange)
        {
            speed *= -1;
        }
    }
    void DropApple()
        {
            GameObject apple = Instantiate<GameObject>(applePrefab);
            apple.transform.position = transform.position;
            Invoke("DropApple", appleDropDelay);
        }
    }