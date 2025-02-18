using UnityEngine;

public class CombatManager : BaseManager
{
    public override string State
    {
        get { return _state; }
        set { _state = value; }
    }

    public override void Initialize()
    {
        _state = "Combat Manager initialized..";
        Debug.Log(_state);
    }
    
    public void Start()
    {
        Initialize();
    }
}
