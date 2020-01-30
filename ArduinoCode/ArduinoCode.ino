#define UpPin 3
#define DownPin 4
#define LeftPin 5
#define RightPin 2

byte State = 0;

void setup() {
  pinMode(UpPin, INPUT_PULLUP);
  pinMode(DownPin, INPUT_PULLUP);
  pinMode(LeftPin, INPUT_PULLUP);
  pinMode(RightPin, INPUT_PULLUP);
  Serial.begin(9600);
}

void loop() {
  if(Serial.available() > 0){
    Serial.read();
    State = 0;
    State += digitalRead(UpPin) * 8;
    State += digitalRead(DownPin) * 4;
    State += digitalRead(LeftPin) * 2;
    State += digitalRead(RightPin) * 1;
    Serial.println(State);
  }

}
