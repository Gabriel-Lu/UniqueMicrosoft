#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>
//pins 4(SDA) and 5(SCL).
//4-D2  5-D1
#define SDA 4
#define SCL 5
#define OLED_RESET 0
Adafruit_SSD1306 display(OLED_RESET);
#define D0 16

void setup() 
{
   display.begin(SSD1306_SWITCHCAPVCC, 0x3C);
   pinMode(D0,INPUT);
}

void loop() 
{
  //display.fillScreen(WHITE);
  //display.display();
  //delay(2000);
  //display.clearDisplay();
  int sensor_red = digitalRead(D0);
  if(sensor_red)
  {
    display.println("person detected");
    }
   else
   {
      display.println("no person detected");
   }
  display.setCursor(0,0);
  display.println(sensor_red);
  display.setTextColor(WHITE,BLACK); // 'inverted' text
  display.setTextSize(2);
  display.display();
  delay(2000);
  display.clearDisplay();
}
