using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DM_CharacteristicTypeUI : MonoBehaviour
{
    private enum State
    {
        Default,
        Email,
        Graphic,
        Video,
        Text,
        ClickableAd,
        InfluencerOutreach,
        SEOButton,
        VideoAd
    }


    [SerializeField] private Button highQualityButton;
    [SerializeField] private Button budgetFriendlyButton;
    [SerializeField] private Button packageDesignButton;
    [SerializeField] private Button ethicallyMadeButton;
    [SerializeField] private Button convenientButton;
    [SerializeField] private Button ecoFriendlyButton;
    [SerializeField] private Button uniqueDesignButton;
    [SerializeField] private Button familiarityButton;
    [SerializeField] private Button confirmButton;
    [SerializeField] private GameObject infoPopUp;
    [SerializeField] private TextMeshProUGUI infoPopUpText;


    private State state;
    private string chosenCharacteristic = null;


    private void Awake()
    {
        highQualityButton.onClick.AddListener(() => { state = State.Email; ShowInfoPopUp();});
        budgetFriendlyButton.onClick.AddListener(() => { state = State.Graphic; ShowInfoPopUp();});
        packageDesignButton.onClick.AddListener(() => { state = State.Video; ShowInfoPopUp();});
        ethicallyMadeButton.onClick.AddListener(() => { state = State.Text; ShowInfoPopUp();});
        convenientButton.onClick.AddListener(() => { state = State.ClickableAd; ShowInfoPopUp();});
        ecoFriendlyButton.onClick.AddListener(() => { state = State.InfluencerOutreach; ShowInfoPopUp();});
        uniqueDesignButton.onClick.AddListener(() => { state = State.SEOButton; ShowInfoPopUp();});
        familiarityButton.onClick.AddListener(() => { state = State.VideoAd; ShowInfoPopUp();});

        confirmButton.onClick.AddListener(() => { state = State.Default; ConfirmButtonChoice();});

        state = State.Default;

    }


    private void ShowInfoPopUp()
    {
        infoPopUp.gameObject.SetActive(true);
    }

    private void HideInfoPopUp()
    {
        infoPopUp.gameObject.SetActive(false);
    }

    private void ConfirmButtonChoice()
    {
        HideInfoPopUp();

        state = State.Default;
    }
}
