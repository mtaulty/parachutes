using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarScript : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (!this.hasCollided)
        {
            this.transform.Find("Full").gameObject.SetActive(false);
            this.transform.Find("Landed").gameObject.SetActive(true);
            this.hasCollided = true;
        }
        if (hasCollided && collision.relativeVelocity == Vector3.zero)
        {
            this.transform.Find("Landed").gameObject.SetActive(false);
            this.transform.Find("Stopped").gameObject.SetActive(true);
            this.enabled = false;
        }
    }
    bool hasCollided = false;

}
