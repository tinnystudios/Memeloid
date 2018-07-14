using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppMain : Singleton<AppMain> {

    public NavigationBar m_NavBar;
    public Header m_Header;

    // Use this for initialization
    void Start() {
        Screen.fullScreen = false;
        ApplicationChrome.statusBarState = ApplicationChrome.States.VisibleOverContent;
    }

    public void SetHeaderState(bool state)
    {
        if (state)
        {
            m_Header.Enter();
        }
        else
        {
            m_Header.Exit();
        }
    }

    public void SetNavState(bool state)
    {
        if (state)
        {
            m_NavBar.Enter();
        }
        else
        {
            m_NavBar.Exit();
        }
    }

}
