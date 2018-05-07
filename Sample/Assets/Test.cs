using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Vector2 stratPos = new Vector2(2.0f, 1.0f);
        Vector2 endPos = new Vector2(8.0f, 5.0f);
        Vector2 dir = endPos - stratPos;
        Debug.Log(dir);

        float len = dir.magnitude;
        Debug.Log(len);

    }
}
=======
public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }
        Debug.Log(sum);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
>>>>>>> master
