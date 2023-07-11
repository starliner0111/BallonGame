using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject square;
    public Text text;
    public float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeSquare", 0f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        text.text = timer.ToString("N2");
    }

    public void MakeSquare()
    {
        Instantiate(square);
    }
}
