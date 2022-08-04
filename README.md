# LNet
Estas são as bibliotecas de servidor e cliente para jogos multijogador e programação de rede.

## Uso
Para usá-lo, primeiro você cria um aplicativo que configura um servidor. Isso é feito no construtor, e iniciando o servidor usando uma das classes que implementa a interface IServer com a função Start():

```
//server = new TCPServer(doLoopBack, portNumber); //Use this if you want the program to find an IP Address or use the default local IP Address
server = new TCPServer(ipAddressString, portNumber);
server.Start();
```

Então, em uma aplicação para o cliente, você configura uma classe com uma interface IClient, então chama a função Connect, passando um IP/Host Address, Port Number e uma mensagem para indicar o client se conectando ao servidor (o padrão é "Client conectou").

```
client.Connect("127.0.0.1", 123, "User has joined the chat");
```
Supondo que o servidor esteja em execução e os clientes estejam conectados a ele com sucesso, os clientes devem poder enviar mensagens entre si. Isso é feito configurando um objeto AMessage com dados na forma de uma string. Você pode configurar esta mensagem para ser enviada a todos os clientes, quaisquer clientes exceto um ou apenas um cliente definindo o tipo de mensagem.

```