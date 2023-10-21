using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counterscript : MonoBehaviour
{
    public Text countertext;
    public collisionscript One;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countertext.text = "score: " + One.score;
    }
}
