# <span style="color:blue">Monitoramento de CPU e Envio para APP</span>

Este projeto tem como objetivo monitorar em tempo real o desempenho do hardware de um computador, como o uso de CPU, temperatura e outras métricas, e transmitir essas informações para um dispositivo móvel via WebSocket.

## Atribuições

O desenvolvimento deste projeto de monitoramento de CPU em dotNet envolveu a utilização e colaboração de três IA generativas: **ChatGPT-4**, **Claude**, e **GitHub Copilot**, cada uma contribuindo em diferentes etapas do desenvolvimento.

### **ChatGPT-4**
- **Consultas Técnicas e Soluções de Código**: ChatGPT-4 foi utilizado para fornecer suporte técnico, como ajudar na implementação da comunicação WebSocket em C# e resolver problemas de integração com o `LibreHardwareMonitor`. Além disso, foi útil em esclarecer dúvidas sobre padrões de arquitetura de software.
- **Documentação**: O conteúdo inicial da documentação do projeto foi escrito com a assistência do ChatGPT-4, que ajudou a estruturar e formatar as informações de forma clara e objetiva.
  
### **Claude**
- **Organização de Fluxos de Trabalho**: Claude forneceu insights sobre a organização dos fluxos de trabalho do projeto, sugerindo estratégias de otimização de performance na coleta e transmissão dos dados de hardware.
- **Revisão de Código e Melhorias**: Claude foi útil na revisão do código, propondo melhorias de performance e refatorações, além de colaborar na definição de boas práticas de codificação e manutenção do projeto.

### **GitHub Copilot**
- **Autocompletar e Sugestões de Código**: GitHub Copilot foi uma ferramenta indispensável durante o desenvolvimento, oferecendo sugestões de código em tempo real enquanto se escrevia o backend em C#. Suas sugestões foram especialmente úteis na criação das funções de monitoramento e no manuseio das bibliotecas `LibreHardwareMonitor` e `WebSocketSharp`.
- **Integração com APIs**: GitHub Copilot também forneceu sugestões úteis na integração da API do `LibreHardwareMonitor` com o backend, automatizando grande parte do processo de manipulação dos dados de hardware.

Graças à colaboração dessas três ferramentas de IA generativa, o projeto foi otimizado em termos de tempo, qualidade e eficiência de desenvolvimento.

Elogios criados pelo <span style="color:yellow">ChatGpt</span>
<p style="background-color:yellow;">Atribuições: Este projeto foi realizado com o apoio de ChatGPT-4, Claude, e GitHub Copilot.</p>
<p style="background-color:yellow;">Atribuições: Este projeto foi realizado com o apoio de ChatGPT-4, Claude, e GitHub Copilot.</p>

Elogios criados pelo ChatGpt

## <span style="color:blue">Sumário</span>

- [Funcionalidades](#funcionalidades)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Versões Utilizadas](#versões-utilizadas)
- [Infraestrutura](#infraestrutura)
- [Como Contribuir](#como-contribuir)
- [Licença](#licença)

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

## Licença
Este projeto é distribuído sob a Licença MIT, permitindo o uso, cópia, modificação, fusão, publicação e distribuição do software.
