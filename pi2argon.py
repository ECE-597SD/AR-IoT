import requests
import json


#Setup for particle information
PARTICLE_URL = 'https://api.particle.io'
TOKEN = 'token'


# ping method will be used to ping a device
def ping(deviceID):
    load = f'/v1/devices/{deviceID}/ping'
    data = {'access_token': TOKEN}

    req = PARTICLE_URL + load
    res = requests.put(req, data)

    res_dict = json.loads(res)
 
    return res_dict


# getVariable method will send HTTP request to access a certain variable value
def getVariable(deviceID, varName):
    load = f'/v1/devices/{deviceID}/{varName}'
    access_token = f'?access_token={TOKEN}'

    req = PARTICLE_URL + load + access_token
    res = requests.get(req)
    res_dict = json.loads(res.text)

    return res_dict


# callFunction method uses HTTP post a request to perform function with argument
def callFunction(deviceID, func, args):
    load = f'/v1/devices/{deviceID}/{func}'
    data = {'arg': args, 'access_token': TOKEN}

    req = PARTICLE_URL + load
    res = requests.post(req, data)
    
    res_dict = json.loads(res)

    return res_dict


# getDeviceInfo will use HTTP request to get a list of devices and their info
def getDeviceInfo():
    req = PARTICLE_URL + f'/v1/devices?access_token={TOKEN}'
    res = requests.get(req)

    return json.loads(res)
