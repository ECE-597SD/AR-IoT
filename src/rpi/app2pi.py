import pi2argon as p2a
import paho.mqtt.client as mqtt


clientName = "RPI"
serverAddress = "192.168.1.12"


def connectionHandler(client, userdata, flags, rc):
    mqttClient.subscribe("argon/commands")
    # should subscribe to rest of topics in here
    # need to define list of topics to subscribe to 

def messageDecoder(client, userdata, msg):
    # runs whenever a message is received
    message = msg.payload.decode('UTF-8')

def publishTopic(client, deviceID, varName):
    client.publish(f"/devices/{deviceID}/{varName}")

# Outline for how getTemp will pull temperature information from the particle cloud
def getTemp(deviceID):
    data = p2a.getVariable(deviceID, 'temp')
    
    return data['result'] if data['name'] == 'temp' else 'Failed request for getTemp'


# Outline for how getHumidity will pull humidity information from the particle cloud
def getHumidity(deviceID):
    data = p2a.getVariable(deviceID, 'humidity')

    return data['result'] if data['name'] == 'humidity' else 'Failed request for getHumidity'



mqttClient = mqtt.Client(clientName)

mqttClient.on_connect = connectionHandler
mqttClient.on_message = messageDecoder

mqttClient.connect(serverAddress)
mqttClient.loop_forever()
