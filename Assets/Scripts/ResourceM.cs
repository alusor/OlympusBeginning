using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResourceM : MonoBehaviour {

    private int coins = 0;
    private int thunders = 0;
    public Text coinsText;
    public Text thundersText;
    // Use this for initialization
    void Awake() {
        if (PlayerPrefs.HasKey("coins"))
        {
            coins = PlayerPrefs.GetInt("coins");
        }
        else {
            PlayerPrefs.SetInt("coins",0);
        }
        if (PlayerPrefs.HasKey("thunders"))
        {
            thunders = PlayerPrefs.GetInt("thunders");
        }
        else {
            PlayerPrefs.SetInt("thunders",0);
        }
    }

    void Start () {
        coinsText.text = coins.ToString();
        thundersText.text = thunders.ToString();
	}

    public void alterCoins(int coins) {
        this.coins += coins;
        coinsText.text = this.coins.ToString();  
    }
    public void alterThunders(int thunders) {
        this.thunders += thunders;
        thundersText.text = this.thunders.ToString();
    }

    public void saveData() {
        PlayerPrefs.SetInt("coins",coins);
        PlayerPrefs.SetInt("thunders",thunders);
    }
}
