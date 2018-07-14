using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuoteState : PageState
{
    public override void Enter()
    {
        base.Enter();

        AppMain.Instance.SetNavState(false);
    }
}
