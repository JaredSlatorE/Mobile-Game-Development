using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;
using UnityEngine.SocialPlatforms.Impl;



public interface IPowerUp
{
    virtual bool onTickCheckup() {return false;}
}


public abstract class PowerUp : IPowerUp
{
    public float elapsedTime {get; private set;}
    public float duration {get;private set;}
    public string PTag;
    public string imagePath;
    public GameObject owner;
    IPowerUp powerUpInterface;

    public virtual void onActive() {}
    public virtual void onDeactive() {}


    public PowerUp(float Duration)
    {
        elapsedTime = 0;
        powerUpInterface = this;

        duration = Duration;
    }

    public bool timer() //Returns true if timer is depleted, returns false if not
    {
        elapsedTime += Time.deltaTime;

        powerUpInterface.onTickCheckup();

        if (elapsedTime >= duration)
        {
            return true;
        }
        return false;
    }
}

public abstract class TickablePowerUp : PowerUp, IPowerUp
{
    public float tickRate {get; private set;}
    private int currentTick = 0;

    public TickablePowerUp(float Duration, float TickRate) : base(Duration)
    {
        tickRate = TickRate;
    }

    public abstract void onTick();

    public bool onTickCheckup()
    {
        //Debug.Log($"Elapsed Time {elapsedTime} TickRate {tickRate} CurrentTick {currentTick}");
        if (elapsedTime >= tickRate * currentTick) 
        {
            onTick();
            currentTick++;
            return true;
        }
        return false;
    }
}

public class GamerPowerUp : TickablePowerUp, IPowerUp //Test Power ups for debug to make it easier to recode stuff when I start lol.
{
    public string gamerText;
    public GamerPowerUp(float Duration, float TickRate, string GamerText) : base(Duration,TickRate)
    {
        gamerText = GamerText;
        PTag = "Gamer";
        imagePath = "Sprites.Yukako";
    }

    public override void onTick()
    {
        Debug.Log(gamerText);
    }
}

public class Yuyuko : PowerUp
{
    string path = "Sprites/Yukako";
    Sprite replacementSprite;
    Sprite originalSprite;


    SpriteRenderer spriteRenderer;
    Color color;
    public Yuyuko(float Duration) : base(Duration)
    {
        PTag = "Yuyuko";
        imagePath = "Sprites/Yukako";
    }

    public override void onActive()
    {
        replacementSprite = Resources.Load<Sprite>(path);
        spriteRenderer = owner.GetComponent<SpriteRenderer>();
        originalSprite = spriteRenderer.sprite;
        spriteRenderer.sprite = replacementSprite;
        color = spriteRenderer.color;
        spriteRenderer.color = new Color(255,255,255);
        
        Debug.Log("This is the border of life..."); //Touhou 
    }

    public override void onDeactive()
    {
        Debug.Log("Survived spellcard!"); //Too hoo
        spriteRenderer.sprite = originalSprite;
        spriteRenderer.color = color;
    }
}

public class SpeedBoost : PowerUp
{
    float boostAmount = 0f;
    public SpeedBoost(float Duration, float BoostAmount) : base(Duration)
    {
        boostAmount = BoostAmount;
        PTag = "SpeedBoost";
    }

    public override void onActive()
    {
        Rigidbody2D component = owner.GetComponent<Rigidbody2D>();
        if (component)
        {
            component.linearVelocity = component.linearVelocity * boostAmount;
        }
    }

}

public class ScoreBoost : PowerUp
{
    int scoreMultiplier;
    public ScoreBoost(float Duration, int ScoreMultiplier) : base(Duration)
    {
        scoreMultiplier = ScoreMultiplier;
        PTag = "ScoreBoost";
        imagePath = "Sprites/PointIcon";
    }

    public override void onActive()
    {
        ScoreManager.scoreMultiplier += scoreMultiplier;
    }

    public override void onDeactive()
    {
        ScoreManager.scoreMultiplier -= scoreMultiplier;
    }
}