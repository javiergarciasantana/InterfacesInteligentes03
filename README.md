# Interfaces Inteligentes P03

## Exercise Prompts and Corresponding Code Files

### 1. Add a speed field to a cube and assign a value that can be changed in the object inspector. Show the console the result of multiplying the speed by the value of the vertical axis and the horizontal axis each time the up, down, left, or right arrow keys are pressed. The message should begin with the name of the pressed arrow.
**Help:** Use the Input and KeyCode classes from Unity: `Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")`  
**File:** `CubeController.cs`  
**Description:** This script controls the movement of a cube based on input from the arrow keys and displays the resulting speed calculations in the console.

---

### 2. Map the "H" key to the shooting function.
**Help:** Use the Input Manager to redefine the default mapping in the controllers.  
**File:** `ShootingController.cs`  
**Description:** This script maps the "H" key to a shooting action, allowing for customizable key mappings using the Input Manager.

---

### 3. Create a script associated with the cube that, in each iteration, translates the cube by an amount proportional to a vector that indicates the direction of movement (`moveDirection`), which should be modifiable in the inspector. The speed at which the movement occurs should also be specified in the inspector with the `speed` property. Initially, the speed should be greater than 1, and the cube should be at a position of y=0.
**Help:** You should create a vector that collects the direction of movement of type `Vector3`.  
**Help:** Use `Translate(x, y, z)`, where (x, y, z) are the coordinates of `moveDirection`.  
**File:** `CubeMovingStats.cs`  
**Description:** This script enables the cube to move based on user-defined speed and direction, with an emphasis on modifying movement properties in the Unity inspector.

---

### 4. Move the cube with the up-down and left-right arrow keys at the speed specified. Each of these axes implies movements on the vertical and horizontal axes, respectively. Move the sphere with the "W-S" keys (vertical movement) and "A-D" (horizontal movement).
**Help:** Use what you learned in previous exercises about the Input class and the Translate method.  
**File:** `CubeKeyControl.cs`  
**Description:** This script allows the cube and sphere to move according to key presses, providing user control over their respective movements.

---

### 5. Adapt the movement in Exercise 4 so that it is proportional to the time elapsed during frame generation.
**Help:** Use the value `Time.deltaTime` to scale the distance the object travels between frames.  
**File:** `CubeMovingStats.cs` (modified version)  
**Description:** This script adjusts movement calculations to be frame-rate independent by using `Time.deltaTime`, ensuring smooth movement across different hardware.

---

### 6. Adapt the movement in Exercise 5 so that the cube moves toward the position of the sphere. The movement should not be influenced by how far apart the two objects are.
**Help:** The direction of movement should be the vector that connects the cube with the sphere.  
**File:** `MoveToObject.cs`  
**Description:** This script calculates the direction vector from the cube to the sphere, allowing the cube to move towards the sphere while maintaining its height.

---

### 7. Adapt the movement in Exercise 6 so that the cube rotates towards the sphere. Test by changing the position of the sphere using the "W-A-S-D" keys.
**Help:** The Transform class has the `LookAt(Transform target)` method, which rotates the object to make the forward vector point at the target.  
**File:** `RotateToObject.cs`  
**Description:** This script enables the cube to rotate towards the sphere, allowing dynamic interactions based on the sphere's position.

---

### 8. Use the "Horizontal" axis to rotate the object and always move in the forward direction.
**Help:** The forward direction (positive Z axis) can be obtained with the Transform's forward property. Do not confuse it with Vector3.forward.  
**File:** `RotateFwdToObject.cs`  
**Description:** This script allows the object to rotate based on horizontal input while maintaining forward movement, ensuring responsive control.

---

### 9. Configure the cylinder as a physical object. When the cube or sphere collides with it, a message should be shown in the console with the tag of the object that collided (OnCollisionXXX).
**File:** `CollisionDetector.cs`  
**Description:** This script handles collision detection for the cylinder, logging messages in the console whenever the cube or sphere collides with it.

---

### 10. Configure the cube as a kinematic object and the sphere as a physical object. Adapt the scripts from Exercise 9 to achieve the same behavior.
**File:** `CollisionDetector.cs` (modified)  
**Description:** This modified script maintains collision detection behavior while adjusting the properties of the cube and sphere to demonstrate different physical interactions.

---

### 11. Configure the cylinder as a trigger object. Adapt the scripts from previous exercises to achieve the same behavior.
**Help:** In the previous exercises, use the `OnCollisionXXX` or `OnTriggerXXX` events according to the configuration of the object detecting the collision.  
**File:** `TriggerDetector.cs`  
**Description:** This script allows the cylinder to act as a trigger, logging messages when the cube or sphere enters its trigger zone, demonstrating a different form of collision detection.

---

### 12. Add a cylinder of a different color to the scene and configure it as a physical object. Choose a set of keys to control its movement in the scene and program it to move towards the sphere. Test different configurations of the sphere with a mass 10 times greater.
**Help:** The script should use a `Rigidbody` to control the movement and apply forces.  
**File:** `CylinderKeyControl.cs`  
**Description:** This script enables the movement of a cylinder using the arrow keys. It is set up as a physical object with a `Rigidbody`, allowing for realistic physics interactions. The cylinder is programmed to rotate and face the target object (sphere) while moving in its direction. The script calculates the necessary direction and rotation to guide the cylinder toward the sphere effectively.

---

This array of scripts provide a comprehensive demonstration of handling user input, object movement, and collision detection in Unity. Adjusting the configurations and scripts as outlined will help illustrate the principles of game development and object interaction.
