 # Observer Pattern

The **Observer** pattern is sometimes referred to as a Subscription pattern, as it allows entities within your domain to _subscribe_ to
notifications of a change in another entity's state.

The entities that _subscribe_ to these notifications are referred to as **Observers**.<br>
The entity the **Observers** subscribe to is referred to as the **Subject**.

So, once implemented, the expected outcome could look something like this:
1. The state within our **Subject** entity changes.
2. The **Subject** notifies each of its **Observers** to the change, passing its current state.
3. Each **Observer** receives this state, and can use it to react to this notification changed state.

It is worth noting that this pattern involves many **Observers** to one **Subject**.

### Where does this pattern exist in the "real world"?

Imagine you are signed into your YouTube Account, watching a video from a YouTube Channel you haven't heard of before. 
You like the video, so you decide to subscribe to the YouTube Channel that has produced it.

Your **YouTube Account** in this example is an **Observer**.<br>
The **YouTube Channel** in this example is the **Subject**.

The collection of videos belonging to the **YouTube Channel** are
a _property_ of that **YouTube Channel** - so, it is the ***state*** of the **YouTube Channel**.<br>

The upload of a video to that channel - the addition of a video to it's collection of videos - 
would then be considered a ***change in state of the YouTube Channel***.

Therefore, when you _subscribe_ to be notified of new videos added to that collection of videos, 
you are asking to be ***notified of a change in the state of the YouTube Channel***.

#### The Process

1. You click Subscribe, whilst logged in on your **YouTube Account**.
2. Your **YouTube Account** informs the **YouTube Channel** that you would like to be registered as one of it's Subscribers.
3. The **YouTube Channel** receives the request and adds your **YouTube Account** to it's list of Subscribers.
4. Later, the **YouTube Channel** uploads a new video - adding it to it's collection of videos.
5. This, being a ***change in the state of the YouTube Channel***, 
triggers a notification to each of the **YouTube Accounts** that have subscribed to it.
6. Your **YouTube Account**, being one of those that has subscribed, receives the notification of a change in state.
7. Your **YouTube Account** uses this new _state_ that was received to notify you of the new video in the UI.
