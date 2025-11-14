# Runner3D (Unity Learning Project)

A 3D runner game built with Unity 6. Navigate your character through obstacles, collect coins, and reach the finish line!

## 🎮 Play Online
You can try the game directly in your browser:  
👉 [Play on itch.io](https://kadzy.itch.io/runner3d)

[![Play on itch.io](https://github.com/user-attachments/assets/eed26c32-a2c2-4b37-ba2d-392c72c5dedb)](https://kadzy.itch.io/runner3d)

---

## Features

- **Smooth 3D Movement**: Automatic forward movement with horizontal controls
- **Coin Collection System**: Collect coins to increase your score
- **Obstacle Avoidance**: Navigate around barriers - hitting one will end your run
- **Win/Lose Conditions**: Reach the finish line to win, or trip on barriers
- **Character Animations**: Includes run, trip, dance, and idle animations
- **Visual Effects**: Particle effects for coin collection and barrier collisions
- **Audio Feedback**: Sound effects for footsteps, coin collection, and victory

## Controls

- **A** or **Left Arrow**: Move left
- **D** or **Right Arrow**: Move right

The character moves forward automatically. Use the controls to steer left and right to avoid obstacles and collect coins.

## Requirements

- **Unity Version**: 6000.2.10f1 or compatible Unity 6 version
- **Render Pipeline**: Universal Render Pipeline (URP) 17.2.0

## Project Structure

```
Assets/
├── Animations/          # Character animation clips and controller
├── Environment/         # Skybox and ground textures
├── Materials/           # Material assets
├── Models/              # 3D models (.fbx)
├── Prefabs/             # Game object prefabs
├── Resources/           # Runtime resources
├── Scenes/              # Unity scene files
├── Scripts/             # Core game scripts
│   ├── GameManager.cs           # Main game state management
│   ├── PlayerBehaviour.cs       # Player behavior and states
│   ├── PlayerMovement.cs        # Movement controller
│   ├── PlayerInputReader.cs     # Input handling
│   ├── Coin.cs                  # Coin collectible logic
│   ├── CoinManager.cs           # Score tracking
│   ├── Barrier.cs               # Obstacle collision detection
│   ├── Finish.cs                # Finish line trigger
│   ├── RoadInfo.cs              # Road boundary information
│   └── SwitchObjectToParticles.cs # Particle effect system
├── Settings/            # Project settings and configurations
├── Sounds/              # Audio files
└── UI/                  # User interface elements
```

## Key Scripts

- **GameManager**: Handles game flow, win/lose states, and menu management
- **PlayerMovement**: Controls player movement using Unity's Input System
- **PlayerBehaviour**: Manages player animations and states (play, trip, win)
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
   - Open Unity Hub
   - Click "Add" and select the Runner3D folder
   - Ensure you have Unity 6000.2.10f1 or compatible version
   - Click "Open"

3. **Install Dependencies**
   - Unity should automatically install packages from `Packages/manifest.json`
   - Key packages include:
     - Universal Render Pipeline (URP)
     - Input System
     - Cinemachine
     - TextMesh Pro

4. **Run the Game**
   - Open the `Level1.unity` scene from `Assets/Scenes/`
   - Press Play in the Unity Editor
   - Use A/D or arrow keys to control your character

## Building

### WebGL Build
The project includes WebGL build configuration. To create a new build:
1. Go to `File > Build Settings`
2. Select `WebGL` as the platform
3. Click `Build` or `Build and Run`

A sample WebGL build is available in the `Build/` folder.

## Gameplay

1. **Start**: Click the start button to begin the game
2. **Navigate**: Use A/D or arrow keys to move left and right
3. **Collect Coins**: Pick up coins to increase your score (displayed in the UI)
4. **Avoid Barriers**: Don't hit the barriers or you'll trip and lose
5. **Reach the Finish**: Make it to the finish line to win and see the victory dance!

## Technologies Used

- **Unity 6**: Game engine
- **Universal Render Pipeline (URP)**: Modern rendering pipeline
- **Unity Input System**: Modern input handling
- **Cinemachine**: Camera control
- **TextMesh Pro**: High-quality text rendering

## License

This project is open source and available for educational purposes.

## Contributing

Contributions, issues, and feature requests are welcome!

## Credits

- Built with Unity 6
- Uses Unity's Input System for controls
- URP for rendering
