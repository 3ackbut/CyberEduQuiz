// ファイル名: StartQuizButton.cs
using UnityEngine;
using UnityEngine.SceneManagement; // シーン遷移に必要

public class StartQuizButton : MonoBehaviour
{
    // この関数がボタン押下時に呼ばれる
    public void OnStartQuiz()
    {
        // "Quiz" は、遷移先のシーン名（後で作成）
        SceneManager.LoadScene("Quiz");
    }
}
