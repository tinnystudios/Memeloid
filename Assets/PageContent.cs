using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PageContent : MonoBehaviour {

    [SerializeField] private ScrollRect m_ScrollRect;
    [SerializeField] private bool mHorizontalScroll = true;

    private void Awake()
    {
        m_ScrollRect.horizontal = mHorizontalScroll;
    }

}
