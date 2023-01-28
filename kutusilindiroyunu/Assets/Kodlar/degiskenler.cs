using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class degiskenler : MonoBehaviour
{
    // Start is called before the first frame update
    public int donmeHizi = 4;
    public float hiz = 0.1f;

    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(hiz, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(-hiz, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.up, -donmeHizi);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.up, donmeHizi);
        }
    }
}