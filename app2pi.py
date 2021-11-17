import pi2argon as p2a
import socket


# Outline for how getTemp will pull temperature information from the particle cloud
def getTemp(deviceID):
    data = p2a.getVariable(deviceID, 'temp')
    
    return data['result'] if data['name'] == 'temp' else 'Failed request for getTemp'


# Outline for how getHumidity will pull humidity information from the particle cloud
def getHumidity(deviceID):
    data = p2a.getVariable(deviceID, 'humidity')

    return data['result'] if data['name'] == 'humidity' else 'Failed request for getHumidity'

