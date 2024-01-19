# Restraints Control Module

<a href="https://testerpresent.com.au/"><img src="https://img.shields.io/badge/Tester Present -Specialist Automotive Solutions-red" /></a>  
<sup><b>
Part No: 8R29-14B321-BC  
Manufactured: 19/03/2009

    
</b></sup>
<img src="https://github.com/jakka351/RestraintsControlModule/assets/57064943/1d827b03-9315-4bc7-9a2a-b62f2df04c48" height="40%" width="40%" align="center" />

Documenting discovery of diagnostic services and firmware diassembly of a Ford FG Restraints Control Module, including search for event data recorder and crash data recovery processes.


[`FG Falcon Repo`](https://github.com/jakka351/fg-falcon). 
[`PCM Hacking forum thread`](https://pcmhacking.net/forums/viewtopic.php?f=41&t=8425)

***
## Connectors
![image](https://github.com/jakka351/RestraintsControlModule/assets/57064943/37238430-fbb0-481e-849d-f7929ccc0c29)

## Wiring Diagram
![image](https://github.com/jakka351/RestraintsControlModule/assets/57064943/98b192b1-1486-4358-95f1-fae10abbe59a)

## Diagnostics
### Security Access

`Seed Key: DIODE`

Security Access is unlocked with service 0x27 and FEPS. 

### Service 0x21
As Built Data - 6 Blocks of data including an empty spot for VIN.
```
;Block 1
737G1G14080
;Block 2 
737G2G1000000000041
737G2G2000000000042
737G2G3000000000043
737G2G4000044
;Block 3
737G3G1000042
;Block 4
737G4G179F0AC
;Block 5
737G5G1C70B
;Block 6
737G6G198FDDA
```
### Service 0x22
Memory locations `0x5800` to `0x5B58`:
```
PrivateSubNodeIdentifierCode1 = 0x5800;
PrivateSubNodeIdentifierCode2 = 0x5801;
PrivateSubNodeIdentifierCode3 = 0x5802;
PrivateSubNodeIdentifierCode4 = 0x5803;
PrivateSubNodeIdentifierCode5 = 0x5804;
PrivateSubNodeIdentifierCode6 = 0x5805;
PrivateSubNodeIdentifierCode7 = 0x5806;
DriverSeatTrackPositionSwitchStatus = 0x5807;
OccupantClassificationSensorDTCClearedStatus = 0x5808;
OccupantClassificationSystemCalibrationStatus = 0x5809;
OccupantClassificationSystemmeasuredWeightofPassenger = 0x580A;
PassengerAirbagDeactivationLampStatus = 0x580B;
PassengerAirbagEnableLampStatus = 0x580C;
ImpactTriggerOutputStatus = 0x580D;
PassengerRetractorSensorVersionID = 0x580E;
DriverRetractorSensorVersionID = 0x580F;
PCMVehicleIdentification = 0x5810;
RestraintsAdditionalEquipment = 0x5811;
Crashrecord4 = 0x5812;
Crashrecord4B = 0x5813;
Crash1Telegram = 0x5814;
Crash2Telegram = 0x5815;
Crash3Telegram = 0x5816;
EventDataRecord = 0x5817;
EventDataRecord = 0x5818;
ThirdRowCenterSeatbeltSensorCurrent = 0x5819;
RearSeatbeltSensorStatus = 0x581A;
ThirdRowRightSeatbeltSensorCurrent = 0x581B;
ThirdRowLeftSeatbeltSensorCurrent = 0x581C;
VehicleSpeedandQualityFactor = 0x581D;
ExternalAmbientTemperature = 0x581E;
RestraintsEventNotificationStatus = 0x5820;
EmergencyCallRetrievableData = 0x5821;
PassengerSeatIDNumber = 0x5B00;
VoltageAutarchyCapacitor = 0x5B02;
DeploymentControl0Resistance = 0x5B03;
DeploymentControl1Resistance = 0x5B04;
DeploymentControl2Resistance = 0x5B05;
DeploymentControl3Resistance = 0x5B06;
DeploymentControl4Resistance = 0x5B07;
DeploymentControl5Resistance = 0x5B08;
DeploymentControl6Resistance = 0x5B09;
DeploymentControl7Resistance = 0x5B0A;
DeploymentControl8Resistance = 0x5B0B;
DeploymentControl9Resistance = 0x5B0C;
DeploymentControl10Resistance = 0x5B0D;
DeploymentControl11Resistance = 0x5B0E;
DeploymentControl12Resistance = 0x5B0F;
DeploymentControl13Resistance = 0x5B10;
AccelerometerValue0 = 0x5B11;
AccelerometerValue1 = 0x5B12;
PassengerAirbagEnable = 0x5B13;
SystemTime = 0x5B14;
StoredSystemTime = 0x5B15;
CrashStatus = 0x5B17;
ModuleStatus = 0x5B18;
DriverSeatbeltSensorStatus = 0x5B19;
PassengerSeatbeltSensorStatus = 0x5B1A;
RestraintSystemPassengerDisableIndicator = 0x5B1B;
RestraintSystemMalfunctionIndicator = 0x5B1C;
DoorStatus = 0x5B1D;
Crash1Telegram = 0x5B1F;
Crash2Telegram = 0x5B20;
Crash3Telegram = 0x5B21;
CrashRecord1 = 0x5B22;
CrashRecord2 = 0x5B23;
CrashRecord3 = 0x5B24;
OccupantClassificationSensorStatus = 0x5B25;
ModuleDeliveryMode = 0x5B26;
SeatTrackSensor = 0x5B27;
PassengerAirbagCut = 0x5B28;
PassengerRestraintDeviceStatus = 0x5B29;
DoorSlamProtection = 0x5B2A;
DriverSeatTrackPositionRestraintsSensor = 0x5B2B;
PassengerSeatTrackPositionRestraintsSensor = 0x5B2C;
PassengerRestraintDisableSwitchSensorA = 0x5B2D;
PassengerRestraintDisableSwitchSensorB = 0x5B2E;
DriverSeatbeltSensorCurrent = 0x5B2F;
PassengerSeatbeltSensorCurrent = 0x5B30;
SecondRowLeftSeatbeltSensorCurrent = 0x5B31;
SecondRowCenterSeatbeltSensorCurrent = 0x5B32;
SecondRowRightSeatbeltSensorCurrent = 0x5B33;
DeploymentControl14Resistance = 0x5B34;
DeploymentControl15Resistance = 0x5B35;
DeploymentControl16Resistance = 0x5B36;
DeploymentControl17Resistance = 0x5B37;
DeploymentControl18Resistance = 0x5B38;
DeploymentControl19Resistance = 0x5B39;
DeploymentControl20Resistance = 0x5B3A;
DeploymentControl21Resistance = 0x5B3B;
DeploymentControl22Resistance = 0x5B3C;
DeploymentControl23Resistance = 0x5B3D;
DeploymentControl24Resistance = 0x5B3E;
DeploymentControl25Resistance = 0x5B3F;
DeploymentControl26Resistance = 0x5B40;
DeploymentControl27Resistance = 0x5B41;
DeploymentControl28Resistance = 0x5B42;
DeploymentControl29Resistance = 0x5B43;
DeploymentControl30Resistance = 0x5B44;
ImpactStatusFlag = 0x5B45;
SecondRowLeftSeatbeltSensorStatus = 0x5B46;
SecondRowCenterSeatbeltSensorStatus = 0x5B47;
SecondRowRightSeatbeltSensorStatus = 0x5B48;
Selfconfigurationmode = 0x5B49;
Equipmentconfiguration = 0x5B4A;
OccupantWeightSensorID = 0x5B4B;
OccupantWeightSensorStatusMessage = 0x5B4C;
Crash1Telegram = 0x5B4D;
Crash2Telegram = 0x5B4E;
Crash3Telegram = 0x5B4F;
Crashrecord1B = 0x5B50;
Crashrecord2B = 0x5B51;
Crashrecord3B = 0x5B52;
Crashcounter = 0x5B53;
CrashStatus = 0x5B54;
Equipmentconfiguration = 0x5B55;
FuelCutoffRequestStatus = 0x5B56;
OccupantClassificationPressureSensor = 0x5B57;
PassengerSeatbeltSensor = 0x5B58;
```
### Service 0x23
DMRs Direct Memory Read by Address:
### Read Flash
### Write Flash

***
## Owners Manual
![image](https://raw.githubusercontent.com/jakka351/RCM/main/Data/Screenshot_20230727-121937.png)
