import pi2argon as p2a
import socket

def getTemp(deviceID):
    data = p2a.getVariable(deviceID, 'temp')
    
    return data['result'] if data['name'] == 'temp' else 'Failed request for getTemp'

def getHumidity(deviceID):
    data = p2a.getVariable(deviceID, 'humidity')

    return data['result'] if data['name'] == 'humidity' else 'Failed request for getHumidity'

