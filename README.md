
# P2P Chat Application in C#

## Project Overview

This is a simple Peer-to-Peer (P2P) chat application written in C# that allows two users to communicate directly over a network without the need for external servers. The app enables each user to act as both a client and server, exchanging messages using sockets over TCP/IP.

## Features
- **Direct Peer-to-Peer Communication**: No external servers required.
- **Input-based IP and Port Selection**: Users can specify the IP address and port for both server and client connections.
- **Multithreaded Messaging**: Simultaneous message sending and receiving, powered by multithreading.

## Requirements

- .NET 6 SDK or later
- Compatible with Windows, Linux, or macOS

## Installation and Setup

1. **Clone the repository**:
   ```bash
   git clone https://github.com/Didilusse/P2PChat.git
   ```
2. **Navigate to the project directory**:
   ```bash
   cd p2p-chat-app
   ```
3. **Compile the project**:
   If you're using the command line:
   ```bash
   csc P2PServer.cs P2PClient.cs Program.cs
   ```

   Alternatively, if you are using Visual Studio or another C# IDE, open the solution and build the project.

## Usage

1. **Run the application**:
   Once compiled, run the resulting executable or use the IDE to launch the app.
   
2. **Choose whether to be a server or a client**:
   - **Server**: Enter "S" to start as the server.
   - **Client**: Enter "C" to start as a client.

3. **Input the IP address and port**:
   - For the server, input the IP address and port where you want to listen for incoming connections.
   - For the client, input the IP address and port of the server to connect to.

4. **Send and Receive Messages**:
   Once connected, the client and server can send messages to each other in real-time.

## Example

- Server:
   ```
   Start as (S)erver or (C)lient?
   S
   Enter IP Address:
   127.0.0.1
   Enter Port Number:
   8888
   Listening for connections on 127.0.0.1:8888...
   Connection established!
   ```

- Client:
   ```
   Start as (S)erver or (C)lient?
   C
   Enter IP Address:
   127.0.0.1
   Enter Port Number:
   8888
   Connected to the server at 127.0.0.1:8888!
   ```

5. **Exchanging Messages**:
   Once the connection is established, both sides can type and send messages that will appear in the console.

## License

This project is licensed under the MIT License. See the `LICENSE` file for more details.
