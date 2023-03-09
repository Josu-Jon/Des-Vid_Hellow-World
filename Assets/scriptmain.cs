using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character
{
    public string Name { get; private set; }

    public Character(string name)
    {
        Name = name;
        Debug.Log($"Hola soy {name}");
    }

    ~Character()
    {
        Debug.Log("Enemigo destruido");
    }
}
class Player : Character
{
    public Player(string name) : base(name)
    {

    }
}

class Empty : Character
{
    public Empty(string name) : base(name)
    {

    }
}

class Enemy : Character
{
    public Enemy(string name) : base(name)
    {

    }
    
}

