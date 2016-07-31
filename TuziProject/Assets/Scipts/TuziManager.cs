using UnityEngine;
using System.Collections;

public class TuziManager : MonoBehaviour {

    public float weight = 48.0f;// kg
    public float height = 160.0f;// cm
    //public float age;
    //private HumanBone duzi_adjust;
    private GameObject duzi_adjust;

    private GameObject rightDaTui_adjust;
    private GameObject leftDaTui_adjust;
    private GameObject rightXiaoTui_adjust;
    private GameObject leftXiaoTui_adjust;

    private GameObject leftArm_adjust;
    private GameObject rightArm_adjust;
    private GameObject leftXiaoBi_adjust;
    private GameObject rightXiaoBi_adjust;

    private float lastWeight;
    private float lastHeight;
    // Use this for initialization
    public static TuziManager tuziManager;

    void Awake()
    {
        tuziManager = new TuziManager();
        tuziManager.init();
    }


    void Start () {
        init();
        changeSize();

    }

    // Update is called once per frame
    void Update() {

        if (height != lastHeight || weight != lastWeight)
        {
            changeSize();
        }

	}
    void init()
    {
        duzi_adjust = GameObject.Find("woman:Duzi_adjust");

        rightDaTui_adjust = GameObject.Find("woman:RightDaTui_adjust");
        leftDaTui_adjust = GameObject.Find("woman:LeftDaTui_adjust");
        rightXiaoTui_adjust = GameObject.Find("woman:RightXiaoTui_adjust");
        leftXiaoTui_adjust = GameObject.Find("woman:LeftXiaoTui_adjust");

        leftArm_adjust = GameObject.Find("woman:LeftArm_adjust");
        rightArm_adjust = GameObject.Find("woman:RightArm_adjust");
        leftXiaoBi_adjust = GameObject.Find("woman:LeftXiaoBi_adjust");
        rightXiaoBi_adjust = GameObject.Find("woman:RightXiaoBi_adjust");

    }

    void changeSize()
    {
        float biaozhunTizhong = (height - 80) * 0.6f;
        float scaleTime = weight / biaozhunTizhong;

        if(float.IsInfinity(scaleTime))
        {
            scaleTime = 1;
        }

        lastHeight = height;
        lastWeight = weight;

        duzi_adjust.transform.localScale = new Vector3(scaleTime, 1, scaleTime * scaleTime);

        rightDaTui_adjust.transform.localScale = new Vector3(scaleTime, 1, scaleTime);
        leftDaTui_adjust.transform.localScale = new Vector3(scaleTime, 1, scaleTime);

        rightXiaoTui_adjust.transform.localScale = new Vector3(scaleTime, 1, scaleTime);
        leftXiaoTui_adjust.transform.localScale = new Vector3(scaleTime, 1, scaleTime);

        leftArm_adjust.transform.localScale = new Vector3(scaleTime * Mathf.Sqrt(scaleTime), 1, scaleTime);
        rightArm_adjust.transform.localScale = new Vector3(scaleTime * Mathf.Sqrt(scaleTime), 1, scaleTime);

        leftXiaoBi_adjust.transform.localScale = new Vector3(scaleTime * Mathf.Sqrt(scaleTime), 1, scaleTime);
        rightXiaoBi_adjust.transform.localScale = new Vector3(scaleTime * Mathf.Sqrt(scaleTime), 1, scaleTime);
    }
}
