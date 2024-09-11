using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePickerScript : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject basketPrefab;
    public int numbaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numbaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject> (basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (i * basketSpacingY);
            tBasketGO.transform.position = pos;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
