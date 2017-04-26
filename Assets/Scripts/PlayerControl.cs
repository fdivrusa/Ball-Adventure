using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed;
    private Rigidbody player;

    //Variables initialization
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Updates every frame
    void FixedUpdate()
    {

        if (SystemInfo.deviceType == DeviceType.Desktop)
        { //Code for desktop use

            float HorizontalMove = Input.GetAxis("Horizontal"); //Collecting values of the input
            float VerticalMove = Input.GetAxis("Vertical");

            Vector3 move = new Vector3(HorizontalMove, 0.0f, VerticalMove); //Initialization of a vector for the player's move
            player.AddForce(move * speed); //Player is moving ! Higher the speed is, faster my player will be

        }
        else
        {  //Code for mobile use

            float HorizontalMove = Input.acceleration.x; //Collecting values of the mobile accelerometer
            float VerticalMove = Input.acceleration.y;

            Vector3 move = new Vector3(HorizontalMove, 0.0f, VerticalMove); //Same code for the desktop version and the mobile version
            player.AddForce(move * speed);
        }
    }
}
