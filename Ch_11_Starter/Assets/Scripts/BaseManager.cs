using UnityEngine;

public abstract class BaseManager : MonoBehaviour
{
   protected string _state = "Manager is not initialized...";
   public abstract string State { get; set; }
   public abstract void Initialize();
}
