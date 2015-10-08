using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

   [SerializeField] private int life = 4;
   [SerializeField] private int score = 0;
    public GUIText textScore;
	public GUIText textEnemyLife;

    void OnTriggerEnter2D(Collider2D bullet) {
        life -= 1;
        Debug.Log("Vida do Iimigo = "+life);
		textEnemyLife.text = ("Vida do Inimigo " +life.ToString());
        if (life <= 0)
        {
            Debug.Log("Vida do Inimigo " + life);
            Debug.Log("Morreu");
            Destroy(this.gameObject);
        }
        score += 1;
        Debug.Log("Meus pontos = " + score);
        textScore.text = ("Score " +score.ToString());
    }
}
