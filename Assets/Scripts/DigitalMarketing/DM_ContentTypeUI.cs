using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DM_ContentTypeUI : MonoBehaviour
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

    
    [SerializeField] private Button organicContentButton;
    [SerializeField] private Button paidContentButton;
    [SerializeField] private Button emailButton;
    [SerializeField] private Button graphicButton;
    [SerializeField] private Button videoButton;
    [SerializeField] private Button textButton;
    [SerializeField] private Button clickableAdButton;
    [SerializeField] private Button influencerOutreachButton;
    [SerializeField] private Button seoButton;
    [SerializeField] private Button videoAdButton;
    [SerializeField] private Button confirmButton;
    [SerializeField] private GameObject infoPopUp;
    [SerializeField] private TextMeshProUGUI infoPopUpText;

    private State state;
    private string chosenContent = null;



    private void Awake()
    {
        ShowCanvas();
        HideOrganicOptions();
        HidePaidOptions();
        HideInfoPopUp();
        
        organicContentButton.onClick.AddListener(() =>
        {
            HideOrganicPaidButtons();
            ShowOrganicOptions();
        });

        paidContentButton.onClick.AddListener(() =>
        {
            HideOrganicPaidButtons();
            ShowPaidOptions();
        });

        emailButton.onClick.AddListener(() => { state = State.Email; ShowInfoPopUp();});
        graphicButton.onClick.AddListener(() => { state = State.Graphic; ShowInfoPopUp();});
        videoButton.onClick.AddListener(() => { state = State.Video; ShowInfoPopUp();});
        textButton.onClick.AddListener(() => { state = State.Text; ShowInfoPopUp();});
        clickableAdButton.onClick.AddListener(() => { state = State.ClickableAd; ShowInfoPopUp();});
        influencerOutreachButton.onClick.AddListener(() => { state = State.InfluencerOutreach; ShowInfoPopUp();});
        seoButton.onClick.AddListener(() => { state = State.SEOButton; ShowInfoPopUp();});
        videoAdButton.onClick.AddListener(() => { state = State.VideoAd; ShowInfoPopUp();});

        confirmButton.onClick.AddListener(() => { state = State.Default; ConfirmButtonChoice();});

        state = State.Default;

    }

    private void Start()
    {
        ShowOrganicPaidButtons();
    }


    private void Update()
    {
        if (state != State.Default)
            switch (state)
            {
                case State.Email:
                    infoPopUpText.text = "This is an email";
                    chosenContent = "Email";
                    break;
                case State.Graphic:
                    infoPopUpText.text = "This is an graphic";
                    chosenContent = "Graphic";
                    break;
                case State.Video:
                    infoPopUpText.text = "This is a video";
                    chosenContent = "Video";
                    break;
                case State.Text:
                    infoPopUpText.text = "This is a text";
                    chosenContent = "Text";
                    break;
                case State.ClickableAd:
                    infoPopUpText.text = "This is a clickable ad";
                    chosenContent = "ClickableAd";
                    break;
                case State.InfluencerOutreach:
                    infoPopUpText.text = "This is influencer outreach";
                    chosenContent = "InfluencerOutreach";
                    break;
                case State.SEOButton:
                    infoPopUpText.text = "This is SEO";
                    chosenContent = "SEO";
                    break;
                case State.VideoAd:
                    infoPopUpText.text = "This is a video ad";
                    chosenContent = "VideoAd";
                    break;
            }
    }


    private void ShowOrganicPaidButtons()
    {
        organicContentButton.gameObject.SetActive(true);
        paidContentButton.gameObject.SetActive(true);
    }

    private void HideOrganicPaidButtons()
    {
        organicContentButton.gameObject.SetActive(false);
        paidContentButton.gameObject.SetActive(false);
    }
    
    
    private void ShowOrganicOptions()
    {
        emailButton.gameObject.SetActive(true);
        graphicButton.gameObject.SetActive(true);
        videoButton.gameObject.SetActive(true);
        textButton.gameObject.SetActive(true);
    }

    private void HideOrganicOptions()
    {
        emailButton.gameObject.SetActive(false);
        graphicButton.gameObject.SetActive(false);
        videoButton.gameObject.SetActive(false);
        textButton.gameObject.SetActive(false);
    }


    private void ShowPaidOptions()
    {
        clickableAdButton.gameObject.SetActive(true);
        influencerOutreachButton.gameObject.SetActive(true);
        seoButton.gameObject.SetActive(true);
        videoAdButton.gameObject.SetActive(true);
    }

    
    private void HidePaidOptions()
    {
        clickableAdButton.gameObject.SetActive(false);
        influencerOutreachButton.gameObject.SetActive(false);
        seoButton.gameObject.SetActive(false);
        videoAdButton.gameObject.SetActive(false);
    }


    private void ShowInfoPopUp()
    {
        infoPopUp.gameObject.SetActive(true);
        confirmButton.gameObject.SetActive(true);
    }

    private void HideInfoPopUp()
    {
        infoPopUp.gameObject.SetActive(false);
        confirmButton.gameObject.SetActive(false);
    }


    private void ConfirmButtonChoice()
    {
        // HideOrganicPaidButtons();
        // HideOrganicOptions();
        // HidePaidOptions();
        // HideInfoPopUp();

        HideCanvas();

        state = State.Default;
        Debug.Log(chosenContent);
    }

    private void ShowCanvas()
    {
        gameObject.SetActive(true);
    }
    
    private void HideCanvas()
    {
        gameObject.SetActive(false);
    }

}
