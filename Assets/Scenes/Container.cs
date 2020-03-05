using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Container : MonoBehaviour
{

    [SerializeField] private Transform _topWall;
    [SerializeField] private Transform _leftWall;
    [SerializeField] private Transform _rightWall;
    [SerializeField] private Transform _floor;
    [SerializeField] private Transform _backWall;
    [SerializeField] private float _thickness = 0.1f;
    [SerializeField] private float _depth = 2.01f;
    
    
    public void SetContainerSize(float w, float h)
    {
        w /= 3f;
        h /= 3f;
        _backWall.localPosition = new Vector3(0, h/2, -transform.localPosition.z);
        _topWall.localPosition = new Vector3(_topWall.localPosition.x, h, _topWall.localPosition.z);
        _floor.localPosition = new Vector3(_floor.localPosition.x, 0, _floor.localPosition.z);
        _rightWall.localPosition = new Vector3(w/2f, h/2f, _rightWall.localPosition.z);
        _leftWall.localPosition = new Vector3(-w/2f, h/2f, _leftWall.localPosition.z);
        
        _backWall.localScale = new Vector3(w+_thickness, h+_thickness, _thickness);
        _topWall.localScale = new Vector3(w+_thickness, _thickness, _topWall.localScale.z);
        _floor.localScale = _topWall.localScale;
        _rightWall.localScale = new Vector3(_thickness, h+_thickness, _rightWall.localScale.z);
        _leftWall.localScale = _rightWall.localScale; 
    }
    
    // Start is called before the first frame update
    void Start()
    {
        SetContainerSize(8f,8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
