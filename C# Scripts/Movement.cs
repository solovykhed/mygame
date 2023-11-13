using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;                         

public class Boar : MonoBehaviour
{

    Animator anim;

    public float force;
    public static Boar instance;                          

    float horizontal;                                       // переменная для акселерометра
    public Rigidbody2D BoarRigid;                        

    public GameObject RestartButton;
    void Start()
    {
        anim = GetComponent<Animator>();
        if (instance == null)                               // пишем эти строчки, чтоб можно было корректно использовать переменные в других скриптах
        {
            instance = this;                               
        }
        Time.timeScale = 1;                             //  скорость равна 1 - т.е. все норм работает
        BoarRigid = GetComponent<Rigidbody2D>();        //  получаем компонент Rigidbody
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))                // если жмем на кнопку мыши или экран
        {
            BoarRigid.velocity = Vector2.up * force;
            anim.SetTrigger("trig");               // силу настраиваем
        }

        if (Application.platform == RuntimePlatform.Android)    // если платформа Андроид
        {
            horizontal = Input.acceleration.x;                  // то подключаем акселерометр по оси х
        }

        if (Input.acceleration.x < 0)                           // если наклон акселерометра меньше нуля
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;    // то объект поворачивается налево
        }

        if (Input.acceleration.x > 0)                           // если наклон акселерометра больше нуля
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;     // то объект поворачивется направо
        }

        BoarRigid.velocity = new Vector2(Input.acceleration.x * 10f, BoarRigid.velocity.y);     //  добавляем силу к акселерометру, чтоб он не просто разворачивался в разные стороны
    }

    public void OnCollisionEnter2D(Collision2D collision)       
    {
        if (collision.collider.name == "DeadZone")              
        {
            Destroy(gameObject);                        
            Time.timeScale = 0;                         
            RestartButton.SetActive(true);
        }
    }
}
