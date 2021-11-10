using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DestroyAfter3Triggers : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    public int LivesRemaining;
    public Image[] Lives;
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            Destroy(other.gameObject);
            LosingLife();
            if (LivesRemaining==0){
            Destroy(this.gameObject);
            Application.Quit();
            }
        }
    }

    public void LosingLife(){
        LivesRemaining--;
        Lives[LivesRemaining].enabled = false;
    }
}
