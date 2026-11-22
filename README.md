# MG7
## Devlog

Array: `sparrows` stores the GameObjects of four birds.

Vector: `Vector3.Distance()` calculates the distance between the player and each bird.

Interaction: When the distance is less than or equal to `interactionDistance`, `SetActive(true)` is used to activate the corresponding bird.

Result: As the colobus approaches the tree, the birds appear and move upward.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
