using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Rule
{
  abstract public void Apply();
}

public class RuleRotate
{
  private Vector2 mDir;
  private float mAngleInRadians = 0.0f;
  public RuleRotate(Vector2 dir, float angleInRadians)
  {
    mDir = dir;
    mAngleInRadians = angleInRadians;
  }
  public static Vector2 rotate(Vector2 v, float delta)
  {
    return new Vector2(
        v.x * Mathf.Cos(delta) - v.y * Mathf.Sin(delta),
        v.x * Mathf.Sin(delta) + v.y * Mathf.Cos(delta)
    );
  }
  public void Apply()
  {
    rotate(mDir, mAngleInRadians);
  }
}

public class TextToShape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
