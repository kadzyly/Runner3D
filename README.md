# Runner3D (Unity Learning Project)

A 3D runner game built with Unity 6: auto-run forward, dodge obstacles, collect coins.  
**Win condition:** reach the finish line and collect **100% of the coins**.

## 🎮 Play Online
You can try the game directly in your browser:  
👉 [Play on itch.io](https://kadzy.itch.io/runner3d)

[![Play on itch.io](https://github.com/user-attachments/assets/eed26c32-a2c2-4b37-ba2d-392c72c5dedb)](https://kadzy.itch.io/runner3d)

---

## Features

- Must collect **all coins** + reach finish to win
- Run, trip, victory dance, fail and idle animations
- Particle & sound feedback for coins and collisions

## Controls

- **A** or **Left Arrow**: Move left
- **D** or **Right Arrow**: Move right

## Project Structure

```
Assets/
├── Animations/ 
├── Environment/ 
├── Materials/ 
├── Models/ 
├── Prefabs/ 
├── Resources/ 
├── Scenes/ 
├── Scripts/ 
│   ├── GameManager.cs 
│   ├── PlayerBehaviour.cs 
│   ├── PlayerMovement.cs 
│   ├── PlayerInputReader.cs 
│   ├── Coin.cs 
│   ├── CoinManager.cs 
│   ├── Barrier.cs 
│   ├── Finish.cs 
│   ├── RoadInfo.cs 
│   └── SwitchObjectToParticles.cs 
├── Settings/ 
├── Sounds/ 
└── UI/ 
```

## Key Scripts

- **GameManager**: Handles game flow, win/lose states, and menu management
- **PlayerMovement**: Controls player movement using Unity's Input System
- **PlayerBehaviour**: Manages player animations and states (play, trip, win, lose)
- **Coin**: Rotates and detects collection, triggers particle effects
- **Barrier**: Detects collision with player, triggers game over
- **Finish**: Detects when player reaches the finish line
- **CoinManager**: Tracks collected coins and updates UI

## Getting Started

1. **Clone the repository**
   ```bash
   git clone https://github.com/kadzyly/Runner3D.git
   cd Runner3D
   ```

2. **Open in Unity**  
6000.2.10f1 or compatible version

3. **Install Dependencies**  
Install packages from `Packages/manifest.json`: Universal Render Pipeline (URP), Input System, Cinemachine, TextMesh Pro

4. **Run the Game**  
Open the `Level1.unity` scene from `Assets/Scenes/` and Press **Play**

## Technologies Used

- **Unity 6**
- **Universal Render Pipeline (URP)**
- **Unity Input System**
- **Cinemachine**
- **TextMesh Pro**
