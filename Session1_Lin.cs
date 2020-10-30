// LIBRARTES
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CODE STRUCTURE
public class Session1_Lin : MonoBehaviour
{
    // FUNCTIONS

    // 1.VARIABLES-can be devided into two types which are persistent and local
    // DECLARE VARIABLES: Scope(visibility)-Type(numbers,words,logical)-Name-Value(optional)

    // THE FIRST TYPE: NUMBER
    public int linSecondWholeNumber = 5;
    public int linFirstWholeNumber = 6;
    private int linThirdWholeNumber = 7;
    public float linFirstDecimalNumber = 1.22259153984f;
    public double linFirstLongDecimalNumber = 1.123456789112345678911234567891f;

    // The Seond Tybe: Text
    public string linFirstWords = "This is my first code!";
    private string linFirstPrivateWorld = "You can't see me.";

    // The Third Type: LOGICAL :Binary true or false
    private bool linFirstBoolean = false;
    public bool linSecondBoolean = true;
    public bool linThirdBoolean = false;

    // 2.DATA STRUCTURES
    // DECLARE DATA STRUCTURE: Scope-Type-Name-Values

    // The First Type: Arrays
    public int[] linWholeNumbersCollection = new int[5];
    public int[] linSecondWholeNumbersCollection = new int[3];
    public float[] linFirstDecimalNumbersCollections = { 1.5f, 2.6f, 6.3f };

    // Lists
    public List<int> linFirstIntList = new List<int>();

    // 3.Functions
    // Declare functions：Scope-Type-Variables-Body (instruction)

    // First Function
    private int CalculatorDiffer (int _First, int _Second, int _Third)
    {
        int Result = _First - _Second + _Third ;
        return Result;
    }

    // Start is called before the first frame update
    void Start()
    {

        // Create a new empty dictionary call "RC3Studio"
        Dictionary<string, string> rC3studio = new Dictionary<string, string>();

        // Add teamates' name
        rC3studio.Add("Li", "Lin");
        rC3studio.Add("Zhang", "Daxin");
        rC3studio.Add("Dai", "Xiangyun");
        rC3studio.Add("Zhou", "Hongyue");

        Dictionary<string, string>.KeyCollection keyCol = rC3studio.Keys;
        foreach (string key in keyCol)
        {
            Debug.Log( "Student name:"+key+rC3studio[key]);
        }
    }

 


       
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
