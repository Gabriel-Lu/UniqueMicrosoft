#include <ESP8266WiFi.h>

#define PIN_AO A0    
const int trig=12;//D6
const int echo=13;//D7

#define Car_VCC 4 
#define Car_GND 5 

/*WiFi Config*/
const char *ssid = "Nokia7";//这里是我的wifi，你使用时修改为你要连接的wifi ssid
const char *password = "123456789@";//你要连接的wifi密码
const char *host = "192.168.43.70";//修改为你建立的Server服务端的IP地址
WiFiClient client;
const int tcpPort = 2018;//修改为你建立的Server服务端的端口号



long IntervalTime=0;

void setup() {  
 
  pinMode(echo,INPUT);
  pinMode(trig,OUTPUT);  
  pinMode(Car_VCC, OUTPUT);  
  pinMode(Car_GND, OUTPUT);    
  Serial.begin(9600);  
  WiFiConfig();
  delay(500);  
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
    }

    while (client.available())//available()同ARDUINO，不解释了
    {

      client.write("Hello");
      delay(2000);
    }
  

     int dis=Distance();
     //使用超声波传感器 测距，控制行进距离
     if(dis>3)
     {
      digitalWrite(Car_VCC,HIGH);
      digitalWrite(Car_GND,LOW);
      //土壤 analogRead(PIN_AO)
      //超声波距离 dis
      //时间自己做DateTime.Now
      //id根据超声波距离判断
      String data=(String)analogRead(PIN_AO);
      data.concat(",");
      data.concat((String)dis);
      
      
      client.println(data);
      Serial.println(data);
      data="";
     }    
     
      delay(500);    
}   



int Distance()
{
    digitalWrite(trig,HIGH);
    delayMicroseconds(15);
    digitalWrite(trig,LOW);
    IntervalTime=pulseIn(echo,HIGH);
    //单位是CM
    float S=IntervalTime/58.00;
    int s1=(int)S;
    S=0;IntervalTime=0;
    delay(50);
    return s1;
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

