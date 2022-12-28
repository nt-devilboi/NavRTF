using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class Router : MonoBehaviour
{
    private Dictionary<string, GameObject> _rooms = new Dictionary<string, GameObject>();
    private NavMeshAgent _main;
    private TrailRenderer _trailRenderer;
    public GameObject[] target;
    public TMP_InputField InputFieldTo;
    public TMP_InputField InputFieldFrom;
    public GameObject Player;


    // Start is called before the first frame update
    void Start()
    {
        _main = GetComponent<NavMeshAgent>();
        _trailRenderer = GetComponent<TrailRenderer>();
        SetRooms();
    }

    private void SetRooms()
    {
        foreach (var gameObject in target)
            _rooms.Add(gameObject.name, gameObject);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void GoToCheckPoint()
    {
        if (_rooms.ContainsKey(InputFieldTo.text) && _main.autoBraking)
        {
            _main.SetDestination(_rooms[InputFieldTo.text].transform.position);
            _trailRenderer.enabled = true;
        }

        if (_rooms.ContainsKey(InputFieldFrom.text))
        {
            transform.position = _rooms[InputFieldFrom.text].transform.position;
            _trailRenderer.Clear();
            Player.transform.position = _rooms[InputFieldFrom.text].transform.position;
        }
    }

    public void Stop()
    {
        _main.isStopped = !_main.isStopped;
    }
}