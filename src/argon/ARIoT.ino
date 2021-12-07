#include <TM1637Display.h>
#include <Grove_4Digit_Display.h>
#include <Grove_Temperature_And_Humidity_Sensor.h>
#include <Grove_ChainableLED.h>

#define DISP_CLK  D4
#define DISP_DATA  D5
#define LED_CLK   A4
#define LED_DATA  A5
#define DHT_PIN   D2

TM1637 disp(DISP_CLK, DISP_DATA);
ChainableLED leds(LED_CLK, LED_DATA, 1);
DHT dht(D2);

// variables to track
double temp, humidity;
int counter = 0;
String LED_state = "ON";


int toggleLed(String args) {                
    float colorval = 0.083;
    LED_state = args;
    if (args == "ON")           leds.setColorHSB(0, colorval , 0.5, 0.25);
    else if (args == "RED")     leds.setColorHSB(0, 1.0, 1.0, 0.25);
    else if (args == "ORANGE")  leds.setColorHSB(0, 0.058, 1.0, 0.50);
    else if (args == "YELLOW")  leds.setColorHSB(0, 0.095, 1.0, 0.25);
    else if (args == "PURPLE")  leds.setColorHSB(0, 9*colorval, 1.0, 0.25);
    else if (args == "BLUE")    leds.setColorHSB(0, 8*colorval , 1.0, 0.25);
    else if (args == "GREEN")   leds.setColorHSB(0, 4*colorval, 1.0, 0.25);
    else if (args == "OFF")     leds.setColorHSB(0, 0.0, 0.0, 0.0);
    delay(50);
    return 1;
}


int display(String args){
    int thousands, hundreds , tens, ones;
    
    if (args == "+" && counter != 9999)   counter += 1;
    else if (args == "-" && counter != 0) counter -= 1;
    else return 0;
    
    thousands = (counter % 10000)/1000;
    hundreds = (counter % 1000)/100;
    tens = (counter % 100)/10;
    ones = (counter % 10);

    disp.display(0, thousands);
    disp.display(1, hundreds);
    disp.display(2, tens);
    disp.display(3, ones);

    return 1;
}

void setup() {
    // instantiate IoT devices
    leds.init();
    leds.setColorHSB(0, 0.083, 0.5, 0.25);
    
    disp.init();                
    disp.set(BRIGHT_TYPICAL);   
    for (int i = 0; i < 4; i++) disp.display(i, 0);
    
    dht.begin();                                    

    // identify and instantiate variable and functions to the cloud
    // accessible through RESTful API (done for us through Particle I/O)
    Particle.function("display", display);
    Particle.function("toggleLed", toggleLed);  
    
    Particle.variable("counter", counter);
    Particle.variable("LED_state", LED_state);
    Particle.variable("temp", temp);           
    Particle.variable("humidity", humidity);
    
}

void loop() {
    // fetch data every iteration of loop
    temp = dht.getTempFarenheit();
    humidity = dht.getHumidity();
}
