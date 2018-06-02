#include <ESP8266WiFi.h>

#define PIN_AO A0  
#define PIN_DO 4  


#define Car_VCC 4 
#define Car_GND 5 
void setup() {    
  pinMode(Car_VCC, OUTPUT);  
  pinMode(Car_GND, OUTPUT);    
  Serial.begin(9600);    
}    
  
void loop() {  
  Serial.print("Car_Start");    

  digitalWrite(Car_VCC,HIGH);
  digitalWrite(Car_GND,LOW);
    
  delay(500);    
}   
