/*
 Name:		Telemetry.ino
 Created:	3/9/2018 11:00:25 PM
 Author:	amaury
*/
int value = 0;

// the setup function runs once when you press reset or power the board
void setup() {
  pinMode(13,OUTPUT);
  pinMode(12,INPUT);
  pinMode(11,OUTPUT);
  digitalWrite(13,HIGH);
}

// the loop function runs over and over again until power down or reset
void loop() {
  delay(500);
  if (digitalRead(12) == HIGH) {
    digitalWrite(13,LOW);
  } else {
    digitalWrite(13,HIGH);
  }
}
