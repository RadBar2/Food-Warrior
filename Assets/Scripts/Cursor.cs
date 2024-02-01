using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public TextMeshProUGUI counter;

    int score = 0;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        counter.text = (++score).ToString();
    }
}
