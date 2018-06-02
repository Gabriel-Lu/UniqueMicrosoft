#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>
//pins 4(SDA) and 5(SCL).
//4-D2  5-D1
#define SDA 4
#define SCL 5
#define OLED_RESET 0
Adafruit_SSD1306 display(OLED_RESET);

void setup() 
{
   display.begin(SSD1306_SWITCHCAPVCC, 0x3C);

}

void loop() 
{
  //display.fillScreen(WHITE);
  //display.display();
  //delay(2000);
  //display.clearDisplay();
  display.setCursor(0,0);
  display.println("Hello, Arduino!");
  display.setTextColor(WHITE,BLACK); // 'inverted' text
  display.setTextSize(2);
  display.display();
  delay(2000);
  display.clearDisplay();
}
