import * as signalR from "@microsoft/signalr";

// Create the SignalR connection
const connection = new signalR.HubConnectionBuilder()
    .withUrl("/notificationsHub") // Match the hub route on your server
    .build();

// Set up event listener
connection.on("ReceiveNotification", (message) => {
    console.log("Notification:", message);
});

// Start the connection
connection.start()
    .then(() => {
        console.log("Connected to NotificationsHub");
        connection.invoke("TestWebSocketEcho") // Call the hub method
            .catch(err => console.error("Error invoking method:", err));
    })
    .catch(err => console.error("Error connecting:", err));
