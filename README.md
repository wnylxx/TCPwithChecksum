# TCP Communication Protocol with Checksum

## Overview

This project implements a custom TCP communication protocol designed to ensure data integrity and facilitate real-time communication between a client and server. The protocol structure consists of the following components:

- **Length**: The total length of the packet (required)
- **Checksum**: A checksum for data integrity verification (required)
- **CommandCode**: A code that identifies the command to be executed (required)
- **Data**: The data associated with the command (required)
- **EndByte**: A byte that marks the end of the packet (optional)

## Architecture

### Server-Side Implementation

The server is responsible for handling commands and data received from the client, performing necessary actions, and sending responses back to the client. 

The server should:
1. Accept incoming TCP connections.
2. Parse the received packet according to the defined structure: `Length + Checksum + CommandCode + Data + EndByte`.
3. Execute commands based on the `CommandCode` and modify data as needed.
4. Send the updated values back to the client, ensuring the server holds the actual data and is the authority over it.

### Client-Side Implementation

The client is responsible for sending commands and receiving responses from the server. It will be developed using C# with a WinForms interface to allow for easy drag-and-drop component creation from the toolbox.

- The client will send packets to the server, where the server will update values and send back updated data.
- The client will display updated values and status after receiving a response from the server.

## Issues to Address

1. **Server Data Handling**: Currently, the client holds the values and sends commands to the server. However, the server needs to maintain the actual data and send updated values back to the client, ensuring the server acts as the authority for all data.
   
2. **Packet Sending**: The server currently does not send the updated values back to the client. This needs to be implemented to ensure two-way communication, where the server responds with the updated state or data.

## Next Steps

1. **Server-Side Development**:
   - Implement the functionality to receive and parse the packets from the client.
   - Modify server logic to hold and update data as required.
   - Ensure that the server sends updated data back to the client.

2. **Client-Side Development**:
   - Create the WinForms interface to interact with the user.
   - Set up TCP client communication to send commands to the server and display server responses.

## Conclusion

This project will implement a robust, custom TCP communication protocol with a focus on data integrity using checksums and providing a simple client-server communication mechanism.
