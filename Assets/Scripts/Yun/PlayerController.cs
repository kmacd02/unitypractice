using UnityEngine;
using UnityEngine.InputSystem;

namespace Yun{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody2D rb;

        [SerializeField] private float speed = 5f;
        private Vector2 dir = Vector2.zero;
        
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void OnMove(InputValue input)
        {
            dir = input.Get<Vector2>();
            rb.velocity = dir * speed;
        }
    }
}
