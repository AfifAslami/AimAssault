using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Import package TextMeshPro

public class ScoreManager : MonoBehaviour
{
    public int scorePerTarget = 10; // Nilai skor yang ditambahkan setiap kali target dihancurkan
    public int score = 0; // Variabel untuk menyimpan nilai skor
    public TextMeshProUGUI TextScore; // Referensi ke UI Text atau UI Text Mesh Pro yang menampilkan skor

    private void Start()
    {
        TextScore = GetComponent<TextMeshProUGUI>(); // Inisialisasi variabel TextScore dengan komponen TextMeshProUGUI yang terdapat pada game object ini
        UpdateScoreUI(); // Memperbarui tampilan UI Text atau UI Text Mesh Pro dengan nilai skor awal
    }

    public void AddScore()
    {
        score += scorePerTarget; // Tambahkan skor
        UpdateScoreUI(); // Memperbarui tampilan UI Text atau UI Text Mesh Pro dengan nilai skor yang terbaru
    }

    void UpdateScoreUI()
    {
        TextScore.text = "Score: " + score.ToString(); // Memperbarui tampilan UI Text atau UI Text Mesh Pro dengan nilai skor yang terbaru
    }
}