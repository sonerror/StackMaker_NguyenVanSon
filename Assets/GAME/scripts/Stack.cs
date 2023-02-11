using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stack : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject Object;
    [SerializeField] Stack<GameObject> brickUp = new Stack<GameObject>();
    [SerializeField] private GameObject gameController;

    private int nextSceneToLoad;
    private Vector3 currentTranform;
    private Vector3 stack = new Vector3(0, 0.25f, 0);

    int count = 0;


    void Awake()
    {
        currentTranform = new Vector3(0, transform.position.y, 0);
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }
    void Update()
    {
        ControllerBrick();
    }
    private void ControllerBrick()
    {
        RaycastHit hit;
        Debug.DrawLine(transform.position, transform.position + Vector3.down * 100f, color: Color.red);
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 100f))
        {
            if (hit.collider.tag == "brick")
            {
                Debug.Log("brick");
                GameObject obj = Instantiate(Object, new Vector3(transform.position.x, transform.position.y - count * stack.y, transform.position.z), Quaternion.identity) as GameObject;
                brickUp.Push(obj);
                transform.position += stack;// tăng độ cao nhân vật
                Destroy(hit.collider.gameObject);// xóa brick khi va chạm
                obj.transform.SetParent(transform);
                count++;
            }
            else if (hit.collider.tag == "bridge")
            {
                count--;
                Destroy(hit.collider.gameObject);
                RemoveBrick();
            }
            else if (hit.collider.tag == "bridge_finish")
            {
                Destroy(hit.collider.gameObject);
                ClearBrick();
            }
             else if (hit.collider.tag == "Finish")
               {
                Debug.Log("hi");
                
                SceneManager.LoadScene(nextSceneToLoad);
               }
        }
    }
    private void RemoveBrick()
    {
        transform.position -= stack;
        Destroy(brickUp.Pop());
    }
    private void ClearBrick()
    {
        for(int i = 1; i < count;i++)
        {
           RemoveBrick();
        }
    }
    public void ResetGame11()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Debug.Log("resat");
    }
}