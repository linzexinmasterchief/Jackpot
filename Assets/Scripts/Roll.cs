using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Roll : MonoBehaviour
{
    [SerializeField]
    public Material blue;
    [SerializeField]
    public Material gold;
    [SerializeField]
    public Material purple;
    [SerializeField]
    public SpriteRenderer bg;
    [SerializeField]
    public TMP_Text text;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clicked()
    {
        int i = Random.RandomRange(1, 100);
        if (i < 10)
        {
            // first
            First();
        }
        else if (i < 40)
        {
            // second
            Second();
        }
        else if (i < 100)
        {
            // third
            Third();
        }
    }

    void First()
    {
        text.SetText("FIRST PRIZE!");
        bg.material = gold;
    }

    void Second()
    {
        text.SetText("SECOND PRIZE!");
        bg.material = purple;
    }
    void Third()
    {
        text.SetText("THIRD PRIZE!");
        bg.material = blue;
    }

}
