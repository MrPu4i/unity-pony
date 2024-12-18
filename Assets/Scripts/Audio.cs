using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] GameObject BGMusic1;
    private AudioSource audioSrc1;
    [SerializeField] GameObject[] objs11;

    void Awake()
    {
        objs11 = GameObject.FindGameObjectsWithTag("Sound");
        if (objs11.Length == 0)
        {
            BGMusic1 = Instantiate(BGMusic1);
            BGMusic1.name = "BGMusic1";
            DontDestroyOnLoad(BGMusic1.gameObject);
        }
        else
        {
            BGMusic1 = GameObject.Find("BGMusic1");
        }
    }
    void Start()
    {
        audioSrc1 = BGMusic1.GetComponent<AudioSource>();
    }
}
