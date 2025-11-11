# in-class-activities
## Devlogs
### W1
Hello World!

### W2
1. We are under the RGB 0-1.0. It is a fractional number between 0 and 1.
2. Because is a whole number
3. The name "add_rgb" and "brightness" does not exist in the current context in step 8, and I found that I didn't put float in the front.
4. Besides that I have question about the window, it shows different on my unity and itchio
![alt text](https://github.com/UCI-GDIM31/class-activities-p1ziYu/blob/main/In%20Class%20Activities/Assets/Unity_in_scene.png)
![alt text](https://github.com/UCI-GDIM31/class-activities-p1ziYu/blob/main/In%20Class%20Activities/Assets/Unity_in_play.png)
![alt text](https://github.com/UCI-GDIM31/class-activities-p1ziYu/blob/main/In%20Class%20Activities/Assets/itchio.png)

### W3
Parameters(input) will be float that go with time the beat is hit by players and the timing window the beat should be hit. Return type (output) will be boolean that to determine if the player hit the beat and within the timing window.
1. Components are the concert, classes are the performance, member variables are the performers, and methods are the instruments
2. Because ballRenderer.color *= GetColorMultiplier(Mathf.Abs(_rigidbody.linearVelocity.x), Mathf.Abs(_rigidbody.linearVelocity.y)); shows that the color of the ball is highly bind with velocity

### W4
Table #3
Line 5 "[SerializeField] private" to make it editable in Unity while it is kept only in this class, float to declare the type, and declare a variable with a value.
Line 22 declare a float member variable with product of user input on vertical based on the method called GetAxis from class Input and speed and time.
Line 25 transform is a variable and calling a method Translate, with parameter of original startup position. 
1. Cat: Rigidbody, Capsule Collider. SoccerBall: Rigidbody, Sphere Collider. Goal: BoxCollider"Is Trigger"
2. To set the point as a private int outside of the if, since everytime when if is triggered the point will be reset to 0 again.

### W5
Question: What happens if I use GetComponent<T>() to find a component that isn't attached to the GameObject?
Answer: It will return null.

Part1: 
1. _target, _navMeshAgent
23. Start() to let the deer start moving, Update() if you want the deer to follow the cat, GetComponent<> to get the NavMeshAgent class, SetDestination() to set the destination for NavMeshAgent

### W6
1. speed, _playerTransform, player
2. EnableChase, DisableChase, Update, MoveTowards
3. EnableChase to enable the methods of MonoBehaviour, DisableChase to disable the methods of MonoBehaviour, Update to keep track the bats and cat position and let bats to MoveTowards to cat.

### W7
1. Activity 1. Link https://docs.google.com/document/d/1yZqnc3GyaietJAPdXlV0iO8EaXxBU-2bWMjaaw1TMe4/edit Animation
2. Activity 2. Original one is working on global axis, but transform.Translate is working on local axis
## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 