# DIO - Trilha .NET - Programação orientada a objetos

www.dio.me

### Desafio de projeto da trilha .NET da DIO.

## Contexto

Foi feito um sistema que trabalha com celulares, usando abstração de um celular e disponibilizado diferentes marcas e modelos para que tivessem seu próprio comportamento, promovendo assim um maior reuso de código e adotando a orientação a objetos.

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações

1. A classe **Smartphone** deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
2. A classe **Nokia** e **Iphone** devem ser classes filhas de Smartphone.
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.
