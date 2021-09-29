# Project-3 - User Interaction with IoT Devices using Augmented Reality
## Motivation
Current IoT solutions require a separate application for each IoT device, which makes managing and interacting with these devices tedious and challenging. Additionally, smart home solutions to address accessibility are meant to cater to everyone. Thus, increased convenience is desired. 


## Design Goals
General: Our solution is to create a convenient one app solution to controlling and managing N IoT devices.

1. Automatically detect IoT devices upon scan.
2. Ability to configure IoT devices once detected.
3. Abstract control using augmented reality.


## Deliverables
1. Create an AR app to configure and control IoT devices.
2. Discover IoT devices automatically in AR.
3. Visualize sensor data in AR.
4. Control IoT devices through digital knobs in AR, and visualize its effects.
5. IoT Devices

## Hardware/Software Requirements
#### Hardware:
- Each IoT device shall communicate with the IoT main controller
- Each IoT device shall be configured using the IoT main controller
- IoT solutions shall be modular

#### Software:
- AR App shall detect unique identifiers using Unity Vuforia
- AR App shall track each identified visually
- AR App shall communicate with IoT Main Controller to distribute control commands

## System Block Diagram
![](https://github.com/ECE-597SD/Project-3/blob/main/media/IoT-block-v2.PNG)

## Team Responsibilites
Andrew and Aidas: IoT communication, development of the communication between the IoT devices and the AR application
Anvita and Philip: IoT heterogenous device solution, transforming the sensors, actuators, ect. into IoT devices
Jeffrey: AR application, development of the app detects the IoT devices

## Schedule
![](https://github.com/ECE-597SD/Project-3/blob/main/media/gantt%20chart.PNG)
We want to spend a majority of time on development phase and will work in an agile-like workflow.

## References
[1] Browsing the Web of Things in Mobile Augmented Reality, HotMobile’19

[2] Browsing the Web of Connectable Things, EWSN’20 https://lab11.eecs.berkeley.edu/content/pubs/zachariah20summon.pdf 

[3] Jo, D., Kim, G.J. IoT + AR: pervasive and augmented environments for “Digi-log” shopping experience. Hum. Cent. Comput. Inf. Sci. 9, 1 (2019)
