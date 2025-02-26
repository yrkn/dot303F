# sample of using various design patterns on unity

The character's movement states (Idle, Walking) are managed and logged using the State Pattern.  

A Scriptable Object is used as the Subject of the Observer Pattern, meaning it receives state changes and notifies the observer, which is the UI.  

The UIListener class is used to reflect real-time changes on the game screen, updating the text displayed at the top with each state change.

As for Object Pooling, a pool was created to hold 10 objects, and these objects are set to spawn at random positions on the ground.

When the character comes into contact with an object, the object is returned to the pool, and after a 5-second delay, it is retrieved again from the pool and spawned at a random location.

prepared for the 3rd grade final project.

<br>
<p align="center">
  <img src="https://github.com/yrkn/patternsample/blob/main/ss.png" width="500"/>
</p>

