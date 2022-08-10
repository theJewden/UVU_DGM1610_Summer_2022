
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent onRaiseEvent;

    private void Start()
    {
        gameActionObj.raise += Raise; //When this game action is called it will call this action
    }

    private void Raise()
    {
        onRaiseEvent.Invoke();
    }
}
