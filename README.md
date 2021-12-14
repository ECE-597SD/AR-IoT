# User Interaction with IoT Devices using Augmented Reality
A proof of concept augemented reality application to configure, control, and use IoT devices

## IoT Hardware Setup
![Hardware Setup](media/hardware-setup.png)

## Connect Device to Internet
1. Setup hardware connections
2. Download [Particle IoT App](https://play.google.com/store/apps/details?id=io.particle.android.app&hl=en_US&gl=US) on mobile device and sign in
4. Add Particle Argon device
5. Connect Particle to network from device settings

## Installing Device Firmware
1. Go to [Particle Console](https://console.particle.io/) and sign in
2. Go to Web IDE and select device
3. Copy and paste [firmware](https://github.com/ECE-597SD/Project-3/blob/main/src/argon/ARIoT.ino) from repo into Web IDE
4. Flash onto device

## App Installation Instructions
Android: Download .apk file to phone and install

iOS: Download app from Apple App Store (not published yet)

## Manually Building App Instructions
Contact team for full project source files
### Android
1. Connect phone to computer in USB Development mode
2. Open project in Unity
3. Go to File > Build Settings 
4. Select Android as platform
5. Select your device under "Run Device". 
6. Build

### iOS
1. Go to File > Build Settings
2. Select iOS as platform
3. Build to Xcode to create Xcode project files
4. Build to iPhone using Xcode project files.
