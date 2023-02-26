using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointSystem : MonoBehaviour
{
    public TextMeshProUGUI textLeft;
    public TextMeshProUGUI textRight;
    public TextMeshProUGUI pointWin;

    int pointsLeft = 0;
    int pointsRight = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("WallLeft"))
        {
            pointsRight++;
            textRight.text = pointsRight.ToString();
            WinPointText("Right player wins a point!");
        }

        if (collision.gameObject.CompareTag("WallRight"))
        {
            pointsLeft++;
            textLeft.text = pointsLeft.ToString();
            WinPointText("Left player wins a point!");
        }
    }

    void WinPointText(string text)
    {
        pointWin.gameObject.SetActive(true);
        pointWin.text = text;
        Invoke(nameof(HideWinPointText), 3f);
    }

    void HideWinPointText()
    {
        pointWin.gameObject.SetActive(false);
    }

    
}
