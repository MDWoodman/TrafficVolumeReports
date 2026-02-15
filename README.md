# Traffic volume reports

## Introduction
You are working at a company that collects traffic data.
Additionally, the company designs and manufactures sensors.
A sensor can be located anywhere on earth.
Sensors are specialized in collecting information about the movement of specific types of objects, for example, there are sensors responsible for detecting passing cars, bicycles, motorbikes, people, etc.
During its first start, each sensor registers sending information in the system about its unique ID, specialization and GPS location.
While working, each sensor sends data to the server about its ID, number of detected objects and the contact time with a moving object (the objects it is specialized for).
This data is used for generating custom reports for the company’s clients.

## Problem Statement
Due to a large number of sensors and the amount of data, the company decided to implement an API that will be able to collect all data and generate reports based on it.
In addition, the selected technology should allow for appropriate scaling, including the ability to run on multiple servers.
The company picked microservices.

They created appropriate subprojects that contain implementations of the relevant functionalities:
1. `TrafficSensors.Service.SensorsApi` - functionalities related to the sensors. The API is available as a RESTful web service.
2. `TrafficSensors.Service.DataApi` - functionalities related to the data from the sensors. The API is available as a RESTful web service.
3. `TrafficSensors.Service.ReportsApi` - functionalities related to the reports. The API is available as a RESTful web service.
4. `TrafficSensors.Bus.BusApi` - provides interfaces that allow for communication between services (**description of the `BusApi` can be found in the further part of the requirements**).
5. `TrafficSensors.Bus.Model` - the model used by the `BusApi`.
6. `TrafficSensors.DB.SensorsDb` - the Database API. The database stores information about the sensors (registered sensors).
7. `TrafficSensors.DB.DataDb` - the Database API. The database stores information about the data detected by the sensors.
Each service operates on its own local databases.
8. `TrafficSensors.Sensor.Type` - common types for sensors.

`BusApi` - data bus:	
- Provides the interface that allows for communication between services (it can use different technologies, e.g. MQ queues).
- The `Subscribe(string serviceGuid, SubscribeEventType type)` method allows you for registering a service and for subscribing to a specific type of information. Registration is ignored if an active subscription for the service already exists.
- The `Put(string serviceGuid, BaseData data)` method allows you for notifying other services and for sending data. You can send the `SensorData` or the `SensorRegistration` data that inherit from the `BaseData`.
- The `Read(string serviceGuid, SubscribeEventType type)` method allows you for taking all the data that has not been yet taken by the service that subscribes the data. All read data is removed from the bus queue.
	You can read the `SensorData` or the `SensorRegistration` data that inherit from the `BaseData`.
		
Additional implementation connected with `ReportsApi`, `SensorsApi` and `DataApi` services:
- A service instance is created per web request and per `ProcessJob` action call.
- The `ProcessJob` is called periodically (approximately every minute).
- All dependencies are injected when an instance is created.
- It should be possible to run the service on many servers/containers. Each instance will have its own local database.		

**To complete this task you have to implement the requirements described below:**
- Add a functionality in the correct place in the `ReportsApi` that starts subscribing data connected with sensors registration and sensors data .
	- Unique ID for current instance of service can be taken from the **appsettings.json** (the `ServiceGuid` option).
- Add a functionality in the correct place in the `ReportsApi` that reads subscribed data and saves it into proper local databases:
	- During reading, the subscribed data uses the `TrafficSensors.Bus.Model.SensorRegistration` and the `TrafficSensors.Bus.Model.SensorData`.
	- Information about sensors registration should be saved to the `TrafficSensors.DB.SensorsDb` (the `Sensors` table);
	- The data from the sensors should be saved to the `TrafficSensors.DB.DataDb` (the `DetectedData` table).		

## Hints
1. Your solution should pass all tests.
2. **To run all tests, you may need to run Visual Studio with administrator privileges.**
