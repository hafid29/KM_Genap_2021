using System.Collections;
using UnityEngine;

public class RagdollCharacter : MonoBehaviour
{

    void Start()
    {
        DeactivateRagdoll();
    }

    public void ActivateRagdoll()
    {
        gameObject.GetComponent<CharacterController>().enabled = false;
        gameObject.GetComponent<BasicController>().enabled = false;
        gameObject.GetComponent<Animator>().enabled = false;

        foreach (Rigidbody bone in GetComponentsInChildren<Rigidbody>())
        {
            bone.isKinematic = false;
            bone.detectCollisions = true;
        }

        foreach (Collider col in GetComponentsInChildren<Collider>())
        {
            col.enabled = true;
        }

        StartCoroutine(Restore());
    }

    public void DeactivateRagdoll()
    {
        gameObject.GetComponent<BasicController>().enabled = true;
        gameObject.GetComponent<Animator>().enabled = true;
        transform.position = GameObject.Find("Spawnpoint").transform.position;
        transform.rotation = GameObject.Find("Spawnpoint").transform.rotation;

        foreach (Rigidbody bone in GetComponentsInChildren<Rigidbody>())
        {
            bone.isKinematic = true;
            bone.detectCollisions = false;
        }

        foreach (CharacterJoint joint in GetComponentsInChildren<CharacterJoint>())
        {
            joint.enableProjection = false;
        }

        foreach (Collider col in GetComponentsInChildren<Collider>())
        {
            col.enabled = true;
        }

        gameObject.GetComponent<CharacterController>().enabled = true;
    }

        IEnumerator Restore()
        {
            yield return new WaitForSeconds(5);
            DeactivateRagdoll();
        }
    }
