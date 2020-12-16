using UnityEngine;
using System.Collections;
using System.Net;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using uPLibrary.Networking.M2Mqtt.Utility;
using uPLibrary.Networking.M2Mqtt.Exceptions;
using UnityEngine.UI;

using System;
public class SensorController : MonoBehaviour
{
public string brokerIpAddress = "127.0.0.1";
	public int brokerPort = 1883;
	public string lightTopic = "casa/patio/luz";
	private MqttClient client;
	public Text statusSensor;
	string lastMessage;
	volatile bool lightState = false;
	// Use this for initialization
	void Start () {
		// create client instance 
		client = new MqttClient(IPAddress.Parse(brokerIpAddress), brokerPort, false, null); 
		
		// register to message received 
		client.MqttMsgPublishReceived += client_MqttMsgPublishReceived; 
		
		string clientId = Guid.NewGuid().ToString(); 
		client.Connect(clientId); 
		
		// subscribe to the topic "/home/temperature" with QoS 2 
		client.Subscribe(new string[] { lightTopic }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });  
	}
	void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e) 
	{ 
		Debug.Log("Received: " + System.Text.Encoding.UTF8.GetString(e.Message)  );
		lastMessage = System.Text.Encoding.UTF8.GetString(e.Message);
		if(e.Topic.Equals(lightTopic))
		{
			if(lastMessage.Equals("Encender"))
			{
                Debug.Log("Se prendio la lampara");
				lightState = true;
			}
			else if(lastMessage.Equals("Apagar"))
			{
                Debug.Log("Se apago la lampara");
				lightState = false;
			}
		}
	}

	void Update()
	{
		if(lightState)
			statusSensor.text = "Hay Actividad";
		else
			statusSensor.text = "Sin Actividad";
	}

	void OnApplicationQuit()
	{
		client.Disconnect();
	}


	private void OnTriggerEnter(Collider other) {
		if(other.CompareTag("Player"))
		{
			client.Publish(lightTopic,System.Text.Encoding.UTF8.GetBytes("Encender"),MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
		}
	}

	private void OnTriggerExit(Collider other) {
		client.Publish(lightTopic,System.Text.Encoding.UTF8.GetBytes("Apagar"),MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
	}
}
