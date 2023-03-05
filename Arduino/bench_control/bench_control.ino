#include <avr/sleep.h>

//https://www.google.com/search?q=arduino+relay+module+connection&sxsrf=ALeKk01e68bHsXYvCUPMQcY78q2loiOyRA:1604195080359&tbm=isch&source=iu&ictx=1&fir=wcc54B8WhapjmM%252CiOUFHfnX5ueTyM%252C_&vet=1&usg=AI4_-kSPwaS3b0xXiWq2D3HhiunR5YZ7ag&sa=X&ved=2ahUKEwjF6aivnODsAhWXZt4KHWPlDO8Q9QF6BAgEEEs&biw=1920&bih=937#imgrc=wcc54B8WhapjmM

// Basic 4 Realy board connection
// These data pins link to 4 Relay board pins IN1, IN2, IN3, IN4

#define RELAY_AB_CAN_HIGH    2
#define RELAY_AB_CAN_LOW     3
#define RELAY_MIB_CAN        4
#define RELAY_DOIP           5
#define RELAY_POWER_ALL      6
#define RELAY_MODE_DOWNLOAD  7
#define RELAY_RESET_ICAS3    8
#define RELAY_KL_15          9


#define EMPTY                  ""
#define HELP                   "help"
#define HELP_SHORT             "h"
#define GET_STATUS             "get status"
#define POWER_ON               "power on"
#define POWER_ON_CANOE         "power on CANOE"
#define POWER_OFF              "power off"
#define POWER_OFF_CANOE        "power off CANOE"
#define POWER_ICAS3_ON         "icas3 on"
#define POWER_ICAS3_ON_SHORT   "on"
#define POWER_ICAS3_OFF        "icas3 off"
#define POWER_ICAS3_OFF_SHORT  "off"
#define RESET_ICAS3            "icas3 reset"
#define RESET_ICAS3_SHORT      "reset"
#define MODE_DOWNLOAD          "mode download"
#define MODE_DOWNLOAD_ON       "dn"
#define MODE_NORMAL            "mode normal"
#define MODE_NORMAL_SHORT      "normal"
#define MODE_DOWNLOAD_OFF      "up"
#define KL15_ON                "kl15 on"
#define KL15_OFF               "kl15 off"
#define KLS_ON                 "kls on not working"
#define AB_CAN_ON              "abcan on"
#define AB_CAN_OFF             "abcan off"
#define MIB_CAN_ON             "mibcan on"
#define MIB_CAN_OFF            "mibcan off"
#define DOIP_ON                "doip on"
#define DOIP_OFF               "doip off"


enum Commands { ENUM_EMPTY, ENUM_ERROR, ENUM_HELP, ENUM_GET_STATUS,
                ENUM_POWER_ON, ENUM_POWER_OFF,
                ENUM_ICAS3_ON, ENUM_ICAS3_OFF, ENUM_ICAS3_RESET,
                ENUM_MODE_DOWNLOAD, ENUM_MODE_NORMAL,
                ENUM_KL15_ON, ENUM_KL15_OFF, ENUM_KLS_ON,
                ENUM_AB_CAN_ON, ENUM_AB_CAN_OFF,
                ENUM_MIB_CAN_ON, ENUM_MIB_CAN_OFF,
                ENUM_DOIP_ON, ENUM_DOIP_OFF};

String s = "";

void setup()
{

  sleep_disable();

  // Initialise the Arduino data pins for OUTPUT
  pinMode(RELAY_POWER_ALL, OUTPUT);
  pinMode(RELAY_MODE_DOWNLOAD, OUTPUT);
  pinMode(RELAY_RESET_ICAS3, OUTPUT);
  pinMode(RELAY_KL_15, OUTPUT);
  pinMode(RELAY_AB_CAN_HIGH, OUTPUT);
  pinMode(RELAY_AB_CAN_LOW, OUTPUT);
  pinMode(RELAY_MIB_CAN, OUTPUT);
  pinMode(RELAY_DOIP, OUTPUT);

  digitalWrite(RELAY_POWER_ALL, HIGH);
  digitalWrite(RELAY_MODE_DOWNLOAD, HIGH);
  digitalWrite(RELAY_RESET_ICAS3, HIGH);
  digitalWrite(RELAY_KL_15, HIGH);
  digitalWrite(RELAY_AB_CAN_HIGH, HIGH);
  digitalWrite(RELAY_AB_CAN_LOW, HIGH);
  digitalWrite(RELAY_MIB_CAN, HIGH);
  digitalWrite(RELAY_DOIP, HIGH);
  
  Serial.begin(115200);
  while (!Serial) {
    ; // wait for serial port to connect. Needed for native USB port only
  }
}

