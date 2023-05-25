using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 movedirection;
    private Vector2 mousePosition;
    public Camera sceneCamera;
    public weapon weapon;
    //nos referimos al script

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }
    void FixedUpdate() // sirve más para calcular fisicas
    {
        move();
    }
    void ProcessInputs()//esto ba despues en void update
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        //llamo a los inputs mismos del unity para ahorrarme especificar que teclas sirven para mover
        if (Input.GetMouseButtonDown(0))
        { weapon.fire(); }
            // en este codigo 0 y 1 representn click derecho o izquierdo, solo disparare con 1 por eso elijo solo 1
        movedirection = new Vector2(moveX, moveY);
        mousePosition = sceneCamera.ScreenToWorldPoint(Input.mousePosition);
        //screen to world point es lo que nos permite identificar donde esta el mouse en la pantalla gracias a la cámara :D
    }

    //get axis nos da un valor entre 0  y 1 incluyendo decimales y al agregarle raw solo nos da 1 o 0 sin decimales
    void move()

    {
        rb.velocity = new Vector2(movedirection.x * moveSpeed, movedirection.y * moveSpeed);
        //esto nos dejara que el player rote con el movimiento del mouse
        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        // Mathf.Rad2Deg es simplemente una constante para realizar conversiones de radianes a grados en Unity.
        //mathf.atan2 calcula el ángulo en radianes entre el eje x
        rb.rotation = aimAngle;
        //aim angle y aim direction, como su nombre lo indica nos ayudan a calcular el angulo y dirección, unity mismo las tiene :D
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemigo2Bullet"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Derrota");
        }
    }
}



