using UnityEngine;
using UnityEngine.UI;

public class InfoPanelUI : MonoBehaviour {

    private void Awake() {
        GetComponent<Button>().onClick.AddListener(() => {
            gameObject.SetActive(false);

            Time.timeScale = 1;
        });

        Time.timeScale = 0;
        }

    }