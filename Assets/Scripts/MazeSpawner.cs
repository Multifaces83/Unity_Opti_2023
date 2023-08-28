using UnityEngine;

public class MazeSpawner : MonoBehaviour
{

	//public List<GameObject> Modules = new List<GameObject>();

	public GameObject[] Modules;

	//private List<GameObject> SpawnPoints = new List<GameObject>();

	private GameObject[] SpawnPoints;

	//private List<GameObject> MazeModules = new List<GameObject>();
	private GameObject[] MazeModules;


	// Use this for initialization
	void Start()
	{

		SpawnPoints = GameObject.FindGameObjectsWithTag("ModuleLoc");
		MazeModules = new GameObject[SpawnPoints.Length];

		for (int i = 0; i < SpawnPoints.Length; i++)
		{
			MazeModules[i] = Instantiate(Modules[Random.Range(0, Modules.Length)], SpawnPoints[i].transform.position, Quaternion.identity);
		}
		// SpawnPoints.AddRange(GameObject.FindGameObjectsWithTag("ModuleLoc"));

		// foreach (GameObject SpawnPoint in SpawnPoints)
		// {
		// 	MazeModules.Add(Instantiate(Modules[Random.Range(0, Modules.Count)], SpawnPoint.transform.position, Quaternion.identity));
		// }
	}
}
