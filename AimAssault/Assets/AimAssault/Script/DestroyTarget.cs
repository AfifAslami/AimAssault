using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTarget : MonoBehaviour
{
    private TargetSpawn spawn;
    private ScoreManager scoreManager;

    private void Start()
    {
        spawn = FindObjectOfType<TargetSpawn>();
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);

            // Tambahkan skor
            scoreManager.AddScore();

            // Kurangi jumlah musuh yang tersisa
            spawn.targetCounter--;

            // Jika jumlah musuh kurang dari 3, spawn musuh baru
            if (spawn.targetCounter < 3)
            {
                spawn.SpawnRandomTarget();
            }
        }
    }
}