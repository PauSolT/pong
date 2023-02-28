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

    const int winPoints = 11;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("WallLeft"))
        {
            pointsRight++;
            textRight.text = pointsRight.ToString();
            if (pointsRight == winPoints)
                ResetGame("Right player wins!");
            else
                WinPointText("Right player wins a point!");
        }

        if (collision.gameObject.CompareTag("WallRight"))
        {
            pointsLeft++;
            textLeft.text = pointsLeft.ToString();
            if (pointsLeft == winPoints)
                ResetGame("Left player wins!");
            else
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

    private void ResetGame(string text)
    {
        WinPointText(text);

        pointsLeft = 0;
        pointsRight = 0;
        textLeft.text = pointsLeft.ToString();
        textRight.text = pointsRight.ToString();
    }


}
