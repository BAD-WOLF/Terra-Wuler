using UnityEngine;

public class GameController : MonoBehaviour
{

    #region PRIVATE



    #endregion

    void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
        // ObjectsManager = Resources.LoadAll<GameObject>("Manager");
        // InitManagers();
        DontDestroyOnLoad(this);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private static GameController _instance;


    public static GameController Instance
    {
        get
        {

            return _instance;
        }
    }
}