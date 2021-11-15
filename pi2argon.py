import requests
import json

PARTICLE_URL = 'https://api.particle.io'
TOKEN = 'token'

def ping(deviceID):
    load = f'/v1/devices/{deviceID}/ping'
    data = {'access_token': TOKEN}

    req = PARTICLE_URL + load
    res = requests.put(req, data)

    res_dict = json.loads(res)
 
    return res_dict


def getVariable(deviceID, varName):
    load = f'/v1/devices/{deviceID}/{varName}'
    access_token = f'?access_token={TOKEN}'

    req = PARTICLE_URL + load + access_token
    res = requests.get(req)
    res_dict = json.loads(res.text)

    return res_dict


def callFunction(deviceID, func, args):
    load = f'/v1/devices/{deviceID}/{func}'
    data = {'arg': args, 'access_token': TOKEN}

    req = PARTICLE_URL + load
    res = requests.post(req, data)
    
    res_dict = json.loads(res)

    return res_dict


def getDeviceInfo():
    req = PARTICLE_URL + f'/v1/devices?access_token={TOKEN}'
    res = requests.get(req)

    return json.loads(res)