using UnityEngine;
using System.Collections;

public class BlockScript : MonoBehaviour {

    Renderer rend;
    public bool partOfPuzzle, correct;
    BoardScript board;

    void Start() {
        rend = GetComponent<Renderer>();
        board = GetComponentInParent<BoardScript>();


        if (!partOfPuzzle) {
            correct = true;
        }
    }

    void OnMouseOver() {
        if (Input.GetMouseButton(0)) {
            Debug.Log(this.gameObject.name + " left click");
            rend.material.color = Color.green;
            if (partOfPuzzle) {
                correct = true;
            }
            else {
                correct = false;
            }
            board.CheckIfCorrect();
        }
        if (Input.GetMouseButton(1)) {
            Debug.Log(this.gameObject.name + " right click");
            rend.material.color = Color.red;
            if (!partOfPuzzle) {
                correct = true;
            }
        }
    }
}
