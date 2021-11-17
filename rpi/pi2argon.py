import requests
import json
from requests.models import HTTPBasicAuth

#Setup for particle information
PARTICLE_URL = 'https://api.particle.io'

class ParticleClient:
    # authentication for client
    def __init__(self, username, password):
        auth_url = PARTICLE_URL+"/oauth/token"
        auth = HTTPBasicAuth("particle", "particle")
        data = {
            'grant_type': "password",
            'username': username,
            'password': password,
            'expires_in': 300
        }   
        res = requests.post(auth_url, data, auth=auth)
        print(res.text)
        j_res = json.loads(res.text)
        self.access_token = j_res["access_token"]

    # getDevices uses HTTP get request to list all devices with relevant information
    def getDevices(self):
        req = PARTICLE_URL + f'/v1/devices?access_token={self.access_token}'
        res = requests.get(req)

        return json.loads(res.text)

    # ping method will be used to ping a device
    def ping(self,deviceID):
        load = f'/v1/devices/{deviceID}/ping'
        data = {'access_token': self.access_token}

        req = PARTICLE_URL + load
        res = requests.put(req, data)

        res_dict = json.loads(res.text)
    
        return res_dict

    # getVariable method will send HTTP GET request to access a certain variable from device
    def getVariable(self, deviceID, varName):
        load = f'/v1/devices/{deviceID}/{varName}'
        access_token = f'?access_token={self.access_token}'

        req = PARTICLE_URL + load + access_token
        res = requests.get(req)
        res_dict = json.loads(res.text)

        return res_dict

    # callFunction method will send HTTP POST request to call function on device
    def callFunction(self, deviceID, func, args):
        load = f'/v1/devices/{deviceID}/{func}'
        data = {'arg': args, 'access_token': self.access_token}

        req = PARTICLE_URL + load
        res = requests.post(req, data)
        
        res_dict = json.loads(res.text)  

        return res_dict

username = 'pcolladay@umass.edu'
password = 'ECE597SD'
particle = ParticleClient(username, password)

print(particle.getDevices())

