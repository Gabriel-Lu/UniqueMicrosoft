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

    /*
     * 
  Serial.print("AO=");    
  Serial.print(analogRead(PIN_AO));  
  Serial.print(", DO=");    
  Serial.println(digitalRead(PIN_DO)); 
     * 
     */
     */

     //别忘了计算每秒 行进多少距离
     //这样才能适应盒子
  delay(500);    
}   
