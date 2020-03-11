using UnityEngine;
using UnityEngine.UI;
public class SwordMerchant : MonoBehaviour
{
    [SerializeField]
    private Text swordName;
    [SerializeField]
    private Text description;
    [SerializeField]
    private Image icon;
    [SerializeField]
    private Text goldCost;
    [SerializeField]
    private Text atackDamage;

    public void UpdateDisplayUI(SwordData swordData)
    {
        swordName.text = swordData.SwordName;
        description.text = swordData.Description;
        icon.sprite = swordData.Icon;
        goldCost.text = swordData.GoldCost.ToString();
        atackDamage.text = swordData.AttackDamage.ToString();
    }
}
