using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateStuff;

public class AI : MonoBehaviour
{
    [SerializeField]
    public Transform Player;
    public bool switchState = false;
    public float gameTimer;
    public int seconds = 0;
    int attackFlag = 0;
    int attackFlagPrev = 0;

    public StateMachine<AI> stateMachine { get; set; }

    private void Start()
    {
        stateMachine = new StateMachine<AI>(this);
        stateMachine.ChangeState(FirstState.Instance);
        gameTimer = Time.time;
        //SecondState.Player = Player;
    }

    private void Update()
    {
        if (attackFlag == 1 && attackFlagPrev == 0)
        {
            attackFlagPrev = 1;
            seconds = 0;
            switchState = !switchState;
        }

        attackFlag = RushTrigger.attackFlag;

        stateMachine.Update();
    }
}
