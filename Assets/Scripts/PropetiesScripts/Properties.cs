using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : MonoBehaviour
{
    // Always use as many private variables as possible
    // Public variables only when really necessary
    private bool isDead;
    private bool isWalking;

    // Serialized variables can be manipulated in the inspector

    // Attributes
    [SerializeField] private float _speed;
    [SerializeField] private string _playerName;

    // Components
    [SerializeField] private Rigidbody rig;
    [SerializeField] private Animator anim;

    // Use of properties based on the encapsulation principle
    // To access private variables indirectly but with greater security

    // Properties
    public float Speed
    { get => _speed;
      set => _speed = value;
    }

    public string PlayerName
    { get => _playerName;
      set => _playerName = value;
    }
    
}
