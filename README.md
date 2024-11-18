# Aplicando testes

Nesse documento vou mostrar a implementação de três tipos de testes usando .NET, sendo eles Testes de Unidade, Testes com Mocks e Testes de Validação com SpecFlow. 

---

## Teste de Unidade


Conversão de temperatura de Fahrenheit para Celsius.

### Cenário

- **Entrada**: `32°F`, **Saída Esperada**: `0°C`
- **Entrada**: `212°F`, **Saída Esperada**: `100°C`

### Execução

Para executar, usar:
```bash
dotnet test UnitTests 
```
￼<img width="728" alt="Captura de Tela 2024-11-18 às 10 40 48" src="https://github.com/user-attachments/assets/ad3f2e6a-cf6b-4df9-9e32-c6a4108f946b">

O teste esta validando a funcionalidade do método FahrenheitParaCelsius, garantindo que ele converte as temperaturas de de forma correta.


## Teste com Mocks
--
Simula interações com dependências externas, como um serviço de consulta de crédito.

### Cenário
- **CPF**: `12345678900`, **Resultado Esperado**: `Aprovado` (retorna `true`).
- **CPF**: `00000000000`, **Resultado Esperado**: `Negado` (retorna `false`).

### Execução
Para executar os testes com mocks, usar o comando:
```bash
dotnet test MockTests
```
￼<img width="528" alt="Captura de Tela 2024-11-18 às 10 41 41" src="https://github.com/user-attachments/assets/8e3ea2eb-1779-4ccd-a51a-b1688466da7e">

Aqui valida a interação do sistema com o serviço de consulta de crédito sem depender de uma implementação real, que estaja em um banco de dados.


## Teste de Validação 
--
Utiliza o SpecFlow para implementar o desenvolvimento guiado por comportamento. Ele traduz histórias de usuário em cenários testáveis, garantindo que as funcionalidades atendam às expectativas do usuário final. 

### Cenário
- **Dado**: Uma temperatura de `32°F`
- **Quando**: A conversão é realizada
- **Então**: O resultado será `0°C`

### Execução
Para executar os testes de validação, use o comando:
```bash
dotnet test SpecFlowTests
```

<img width="1012" alt="Captura de Tela 2024-11-18 às 10 42 45" src="https://github.com/user-attachments/assets/e1a24aa1-dcda-47a3-9832-48a3ccb17e2e">
O SpecFlow foi utilizado para testar a conversão de temperaturas com base nas informações dadas em relação ao usuarioo.
	
---
