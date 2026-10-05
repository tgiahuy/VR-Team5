using UnityEngine;

public class InfoPanelController : MonoBehaviour
{
    public GameObject infoPanel;

    public void OpenPanel()
    {
        infoPanel.SetActive(true);
    }

    public void ClosePanel()
    {
        infoPanel.SetActive(false);
    }
}