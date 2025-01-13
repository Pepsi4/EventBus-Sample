
<h1> Detailed Steps: </h1>
    <h2> Player (Event Producer/Subject) </h2>

- Decreases the player's health when the spacebar is pressed.
- Triggers an event (UPDATE_HEALTH) with the new health data encapsulated in a HealthEventPayload.

<h2> EventManager (Dispatcher) </h2>

-  A static utility that acts as a centralized event dispatcher.
- Stores a dictionary of events (eventDictionary) where:
  - The key is the event type (e.g., UPDATE_HEALTH).
  - The value is a delegate (Action<IEventArgs>) representing the subscribed methods.
- Provides methods to:
  - Register events
  - Unregister events
  - Trigger events
 
<h2> HealthBar (Event Consumer/Observer) </h2>

- Subscribes to the UPDATE_HEALTH event when initialized (Start method).
- Responds to the event by updating the UI slider and logging the player's name.
- Unsubscribes from the event when destroyed (OnDestroy).

Made with tutorial: https://www.youtube.com/watch?v=ULMg7xvBbpw
