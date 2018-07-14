using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NavigationBar : StateBase, ISubState
{
    public GameObject m_Content;
    public PageState mActiveState;
    public List<PageButton> mNavPageButtons;
    private PageButton mLastPage;

    private void Awake()
    {
        mNavPageButtons = m_Content.GetComponentsInChildren<PageButton>(includeInactive:true).ToList();

        foreach (var pageButton in mNavPageButtons)
        {
            pageButton.m_OnClick += OnPageClicked;
        }
    }

    private void OnPageClicked()
    {
        
    }

    public override IEnumerator OnTransitionIn()
    {
        m_Content.SetActive(true);
        yield break;
    }

    public override IEnumerator OnTransitionOut()
    {
        m_Content.SetActive(false);
        yield break;
    }

}
