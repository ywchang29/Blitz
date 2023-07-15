using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour
{
    public float horiziontal_speed = 0.2f;
    public float vertiontal_speed = 0.2f;
    private Renderer re;
    
    
    // Start is called before the first frame update
    void Start()
    {
        re = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * horiziontal_speed, Time.time * vertiontal_speed);
        re.material.mainTextureOffset = offset;
    }
}
