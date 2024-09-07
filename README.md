# <span style="color:blue">Aplicativo de Monitoramento de CPU</span>

Este projeto tem como objetivo monitorar em tempo real o desempenho do hardware de um computador, como o uso de CPU, temperatura e outras métricas, e transmitir essas informações para um dispositivo móvel via WebSocket.

## <span style="color:blue">Sumário</span>

- [Funcionalidades](#funcionalidades)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Versões Utilizadas](#versões-utilizadas)
- [Infraestrutura](#infraestrutura)
- [Como Contribuir](#como-contribuir)
- [Licença](#licença)
- [Informações Úteis](#informações-úteis)

## Funcionalidades

- **Monitoramento de CPU**: O aplicativo coleta dados sobre o uso e a temperatura da CPU em tempo real.
- **Transmissão via WebSocket**: As informações coletadas podem ser enviadas para um dispositivo móvel ou outro servidor via WebSocket.
- **Compatibilidade com múltiplas plataformas**: Suporte para monitoramento em máquinas Windows e Linux.
- **Dashboard em Tempo Real**: Exibição gráfica em tempo real dos dados de desempenho.
- **Log de Atividades**: Gera logs detalhados do desempenho ao longo do tempo, permitindo análises posteriores.

## Tecnologias Utilizadas

- **.NET Core**: Backend responsável pela coleta de dados de hardware e transmissão via WebSocket.
- **LibreHardwareMonitor**: Biblioteca usada para coletar dados de hardware.
- **WebSocketSharp**: Biblioteca usada para o transporte de dados via WebSocket.
- **Flutter**: Utilizado para desenvolver a interface de usuário no aplicativo móvel.

## Versões Utilizadas

[![.NET](https://img.shields.io/badge/.NET-v8.0-blue?logo=dotnet)](https://dotnet.microsoft.com/)  
[![Flutter](https://img.shields.io/badge/Flutter-v3.19.6-blue?logo=flutter)](https://flutter.dev)  
[![Dart](https://img.shields.io/badge/Dart-v3.3.4-blue?logo=dart)](https://dart.dev)

## Infraestrutura

O projeto utiliza `LibreHardwareMonitor` para capturar dados sobre o desempenho do hardware e `WebSocketSharp` para transmitir esses dados para um cliente Flutter via WebSocket.

## Como Contribuir

Estamos abertos a contribuições da comunidade. Se você tiver sugestões, encontrar bugs ou quiser adicionar novas funcionalidades, sinta-se à vontade para abrir uma issue ou enviar um pull request.

wsServer = new WebSocketServer("ws://localhost:4455");
wsServer.Start();
