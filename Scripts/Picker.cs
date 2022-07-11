using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;

public class Picker : Agent
{
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;
    public GameObject p5;
    public GameObject p6;
    public GameObject p7;
    public GameObject p8;
    public GameObject p9;

    Rigidbody m_p1;
    Rigidbody m_p2;
    Rigidbody m_p3;
    Rigidbody m_p4;
    Rigidbody m_p5; 
    Rigidbody m_p6;
    Rigidbody m_p7;
    Rigidbody m_p8;
    Rigidbody m_p9;

    public GameObject redobject;
    public GameObject blueobject;
    public GameObject greenobject;

    public override void Initialize()
    {
        m_p1 = p1.GetComponent<Rigidbody>();
        m_p2 = p2.GetComponent<Rigidbody>();
        m_p3 = p3.GetComponent<Rigidbody>();
        m_p4 = p4.GetComponent<Rigidbody>();
        m_p5 = p5.GetComponent<Rigidbody>();
        m_p6 = p6.GetComponent<Rigidbody>();
        m_p7 = p7.GetComponent<Rigidbody>();
        m_p8 = p8.GetComponent<Rigidbody>();
        m_p9 = p9.GetComponent<Rigidbody>();
    }

    public override void OnEpisodeBegin()
    {
        p1.transform.position = new Vector3(0f, 0f, 0f) + transform.position;
        p1.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
        m_p1.velocity = Vector3.zero;
        m_p1.angularVelocity = Vector3.zero;

        p2.transform.position = new Vector3(0f, 0f, 0f) + transform.position;
        p2.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
        m_p2.velocity = Vector3.zero;
        m_p2.angularVelocity = Vector3.zero;

        p3.transform.position = new Vector3(0f, 0f, 0f) + transform.position;
        p3.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
        m_p3.velocity = Vector3.zero;
        m_p3.angularVelocity = Vector3.zero;

        p4.transform.position = new Vector3(0f, 0f, 0f) + transform.position;
        p4.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
        m_p4.velocity = Vector3.zero;
        m_p4.angularVelocity = Vector3.zero;

        p5.transform.position = new Vector3(0f, 0f, 0f) + transform.position;
        p5.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
        m_p5.velocity = Vector3.zero;
        m_p5.angularVelocity = Vector3.zero;

        p6.transform.position = new Vector3(0f, 0f, 0f) + transform.position;
        p6.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
        m_p6.velocity = Vector3.zero;
        m_p6.angularVelocity = Vector3.zero;

        p7.transform.position = new Vector3(0f, 0f, 0f) + transform.position;
        p7.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
        m_p7.velocity = Vector3.zero;
        m_p7.angularVelocity = Vector3.zero;

        p8.transform.position = new Vector3(0f, 0f, 0f) + transform.position;
        p8.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
        m_p8.velocity = Vector3.zero;
        m_p8.angularVelocity = Vector3.zero;

        p9.transform.position = new Vector3(0f, 0f, 0f) + transform.position;
        p9.transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
        m_p9.velocity = Vector3.zero;
        m_p9.angularVelocity = Vector3.zero;
    }

    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(p1.transform.localPosition);
        sensor.AddObservation(p1.transform.rotation);
        sensor.AddObservation(m_p1.angularVelocity);
        sensor.AddObservation(m_p1.velocity);

        sensor.AddObservation(p2.transform.localPosition);
        sensor.AddObservation(p2.transform.rotation);
        sensor.AddObservation(m_p2.angularVelocity);
        sensor.AddObservation(m_p2.velocity);

        sensor.AddObservation(p3.transform.localPosition);
        sensor.AddObservation(p3.transform.rotation);
        sensor.AddObservation(m_p3.angularVelocity);
        sensor.AddObservation(m_p3.velocity);

        sensor.AddObservation(p4.transform.localPosition);
        sensor.AddObservation(p4.transform.rotation);
        sensor.AddObservation(m_p4.angularVelocity);
        sensor.AddObservation(m_p4.velocity);

        sensor.AddObservation(p5.transform.localPosition);
        sensor.AddObservation(p5.transform.rotation);
        sensor.AddObservation(m_p5.angularVelocity);
        sensor.AddObservation(m_p5.velocity);

        sensor.AddObservation(p6.transform.localPosition);
        sensor.AddObservation(p6.transform.rotation);
        sensor.AddObservation(m_p6.angularVelocity);
        sensor.AddObservation(m_p6.velocity);

        sensor.AddObservation(p7.transform.localPosition);
        sensor.AddObservation(p7.transform.rotation);
        sensor.AddObservation(m_p7.angularVelocity);
        sensor.AddObservation(m_p7.velocity);

        sensor.AddObservation(p8.transform.localPosition);
        sensor.AddObservation(p8.transform.rotation);
        sensor.AddObservation(m_p8.angularVelocity);
        sensor.AddObservation(m_p8.velocity);

        sensor.AddObservation(p9.transform.localPosition);
        sensor.AddObservation(p9.transform.rotation);
        sensor.AddObservation(m_p9.angularVelocity);
        sensor.AddObservation(m_p9.velocity);

        sensor.AddObservation(redobject.transform.localPosition);
        sensor.AddObservation(blueobject.transform.localPosition);
        sensor.AddObservation(greenobject.transform.localPosition);

    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        var torque = Mathf.Clamp(actions.ContinuousActions[1], -1f, 1f) * 150f;
        m_p1.AddTorque(new Vector3(0f, torque, 0f));

        torque = Mathf.Clamp(actions.ContinuousActions[2], -1f, 1f) * 150f;
        m_p2.AddTorque(new Vector3(0f, 0f, torque));

        torque = Mathf.Clamp(actions.ContinuousActions[3], -1f, 1f) * 150f;
        m_p3.AddTorque(new Vector3(0f, 0f, torque));

        torque = Mathf.Clamp(actions.ContinuousActions[4], -1f, 1f) * 150f;
        m_p4.AddTorque(new Vector3(0f, torque, 0f));

        torque = Mathf.Clamp(actions.ContinuousActions[5], -1f, 1f) * 150f;
        m_p5.AddTorque(new Vector3(0f, 0f, torque));

        torque = Mathf.Clamp(actions.ContinuousActions[6], -1f, 1f) * 150f;
        m_p6.AddTorque(new Vector3(0f, torque, 0f));

        torque = Mathf.Clamp(actions.ContinuousActions[7], -1f, 1f) * 150f;
        m_p7.AddTorque(new Vector3(0f, torque, 0f));

        torque = Mathf.Clamp(actions.ContinuousActions[8], -1f, 1f) * 150f;
        m_p8.AddTorque(new Vector3(0f, 0f, torque));

        torque = Mathf.Clamp(actions.ContinuousActions[9], -1f, 1f) * 150f;
        m_p9.AddTorque(new Vector3(0f, 0f, torque));
    }  
    
}
