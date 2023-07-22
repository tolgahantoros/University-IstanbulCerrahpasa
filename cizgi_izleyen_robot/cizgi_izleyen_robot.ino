#include <QTRSensors.h>
#define SolMotorileri 9
#define SolMotorGeri 10
#define SagMotorileri 11
#define SagMotorGeri 12
#define ena 4
#define enb 5
 
#define KP .2
#define KD 5
#define M1_minumum_hiz 120
#define M2_minumum_hiz 120
#define M1_maksimum_hiz 210
#define M2_maksimum_hiz 210
#define MIDDLE_SENSOR 3
#define NUM_SENSORS 5
#define TIMEOUT 2500
#define EMITTER_PIN 2
#define DEBUG 0
int lastError = 0;
int last_proportional = 0;
int integral = 0;
const int in1 = 8;     
const int in2 = 9;     
const int in3 =  10;
const int in4 =  11;
QTRSensorsRC qtrrc((unsigned char[]) { 19,18,17,16,15} ,NUM_SENSORS, TIMEOUT, EMITTER_PIN);
 
unsigned int sensorValues[NUM_SENSORS];
 
void setup() {
pinMode(SolMotorileri,OUTPUT);
pinMode(SolMotorGeri,OUTPUT);
pinMode(SagMotorileri,OUTPUT);
pinMode(SagMotorGeri,OUTPUT);
pinMode(ena,OUTPUT);
pinMode(enb,OUTPUT);
pinMode(in1, OUTPUT); 
pinMode(in2, OUTPUT);  
pinMode(in3, OUTPUT);
pinMode(in4, OUTPUT);
delay(1500);
manual_calibration();
set_motors(0,0);
 
}
 
void loop() {
unsigned int sensors[5];
int position = qtrrc.readLine(sensors);
int error = position - 2000;
 
int motorSpeed = KP * error + KD * (error - lastError);
lastError = error;
 
int leftMotorSpeed = M1_minumum_hiz + motorSpeed;
int rightMotorSpeed = M2_minumum_hiz - motorSpeed;
 
set_motors(leftMotorSpeed, rightMotorSpeed);
 
}
 
void set_motors(int motor1speed, int motor2speed)
{
if (motor1speed > M1_maksimum_hiz ) motor1speed = M1_maksimum_hiz; //MAKSÝMUM MOTOR 1 HIZ LÝMÝTÝ
if (motor2speed > M2_maksimum_hiz ) motor2speed = M2_maksimum_hiz; // MAKSÝMUM MOTOR 2 HIZ LÝMÝTÝ
if (motor1speed < 0) motor1speed = 0; // MÝNIMUMMOTOER 1 HIZ LÝMÝTÝ
if (motor2speed < 0) motor2speed = 0; // MÝNÝMUM MOTOR 2 HIZ LÝMÝTÝ
analogWrite(ena,motor1speed);
analogWrite(enb,motor2speed);
digitalWrite(SolMotorileri,HIGH);
digitalWrite(SagMotorileri,HIGH);
digitalWrite(SolMotorGeri,LOW);
digitalWrite(SagMotorGeri,LOW);
digitalWrite(in1, HIGH);
digitalWrite(in2,  LOW);  
digitalWrite(in3, HIGH);
digitalWrite(in4,  LOW);
 
}
 
void manual_calibration() {
 
int i;
for (i = 0; i < 250; i++)
{
qtrrc.calibrate(QTR_EMITTERS_ON);
delay(20);
}
 
if (DEBUG) {
Serial.begin(9600);
for (int i = 0; i < NUM_SENSORS; i++)
{
Serial.print(qtrrc.calibratedMinimumOn[i]);
Serial.print(' ');
}
Serial.println();
 
for (int i = 0; i < NUM_SENSORS; i++)
{
Serial.print(qtrrc.calibratedMaximumOn[i]);
Serial.print(' ');
}
Serial.println();
Serial.println();
}
}
