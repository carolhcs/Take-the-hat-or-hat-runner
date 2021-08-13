using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Comportamentos e ações do ambiente e objetos de ambiente
/// </summary>
public class EnvironmentBehavior : MonoBehaviour
{
    [Header("Create Id to this object:")]
    public string environmentObjectId = "id";

    public enum _directionMovement { x_plus, x_minus, y_plus, y_minus, z_plus, z_minus};
    [Header("Movement Configuration:")]
    public _directionMovement directionMove;
    public enum _kindVelocity { fixedVelocity, variantVelocity}
    public _kindVelocity kindVelocity;
    public TimeManager timeManager;
    //private float fixedVelocity = DataManager.INITIAL_SPEED;//1f;

    private float Velocity { get; set; }

    void Awake()
    {
        SetInitVelocity();
    }

    
    void FixedUpdate()
    {
        MoveObjectOnDirection();
        IncreaseVelocity();
    }

    public void SetInitVelocity()
    {
        EnvironmentStatus.Velocity = DataManager.INITIAL_SPEED;
        Velocity = EnvironmentStatus.Velocity;
        if (this.gameObject.tag.Equals("Trap")) Velocity += this.GetComponent<TrapsRegistration>().movementSpeed;
    }

    public void MoveObjectOnDirection()
    {
        
        if (directionMove == _directionMovement.x_minus) this.transform.Translate(-Velocity * Time.deltaTime, 0, 0);
        else if (directionMove == _directionMovement.x_plus) this.transform.Translate(Velocity * Time.deltaTime, 0, 0);
        else if (directionMove == _directionMovement.y_minus) this.transform.Translate(0, -Velocity * Time.deltaTime, 0);
        else if (directionMove == _directionMovement.y_plus) this.transform.Translate(0, Velocity * Time.deltaTime, 0);
        else if (directionMove == _directionMovement.z_minus) this.transform.Translate(0, 0, -Velocity * Time.deltaTime);
        else if (directionMove == _directionMovement.z_plus) this.transform.Translate(0, 0, Velocity * Time.deltaTime);
    }

    /*public void IncreaseVelocity()
    {
        // Implementar no TimeManager??
        //EnvironmentStatus.Velocity =
        float lastTimeIncrease = 0;
        if((Velocity < 2) && ((timeManager.Seconds > 10) && (timeManager.Seconds < 11)))
        {

        }
        
        

        Velocity = EnvironmentStatus.Velocity;
    }*/
    

}
