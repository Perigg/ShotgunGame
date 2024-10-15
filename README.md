# Shotgun Game

This is a simple console-based **Shotgun Game** implemented in C# with a WinForms interface. The game features a turn-based showdown between the player and the computer, where both can perform actions like loading, shooting, blocking, and using the shotgun.

## Gameplay

- **Load**: Adds a shot to your arsenal.
- **Shoot**: Use one shot to try and hit the opponent.
- **Block**: Defend against incoming shots.
- **Shotgun**: Requires 3 shots and guarantees victory if successful.

The computer plays according to its own random strategy, reacting to the player’s choices. The game ends when either the player or the computer successfully uses the shotgun or shoots without being blocked.

## Rules

- You can only **Shoot** if you have at least one shot loaded.
- You need at least **3 shots** to use the **Shotgun**.
- The game ends when one side successfully uses the **Shotgun** or shoots when the opponent cannot block.

## Future Improvements

This game is one of my first coding projects, and I’ve kept the original structure to showcase my learning process. There are several areas where the code can be improved, but this version remains an important milestone in my journey as a developer.

## Screenshot

![Screenshot](https://github.com/Perigg/ShotgunGame/blob/master/shotgun1.png)

---

