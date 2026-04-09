using UnityEngine;
using UnityEngine.UI;

public class ContentTypeUI : MonoBehaviour
{
    [SerializeField] private Button organicContentButton;
    [SerializeField] private Button paidContentButton;


    private void Awake()
    {
        HideOrganicOptions();
        HidePaidOptions();
        
        organicContentButton.onClick.AddListener(() =>
        {
            ShowOrganicOptions();
        });

        paidContentButton.onClick.AddListener(() =>
        {
            ShowPaidOptions();
        });
    }


    private void ShowOrganicOptions()
    {
        
    }

    private void HideOrganicOptions()
    {
        
    }


    private void ShowPaidOptions()
    {
        
    }

    
    private void HidePaidOptions()
    {
        
    }
}
