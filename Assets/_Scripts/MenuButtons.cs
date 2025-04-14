using System.Collections;
using UnityEngine;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject _menuWindow;
    [SerializeField] private GameObject _levelsWindow;
    [SerializeField] private GameObject _skinsWindow;
    [SerializeField] private GameObject _settingsWindow;
    [SerializeField] private GameObject _planesSkinsWindow;
    [SerializeField] private GameObject _backsSkinsWindow;
    [SerializeField] private GameObject _howToPlayWindow;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void ClickPlayBtn()
    {
        StartCoroutine(SwitchWindows(_menuWindow, false, _levelsWindow, true));
    }

    public void ClickCloseLevelsWindow()
    {
        StartCoroutine(SwitchWindows(_levelsWindow, false, _menuWindow, true));
    }

    public void ClickSkinsBtn()
    {
        StartCoroutine(SwitchWindows(_menuWindow, false, _skinsWindow, true));
    }

    public void ClickCloseSkinsBtn()
    {
        StartCoroutine(SwitchWindows(_skinsWindow, false, _menuWindow, true));
    }

    public void ClickSettingsBtn()
    {
        StartCoroutine(SwitchWindows(_menuWindow, false, _settingsWindow, true));
    }

    public void ClickCloseSettingsBtn()
    {
        StartCoroutine(SwitchWindows(_settingsWindow, false, _menuWindow, true));
    }

    public void OpenPlanes()
    {
        StartCoroutine(SwitchWindows(_backsSkinsWindow, false, _planesSkinsWindow, true));
    }

    public void OpenBacks()
    {
        StartCoroutine(SwitchWindows(_planesSkinsWindow, false, _backsSkinsWindow, true));
    }

    public void OpenHowToPlay()
    {
        StartCoroutine(SwitchWindows(_menuWindow, false, _howToPlayWindow, true));
    }

    public void CloseHowToPlay()
    {
        StartCoroutine(SwitchWindows(_howToPlayWindow, false, _menuWindow, true));
    }

    private IEnumerator SwitchWindows(GameObject toDisable, bool disableState, GameObject toEnable, bool enableState)
    {
        yield return new WaitForSeconds(0.2f);
        if (toDisable != null) toDisable.SetActive(disableState);
        if (toEnable != null) toEnable.SetActive(enableState);
    }
}
