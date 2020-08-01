using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text textscore;
    public Transform player;

    private void Update()
    {
        textscore.text = player.position.z.ToString("0");
    }

}
