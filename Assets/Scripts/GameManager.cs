using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject basicRoad;
    private Vector3 startPosition;
    private int numberOfRoad = 10;
    private Vector3 nextPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = new Vector3(0, 0, 0);
        nextPosition = startPosition;
        for (int i = 0; i < numberOfRoad; i++)
        {
            CreateBasicRoad();
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void CreateBasicRoad()
    {
        GameObject road = Instantiate(basicRoad, nextPosition, Quaternion.identity);
        nextPosition = road.gameObject.transform.Find("NextRoadPosition").transform.position;
    }
}
