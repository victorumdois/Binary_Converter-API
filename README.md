# Binary_Converter-API

Simples API desenvolvida em **C#** usando o modelo **Minimal API** do **ASP.NET**. A API permite **converter texto para sua representação binária** e **converter sequências binárias de volta para texto**.

## Como Executar
Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado em sua máquina.

- Clone ou faça o download deste repositório.

- Execute o arquivo `Binary_Converter-API.sln` para abrir o projeto no Visual Studio.

- Aperte `CTRL + F5` para iniciar a aplicação.

- O servidor será iniciado e estará pronto para receber solicitações.

## Rotas
- `GET` /api/**text-to-binary**/{**Texto a ser convertido para binário**}

- `GET` /api/**binary-to-text**/{**Binário a ser convertido para texto**}

## Ferramentas e Tecnologias usadas
- .NET 7.0
- Visual Studio
- ASP.NET Minimal APIs
- Swagger
