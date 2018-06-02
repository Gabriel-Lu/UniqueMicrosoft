#include <ArduinoJson.h>
#include "DHT.h"
#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>
#include <ESP8266WiFi.h>

/*WiFi Config*/
const char *ssid = "Nokia7";//这里是我的wifi，你使用时修改为你要连接的wifi ssid
const char *password = "123456789@";//你要连接的wifi密码
const char *host = "192.168.43.70";//修改为你建立的Server服务端的IP地址
WiFiClient client;
const int tcpPort = 2018;//修改为你建立的Server服务端的端口号


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

//用于接收Json
StaticJsonBuffer<200> jsonBuffer;
String socketJson;
void setup() 
{
   WiFiConfig();
   JsonObject&root=jsonBuffer.createObject();
   Serial.begin(9600);
   delay(10);
   display.begin(SSD1306_SWITCHCAPVCC, 0x3C);
   pinMode(D0,INPUT);
}

void loop() 
{
   while (!client.connected())//几个非连接的异常处理
    {
        if (!client.connect(host, tcpPort))
        {
            Serial.println("connection....");
            //client.stop();
            delay(500);
 
        }
        display.setCursor(0,0);
        //display.println(sensor_red);
        display.setTextColor(WHITE,BLACK); // 'inverted' text
        display.setTextSize(2);
        display.println("No person detected");
        display.display();
        delay(20);
        display.clearDisplay();
    }
    while (client.available())//available()同ARDUINO，不解释了
    {

      client.write("Hello");
      delay(2000);
      /*
        char val = client.read();//read()同arduino
        if(val=='a'){//pc端发送0和1来控制
           digitalWrite(relay1, LOW);
        }
        if(val=='b')
        {
            digitalWrite(relay1, HIGH);
        }
        */
    }

  
  
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
  root["Humi"]=h;
  display.print("Temp:");
  display.println(t);
  root["Temp"]=t;
  display.print("Light:");
  display.println(light);
  root["Light"]=light;
  display.display();
  delay(1000);
  display.clearDisplay();
  
  root.printTo(socketJson);
  client.write(socketJson);
  delay(200);
  
 /*
  Serial.print("Humidity: ");//湿度
  Serial.println(h);
  Serial.print("Temperature: ");//温度
  Serial.print(t);
*/
  
}



void WiFiConfig()
{
    Serial.print("Connecting to ");//写几句提示，哈哈
    Serial.println(ssid);
 
    WiFi.begin(ssid, password);
 
    while (WiFi.status() != WL_CONNECTED)//WiFi.status() ，这个函数是wifi连接状态，返回wifi链接状态
                                         //这里就不一一赘述它返回的数据了，有兴趣的到ESP8266WiFi.cpp中查看
    {
        delay(500);
        Serial.print(".");
    }//如果没有连通向串口发送.....
 
    Serial.println("");
    Serial.println("WiFi connected");
    Serial.println("IP address: ");
    Serial.println(WiFi.localIP());//WiFi.localIP()返回8266获得的ip地址
  
}