void print_help()
{
  char buff[50];
  Serial.println("\n------------");
  snprintf(buff, sizeof(buff), "HELP:            %s, %s", HELP, HELP_SHORT);
  Serial.println(buff);
  snprintf(buff, sizeof(buff), "GET_STATUS:      %s", GET_STATUS);
  Serial.println(buff);
  snprintf(buff, sizeof(buff), "POWER_ON:        %s, %s", POWER_ON, POWER_ON_CANOE);
  Serial.println(buff);
  snprintf(buff, sizeof(buff), "POWER_OFF:       %s, %s", POWER_OFF, POWER_OFF_CANOE);
  Serial.println(buff);
  snprintf(buff, sizeof(buff), "MODE_DOWNLOAD:   %s, %s", MODE_DOWNLOAD, MODE_DOWNLOAD_ON);
  Serial.println(buff);
  snprintf(buff, sizeof(buff), "MODE_NORMAL:     %s, %s, %s", MODE_NORMAL, MODE_NORMAL_SHORT, MODE_DOWNLOAD_OFF);
  Serial.println(buff);
  snprintf(buff, sizeof(buff), "RESET_ICAS3:     %s, %s", RESET_ICAS3, RESET_ICAS3_SHORT);
  Serial.println(buff);
  snprintf(buff, sizeof(buff), "KL15_ON:         %s", KL15_ON);
  Serial.println(buff);
  snprintf(buff, sizeof(buff), "KLS_ON:          %s", KLS_ON);
  Serial.println(buff);
  snprintf(buff, sizeof(buff), "AB_CAN_ON:       %s", AB_CAN_ON);
  Serial.println(buff);
  snprintf(buff, sizeof(buff), "AB_CAN_OFF:      %s", AB_CAN_OFF);
  Serial.println(buff);
  snprintf(buff, sizeof(buff), "MIB_CAN_ON:      %s", MIB_CAN_ON);
  Serial.println(buff);
  snprintf(buff, sizeof(buff), "MIB_CAN_ON:      %s", MIB_CAN_OFF);
  Serial.println(buff);
  snprintf(buff, sizeof(buff), "DOIP_ON:         %s", DOIP_ON);
  Serial.println(buff);
  snprintf(buff, sizeof(buff), "DOIP_OFF:        %s", DOIP_OFF);
  Serial.println(buff);
  Serial.println("============\n");
}

void print_status()
{
  Serial.println("\n------------");
  
  if (digitalRead(RELAY_POWER_ALL) == HIGH) { Serial.println(POWER_ON); }
  else { Serial.println(POWER_OFF); }
  
  if (digitalRead(RELAY_MODE_DOWNLOAD) == HIGH) { Serial.println(MODE_DOWNLOAD_OFF); }
  else { Serial.println(MODE_DOWNLOAD_ON); }

  if (digitalRead(RELAY_RESET_ICAS3) == LOW) { Serial.println(RESET_ICAS3_SHORT); }

  if (digitalRead(RELAY_KL_15) == HIGH) { Serial.println(KL15_ON); }
  else { Serial.println(KL15_OFF); }

  if (digitalRead(RELAY_AB_CAN_HIGH) == HIGH) { Serial.println(AB_CAN_ON); }
  else { Serial.println(AB_CAN_OFF); }

  if (digitalRead(RELAY_AB_CAN_LOW) == HIGH) { Serial.println(AB_CAN_ON); }
  else { Serial.println(AB_CAN_OFF); }

  if (digitalRead(RELAY_MIB_CAN) == HIGH) { Serial.println(MIB_CAN_ON); }
  else { Serial.println(MIB_CAN_OFF); }

  if (digitalRead(RELAY_DOIP) == HIGH) { Serial.println(DOIP_ON); }
  else { Serial.println(DOIP_OFF); }

  Serial.println("\n============");
}

