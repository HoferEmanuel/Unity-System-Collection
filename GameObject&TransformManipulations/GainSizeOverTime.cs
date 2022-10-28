using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GainSizeOverTime : MonoBehaviour
{
    public float sizeOverTime = 2;
    public bool useDecay = false;
    public float decayTime = 1;
    float decayTimer = 0;

    private void Update()
    {
        transform.localScale += new Vector3(sizeOverTime, sizeOverTime, sizeOverTime);

        if (useDecay)
        {
            decayTimer += Time.deltaTime;

            if (decayTimer >= decaytime)
                Destroy(gameObject);
        }
    }
}