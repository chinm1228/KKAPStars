using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayStats : MonoBehaviour
{
    public TextMeshProUGUI singStat, danceStat, rapStat, starPowerStat;

    void Awake()
    {
        //GameObject object = GameObject.Find("SingText");
        //singStat = gameObject.Find("Dance").GetComponent<TextMeshProUGUI>();
        //danceStat = gameObject.GetComponent<TextMeshProUGUI>();
        //rapStat = gameObject.GetComponent<TextMeshProUGUI>();
        //starPowerStat = gameObject.GetComponent<TextMeshProUGUI>();
        //danceStat = gameObject.Find("DanceText").GetComponent<Text>();
        //rapStat = gameObject.Find("RapText").GetComponent<Text>();
        //starPowerStat = gameObject.Find("StarPowerText").GetComponent<Text>();

    }

    void Update()
    {
        singStat.text = "Singing: " + DatabaseManager.database.getMainPlayer().GetSinging().ToString();
        danceStat.text = "Dancing: " + DatabaseManager.database.getMainPlayer().GetDancing().ToString();
        rapStat.text = "Rapping: " + DatabaseManager.database.getMainPlayer().GetRapping().ToString();
        starPowerStat.text = "Star Power: " + DatabaseManager.database.getMainPlayer().GetStarPower().ToString();
    }
}
