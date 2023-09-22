using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InGameUI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    // ¡∂¿ÃΩ∫∆Ω
    [SerializeField]
    private RectTransform lever;
    private RectTransform rectTransform;

    [SerializeField, Range(10f, 150f)]
    private float fLeverRange;

    private Vector2 inputVector;
    private bool isInput;

    private PlayerUnit PlayerUnit;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Start()
    {
        PlayerUnit = GameObject.Find("PlayerUnit").GetComponent<PlayerUnit>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Vector2 inputDir = eventData.position - rectTransform.anchoredPosition;

        Vector2 clampedDir = inputDir.magnitude < fLeverRange ? inputDir : inputDir.normalized * fLeverRange;
        lever.anchoredPosition = clampedDir;

        PlayerUnit.transform.eulerAngles = new Vector3(0, Mathf.Atan2(clampedDir.x, clampedDir.y) * Mathf.Rad2Deg, 0f);

        PlayerUnit.Move();
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 inputDir = eventData.position - rectTransform.anchoredPosition;

        Vector2 clampedDir = inputDir.magnitude < fLeverRange ? inputDir : inputDir.normalized * fLeverRange;
        lever.anchoredPosition = clampedDir;

        PlayerUnit.transform.eulerAngles = new Vector3(0, Mathf.Atan2(clampedDir.x, clampedDir.y) * Mathf.Rad2Deg, 0f);

        PlayerUnit.Move();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        lever.anchoredPosition = Vector2.zero;

        PlayerUnit.Idle();
    }
}
