# Binary_Converter-API

Simples API desenvolvida em **C#** usando o modelo **Minimal API** do **ASP.NET**. A API permite **converter texto para sua representação binária** e **converter sequências binárias de volta para texto**.

## Como Executar
Certifique-se de ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado em sua máquina.

- Clone ou faça o download deste repositório.

- Navegue até o diretório raiz do projeto no terminal.

- Execute o comando `dotnet run` para iniciar o servidor.

- O servidor será iniciado e estará pronto para receber solicitações.

## Rotas
- `GET` /api/**text-to-binary**/{**Texto a ser convertido para binário**}

- `GET` /api/**binary-to-text**/{**Binário a ser convertido para texto**}

## Ferramentas e Tecnologias usadas
- .NET 7.0.202
- Visual Studio
- ASP.NET Minimal APIs
- Swagger
