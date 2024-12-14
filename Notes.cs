//#include <SPI.h>
//#include <Ethernet.h>
//#include <WebSocketsClient.h>

//#define WIFI_SSID "YourWiFiSSID"
//#define WIFI_PASSWORD "YourWiFiPassword"

//#define SIGNALR_HUB_URL "ws://192.168.3.40:5031/notificationsHub"  // Your SignalR WebSocket URL
//"ws://192.168.137.1:5031/notificationsHub"
//WebSocketsClient webSocket;

//void setup()
//{
//    Serial.begin(115200);

//    // Connect to WiFi
//    WiFi.begin(WIFI_SSID, WIFI_PASSWORD);
//    while (WiFi.status() != WL_CONNECTED)
//    {
//        delay(1000);
//        Serial.println("Connecting to WiFi...");
//    }
//    Serial.println("Connected to WiFi!");

//    // WebSocket connection
//    webSocket.begin(SIGNALR_HUB_URL);
//    webSocket.onEvent(webSocketEvent); // Set callback for WebSocket events
//}

//void loop()
//{
//    webSocket.loop();  // Keeps the WebSocket connection alive

//    // Sending a message to the SignalR hub every 5 seconds
//    static unsigned long lastSendTime = 0;
//    if (millis() - lastSendTime >= 5000)
//    {
//        lastSendTime = millis();
//        sendTestWebSocketEcho();
//        sendMessageToHub("Hello from Arduino!");
//    }
//}

//// WebSocket Event handler
//void webSocketEvent(WStype_t type, uint8_t* payload, size_t length)
//{
//    switch (type)
//    {
//        case WStype_DISCONNECTED:
//            Serial.println("Disconnected");
//            break;
//        case WStype_CONNECTED:
//            Serial.println("Connected to WebSocket server");
//            break;
//        case WStype_TEXT:
//            Serial.printf("Message from server: %s\n", payload);
//            break;
//        case WStype_PONG:
//            // Handle pong response if necessary
//            break;
//    }
//}

//// Send request to invoke the 'TestWebSocketEcho' method on the SignalR server
//void sendTestWebSocketEcho()
//{
//    String msg = "{\"method\": \"TestWebSocketEcho\"}";  // Method name as JSON
//    webSocket.sendTXT(msg);  // Send method call to SignalR
//    Serial.println("Sent request to TestWebSocketEcho.");
//}

//// Send message to SignalR server
//void sendMessageToHub(String message)
//{
//    String msg = "{\"method\": \"SendMessage\", \"message\": \"" + message + "\"}";  // Method and parameters
//    webSocket.sendTXT(msg);  // Send method call to SignalR
//    Serial.println("Sent message to SendMessage: " + message);
//}
