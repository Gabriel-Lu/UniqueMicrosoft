void setup()
{
  // 初始化串口
  Serial.begin(9600);
}
void loop() 
{
// 读出当前光线强度，并输出到串口显示
  float sensorValue = analogRead(A0);
  Serial.println((sensorValue/(1000+sensorValue))*0.033);
  delay(1000);
}
