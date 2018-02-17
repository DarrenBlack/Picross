using UnityEngine;
using System.Collections;

public class BoardScript : MonoBehaviour {
    
    public GameObject[] blocks = new GameObject[25];
    bool complete;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void SetPuzzle(bool[] puzzleSolution) {
        for(int i = 0; i < puzzleSolution.Length; i++) {
            blocks[i].GetComponent<BlockScript>().partOfPuzzle = puzzleSolution[i];
        }
    }

    public void CheckIfCorrect() {
        int numberCorrect = 0;
        for(int i = 0; i < blocks.Length; i++) {           

            if (blocks[i].GetComponent<BlockScript>().correct) {
                numberCorrect++;
            }
        }

        if (numberCorrect == blocks.Length) {
            Debug.Log("Puzzle Complete");
        }
    }
}
