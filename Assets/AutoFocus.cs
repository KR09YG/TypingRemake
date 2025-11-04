using TMPro;
using UnityEngine;

public class AutoFocus : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputField;
    private void Start()
    {
        FocusInputField();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            FocusInputField();
        }
    }

    private void FocusInputField()
    {
        _inputField.Select();
        _inputField.ActivateInputField();
    }
}
