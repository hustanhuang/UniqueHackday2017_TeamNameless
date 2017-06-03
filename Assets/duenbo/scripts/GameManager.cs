using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Image ScrollImage;

    public float addNumPerSecond=0.1f;

    public float minusNumPerSecond=0.05f;

    private float timer = 0.05f;
    public GameObject firePrefab1;
    public GameObject firePrefab2;

    public GameObject gameEnd;
    private int fireNum;

    private float fireTimer=0;

    private ArrayList firePositionX;
    private ArrayList firePositionY;
    float x;
    float y;
    GameObject gameObject;
    // Use this for initialization
    void Start()
    {
        fireNum = 0;
        firePositionX = new ArrayList();
        firePositionY = new ArrayList();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
            if (hit.collider.tag == "fire" && Input.GetMouseButtonDown(0))
            {
                ScrollImage.fillAmount = ScrollImage.fillAmount - minusNumPerSecond;
                fireNum--;
                firePositionX.Remove(hit.collider.gameObject.transform.position.x);
                firePositionY.Remove(hit.collider.gameObject.transform.position.y);
                Destroy(hit.collider.gameObject);
            }
        }
        timer += Time.deltaTime;
        fireTimer += Time.deltaTime;
        if (timer > 0.1)
        {
           
           ScrollImage.fillAmount = ScrollImage.fillAmount+addNumPerSecond*(fireNum+20);
            timer = 0;
        }
        if (fireTimer > 0.4 && fireNum < 20)
        {
            fireTimer = 0;
            fireNum++;
            
            //x: -6.5 ~8
            //y: -4 ~4
            
            x = Random.Range(-6.5f, 8);
            y = Random.Range(-4, 4);
            if(isNear(firePositionX,x))
            {
                x = Random.Range(-6.5f, 8);
            }

            if (isNear(firePositionY, y))
            {
                y = Random.Range(-4, 4);
            }
            float size = Random.Range(0.5f, 1.5f);
            if (size > 1)
            {
                 gameObject = Instantiate(firePrefab1, new Vector3(x, y, 0), Quaternion.identity);
            }
            else
            {
                gameObject = Instantiate(firePrefab2, new Vector3(x, y, 0), Quaternion.identity);
            }
            gameObject.transform.localScale= new Vector3(size, size, size);
            firePositionX.Add(x);
            firePositionY.Add(y);
        }
        if(ScrollImage.fillAmount == 1)
        {
            gameEnd.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

    bool isNear(ArrayList list, float num)
    {
        bool flag = false;
        if (list != null)
        {
            foreach (float x in list)
            {
                if (x - num < 1.5f&&num-x<1.5f)
                {
                    flag = true;
                }
            }
        }
        return flag;
    }
}


