using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePickerScript : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject basketPrefab;
    public int numbaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numbaskets; i++)
        {
            basketList = new List<GameObject>();
            GameObject tBasketGO = Instantiate<GameObject> (basketPrefab);
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (i * basketSpacingY);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
    }
    public void AppleMissed()
    {
        GameObject[] appleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tempGO in appleArray)
        {
            Destroy(tempGO);
        }
        int basketIndex = basketList.Count - 1;
        GameObject basketGO = basketList[basketIndex];

        if (basketList.Count == 0)
        {
            SceneManager.LoadScene("_Scene_0");
        }
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
