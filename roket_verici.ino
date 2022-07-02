

unsigned long startMillis;
unsigned long currentMillis;
const unsigned long period = 1000;

unsigned long realtime;
float takimID;
float sayac;
float irtifa;
float RoketGPSIrtifa;
float RoketEnlem;
float RoketBoylam;
float GorevYukuGPSIrtifa;
float GorevYukuEnlem;
float GorevYukuBoylam;
float kademeGPSirtifa;
float kademeEnlem;
float kademeBoylam;
float jiroskop_X;
float jiroskop_Y;
float jiroskop_Z;
float ivme_x;
float ivme_y;
float ivme_z;
float aci;
byte durum;


void setup() {
randomSeed(analogRead(0));

takimID = 0;
sayac = 0;
irtifa = 0;
RoketGPSIrtifa = 0;
RoketEnlem = 0;
RoketBoylam = 0;
GorevYukuGPSIrtifa = 0;
GorevYukuEnlem = 0;
GorevYukuBoylam = 0;
kademeGPSirtifa = 0;
kademeEnlem = 0;
kademeBoylam = 0;
jiroskop_X = 0;
jiroskop_Y = 0;
jiroskop_Z = 0;
ivme_x = 0;
ivme_y = 0;
ivme_z= 0;
aci = 0;
durum = 0;


  Serial.begin(19200);

  
startMillis = millis();
  
}


void loop() {
  
  currentMillis = millis();
  realtime = currentMillis - startMillis;
  realtime = realtime;
 

  takimID = 1;
  sayac = 2;
  irtifa = 10.2;
  RoketGPSIrtifa = 1461.55;
  RoketEnlem = 39.925019;
  RoketBoylam = 32.836954;
  GorevYukuGPSIrtifa = 1361.61;
  GorevYukuEnlem = 41.104593;
  GorevYukuBoylam = 29.024411;
  kademeGPSirtifa = 1666.61;
  kademeEnlem = 41.091485;
  kademeBoylam = 29.061412;
  jiroskop_X = 1.51;
  jiroskop_Y = 0.49;
  jiroskop_Z = 0.61;
  ivme_x = 0.0411;
  ivme_y = 0.0140;
  ivme_z= -0.9552;
  aci = 5.08;
  durum = 1;



  
  Serial.print("A");
  Serial.print(";");
  Serial.print(realtime);
  Serial.print(";");
  Serial.print(takimID);
  Serial.print(";");
  Serial.print(sayac);
  Serial.print(";");
  Serial.print(irtifa,1);
  Serial.print(";");
  Serial.print(RoketGPSIrtifa,2);
  Serial.print(";");
  Serial.print(RoketEnlem,6);
  Serial.print(";");
  Serial.print(RoketBoylam,6);
  Serial.print(";");
  Serial.print(GorevYukuGPSIrtifa,2);
  Serial.print(";");
  Serial.print(GorevYukuEnlem,6);
  Serial.print(";");
  Serial.print(GorevYukuBoylam,6);
  Serial.print(";");
  Serial.print(kademeGPSirtifa,2);
  Serial.print(";");
  Serial.print(kademeEnlem,6);
  Serial.print(";");
  Serial.print(kademeBoylam,6);
  Serial.print(";");
  Serial.print(jiroskop_X,2);
  Serial.print(";");
  Serial.print(jiroskop_Y,2);
  Serial.print(";");
  Serial.print(jiroskop_Z,2);
  Serial.print(";");
  Serial.print(ivme_x,4);
  Serial.print(";");
  Serial.print(ivme_y,4);
  Serial.print(";");
  Serial.print(ivme_z,4);
  Serial.print(";");
  Serial.print(aci,2);
  Serial.print(";");
  Serial.print(durum);
  Serial.print(";");
  Serial.println("B");
  delay(1000);
}
