using UnityEngine;
using UnityEngine.InputSystem.iOS;

public class repetirChao : MonoBehaviour
{
    private GameController _gameController;
    void Start()
    {
        _gameController = FindAnyObjectByType(typeof(GameController)) as GameController;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void FixedUpdate()
    {
        MoveChao();
    }
    void MoveChao()
    {
        transform.Translate(Vector2.left * _gameController._chaoVelocidade * Time.deltaTime);
    }

}
