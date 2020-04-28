using UnityEngine;
namespace task_05
{
    public class task_05_trigger: MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject);
        }
    }
}