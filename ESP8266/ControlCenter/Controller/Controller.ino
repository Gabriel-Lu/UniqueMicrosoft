#include "DHT.h"
#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>

/*** DHT Define ***/
#define DHTTYPE DHT11 
#define DHT_PIN 0 
DHT dht = DHT(DHT_PIN, DHTTYPE);

/** OLED Define **/
//pins 4(SDA) and 5(SCL)
//4-D2  5-D1
#define SDA 4
#define SCL 5
#define OLED_RESET 0
Adafruit_SSD1306 display(OLED_RESET);

/** 人体热感应 Define **/
#define D0 16

void setup() 
{
   Serial.begin(9600);
   display.begin(SSD1306_SWITCHCAPVCC, 0x3C);
   pinMode(D0,INPUT);
}

void loop() 
{
  
/** 显示是否有人 **/
  //display.fillScreen(WHITE);
  //display.display();
  //delay(2000);
  //display.clearDisplay();
  int sensor_red = digitalRead(D0);
  
   /** 显示温度湿度 **/
  int h = dht.readHumidity();//读湿度
  int t = dht.readTemperature();//读温度，默认为摄氏度
  int light=analogRead(A0);
  
  display.setCursor(0,0);
  //display.println(sensor_red);
  display.setTextColor(WHITE,BLACK); // 'inverted' text
  display.setTextSize(2);
  if(sensor_red)
  {
    display.println("Person detected");
    }
   else
   {
      display.println("No person detected");
   }
  
  display.display();
  delay(1000);
  display.clearDisplay();

  display.setTextSize(1);
  display.setCursor(0,0);
  display.print("Humi:");
  display.println(h);
  display.print("Temp:");
  display.println(t);
  display.print("Light:");
  display.println(light);
  display.display();
  delay(1000);
  display.clearDisplay();
  
 /*
  Serial.print("Humidity: ");//湿度
  Serial.println(h);
  Serial.print("Temperature: ");//温度
  Serial.print(t);
*/
  
}
