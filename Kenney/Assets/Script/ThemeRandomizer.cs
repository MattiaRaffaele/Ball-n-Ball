using UnityEngine;

public class ThemeRandomizer : MonoBehaviour
{
    [SerializeField] GameObject Plane;
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Enemy;
    [SerializeField] GameObject Allay;

    private void Start()
    {
        Mountain();
    }

    public void Space()
    {
        Plane.GetComponent<Renderer>().material.color = new Color (38,15,38);
        Player.GetComponent<Renderer>().material.color = new Color(242, 208, 189);
        Enemy.GetComponent<Renderer>().material.color = new Color(242, 98, 65);
        Allay.GetComponent<Renderer>().material.color = new Color(89, 2, 59);
    }
    public void Mountain()
    {
        Plane.GetComponent<SpriteRenderer>().color = new Color(16,32,38);
        Player.GetComponent<SpriteRenderer>().color = new Color(192,217,139);
        Enemy.GetComponentInChildren<SpriteRenderer>().color = new Color(96,166,114);
        Allay.GetComponent<SpriteRenderer>().color = new Color(13,64,59);
    }
}