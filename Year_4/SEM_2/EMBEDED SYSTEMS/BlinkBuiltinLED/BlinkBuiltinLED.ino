 /***
  * led- is the Digital pin that I've  connected my external LED.
  * LED_BUILTIN- is a Built in LED that's on the Arduino UNO Board.
  * pinMode- a function used to declare what a certain pin act as e.g OUTPUT or INPUT.
  * digitalWrite-  function is used to set the state of a digital pin on an Arduino board e.g. HIGH or LOW.
  * delay-  function in Arduino is used to pause the execution of a program for a specified amount of time in milliseconds
  */
 int led = 2;
void setup() {
  // put your setup code here, to run once:
 pinMode(led,OUTPUT); 
 pinMode(LED_BUILTIN,OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(LED_BUILTIN,HIGH); // Here I used the default BuiltIn LED
  digitalWrite(led,HIGH); // Here I used an external LED
  delay(1000);
  digitalWrite(LED_BUILTIN,LOW);
  digitalWrite(led,LOW);
  delay(1000);
}
