using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Problems : MonoBehaviour
{

    public int SolveProblems;

    public Text probText;
    // Start is called before the first frame update
    void Start()
    {
        ProblemWait();
    }

    // Update is called once per frame
    void Update()
    {
        string ptext = "Problems: " + SolveProblems;
        probText.text = ptext;
    }

    IEnumerator ProblemWait()
    {
        yield return new WaitUntil(() => SolveProblems == 0);
        Destroy(this);
    }
}
