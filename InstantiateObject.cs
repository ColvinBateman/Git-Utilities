//Definitions

//original - an object that exists already, intended to be copied
//position - position for new object
//rotation - rotation ''
//parent - parent that will be assigned to the object
//instantiateInWorldSpace - Pass true when assigning a parent Object to maintain the world position of the Object, instead of setting its position relative to the new parent. Pass false to set the Object's position relative to its new parent.

/*
// Instantiates 10 copies of Prefab each 2 units apart from each other

using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public Transform prefab;
    void Start()
    {
        for (int i = 0; i < 10; i++)//as long as the newly created i is less than ten, and i increases each loop
        {
            Instantiate(prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);//instantiate a new prefab two units apart from the last one
        }
    }
}
*/
/*
using UnityEngine;

public class Example : MonoBehaviour
{
    // Instantiate a rigidbody then set the velocity

    Rigidbody projectile;//creates a rigidbody named projectile

    void Update()
    {
        // Ctrl was pressed, launch a projectile
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            clone.velocity = transform.TransformDirection(Vector3.forward * 10);
        }
    }
}
*/

/*
using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour
{
    public int timeoutDestructor;

    // ...other code...
}


public class ExampleClass : MonoBehaviour
{
    // Instantiate a Prefab with an attached Missile script
    public Missile projectile;

    void Update()
    {
        // Ctrl was pressed, launch a projectile
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Missile clone = (Missile)Instantiate(projectile, transform.position, transform.rotation);

            // Set the missiles timeout destructor to 5
            clone.timeoutDestructor = 5;
        }
    }
}
*/

/*
using UnityEngine;

public class Missile : MonoBehaviour
{
    // ...other code...
}

public class InstantiateGenericsExample : MonoBehaviour
{
    public Missile missile;//creates a public class of Missile, and makes missile the field

    void Start()
    {
        Missile missileCopy = Instantiate<Missile>(missile);//instantiates a copy of the missile
    }
}
*/