Commands get_command(String s_cmd)
{
  Commands ret = ENUM_ERROR;

  if (s_cmd == EMPTY) {
    ret = ENUM_EMPTY;
  }
  else if (s_cmd == HELP || s_cmd == HELP_SHORT) {
    ret = ENUM_HELP;
  }
  else if (s_cmd == GET_STATUS) {
    ret = ENUM_GET_STATUS;
  }
  else if (s_cmd == POWER_ON || s_cmd == POWER_ON_CANOE) {
    ret = ENUM_POWER_ON;
  }
  else if (s_cmd == POWER_OFF || s_cmd == POWER_OFF_CANOE) {
    ret = ENUM_POWER_OFF;
  }
  else if (s_cmd == MODE_DOWNLOAD || s_cmd == MODE_DOWNLOAD_ON) {
    ret = ENUM_MODE_DOWNLOAD;
  }
  else if (s_cmd == MODE_NORMAL || s_cmd == MODE_NORMAL_SHORT || s_cmd == MODE_DOWNLOAD_OFF) {
    ret = ENUM_MODE_NORMAL;
  }
  else if (s_cmd == RESET_ICAS3 || s_cmd == RESET_ICAS3_SHORT) {
    ret = ENUM_ICAS3_RESET;
  }
  else if (s_cmd == KL15_ON) {
    ret = ENUM_KL15_ON;
  }
  else if (s_cmd == KLS_ON) {
    ret = ENUM_KLS_ON;
  }
  else if (s_cmd == KL15_OFF) {
    ret = ENUM_KL15_OFF;
  }
  else if (s_cmd == KL15_OFF) {
    ret = ENUM_KL15_OFF;
  }
  else if (s_cmd == AB_CAN_ON) {
    ret = ENUM_AB_CAN_ON;
  }
  else if (s_cmd == AB_CAN_OFF) {
    ret = ENUM_AB_CAN_OFF;
  }
  else if (s_cmd == MIB_CAN_ON) {
    ret = ENUM_MIB_CAN_ON;
  }
  else if (s_cmd == MIB_CAN_OFF) {
    ret = ENUM_MIB_CAN_OFF;
  }
  else if (s_cmd == DOIP_ON) {
    ret = ENUM_DOIP_ON;
  }
  else if (s_cmd == DOIP_OFF) {
    ret = ENUM_DOIP_OFF;
  }
  return ret;
}

void loop() {
  char c;

  if (Serial.available() > 0) {
    c = Serial.read();
    Serial.print(c);
    if (c == '\r') {
      Serial.print("\n");
    }

//    char buff[50];
//    snprintf(buff, sizeof(buff), "'%x' ",c);
//    Serial.print(buff);
    
    if (c == '\n' || c == '\r') {
      switch (get_command(s)) {
        case ENUM_EMPTY:
          break;
        case ENUM_HELP:
          print_help();
          break;
        case ENUM_GET_STATUS:
          print_status();
          break;
        case ENUM_POWER_ON:
          digitalWrite(RELAY_POWER_ALL, HIGH);
          break;
        case ENUM_POWER_OFF:
          digitalWrite(RELAY_POWER_ALL, LOW);
          break;
        case ENUM_ICAS3_RESET:
          digitalWrite(RELAY_RESET_ICAS3, LOW);
          delay(200); // 200ms delay
          digitalWrite(RELAY_RESET_ICAS3, HIGH);
          break;
        case ENUM_MODE_DOWNLOAD:
          digitalWrite(RELAY_MODE_DOWNLOAD, LOW);
          break;
        case ENUM_MODE_NORMAL:
          digitalWrite(RELAY_MODE_DOWNLOAD, HIGH);
          break;
        case ENUM_KL15_ON:
          digitalWrite(RELAY_KL_15, HIGH);
          break;
        case ENUM_KL15_OFF:
          digitalWrite(RELAY_KL_15, LOW);
          break;
        case ENUM_AB_CAN_ON:
          digitalWrite(RELAY_AB_CAN_HIGH, HIGH);
          digitalWrite(RELAY_AB_CAN_LOW, HIGH);
          break;
        case ENUM_AB_CAN_OFF:
          digitalWrite(RELAY_AB_CAN_HIGH, LOW);
          digitalWrite(RELAY_AB_CAN_HIGH, LOW);
          break;
        case ENUM_MIB_CAN_ON:
          digitalWrite(RELAY_MIB_CAN, HIGH);
          break;
        case ENUM_MIB_CAN_OFF:
          digitalWrite(RELAY_MIB_CAN, LOW);
          break;
        case ENUM_DOIP_ON:
          digitalWrite(RELAY_DOIP, HIGH);
          break;
        case ENUM_DOIP_OFF:
          digitalWrite(RELAY_DOIP, LOW);
          break;
        default:
          Serial.println("Unexpected Command");
          break;
      }
      s = "";
    }
    else {
      s += c;
    }
  }
}
