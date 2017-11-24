# Project Rift

Project Rift is an open source multiplayer space simulator in development.

[![Build status](https://ci.appveyor.com/api/projects/status/skb06umdd8jncfgk?svg=true)](https://ci.appveyor.com/project/drakeor/project-rift)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/31c0cbdb1c8443a886ee701437200c81)](https://www.codacy.com/app/drakeor.dragon/project-rift?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=drakeor/project-rift&amp;utm_campaign=Badge_Grade)


# Development

Development is focused around the gameplay and creating the environment / simulating the environment above all else. The first few iterations will
demonstrate a simulation before the player is fleshed out into the environment as well as graphical representation of the world. Gameplay
is heavily PvE focused and PvP is the last of priorities.

## V0.0.1 `Current`
- Demonstrate two ships engaging in combat
- Both ships have some sample components
  - Energy Generator
  - Shield Generator
  - Armor
  - Bridge
- Both ships can take damage to their shields, armor, health
- Both ships can take damage to their components
- Demonstrate link between hull and component health
- Both ships can fire a basic general damage weapon at each other
- The general damage weapon will always hit
- Simulation ends when one ship dies
- Graphics not needed in this one, console will work to demo
- ~~Get git repository set up as well as CI~~
- ~~Produce some documentation for high level design and ship design~~

## V0.1.1 `Future`
- Demonstrate an AI controlling the ship
- Demonstrate the AI having cash
- Demonstrate the AI trading between his ship and another shop
- AI buys simple cargo and sells it back 
- Demonstrate the AI having a faction and being aware of it
- Graphics not needed in this one, console will work to demo

## V0.2.1 `Future`
- Demonstrate the AI jumping between galaxies
- Demonstrate the AI picking some shops and trading them
- Demonstrate the AI immediately firing on another ship of another faction and pursuing them
- Demonstrate an AI that rules a faction making some executive choice
- Graphics not needed in this one, console will work to demo

## V0.3.1 `Future`
- Demonstrate an enforcer like AI for each faction
- Demonstate a faction leader laying claim to a planet
- Maybe implement some simple graphics

## ...

## V1.0.0 Alpha Release
- Player interacts in world and flies ship around
- Player can see other players and things in the world