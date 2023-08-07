using UnityEngine;

public class MovementHandler : MonoBehaviour
{
    [SerializeField] private float ballSpeed;
    public InputHandler inputHandler;
    void Start()
    {
        print($"Start Gravity is {Physics.gravity}");
        if(inputHandler == null)
            Debug.LogError("input handler don't exist");
    }

    private void MoveBall()
    {
        if (inputHandler.IsTouched())
        {
            Vector2 currentDeltaPosition = inputHandler.GetTouchDeltaPosition();
            currentDeltaPosition *= ballSpeed;
            Vector3 gravityVector = new Vector3(currentDeltaPosition.x, Physics.gravity.y, currentDeltaPosition.y);
            Physics.gravity = gravityVector;
            print($"New Gravity is {Physics.gravity}");
        }
    }
    // Update is called once per frame
    void Update()
    {
        MoveBall();
    }
}
