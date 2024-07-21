# Desafio: Menor Distância entre Arrays

Este projeto em C# resolve o desafio "Menor Distância entre Arrays" proposto pela empresa Intelitrade. O objetivo é encontrar a menor distância entre os elementos de dois arrays de inteiros.

## Descrição do Problema

Dado dois arrays de inteiros, o desafio é encontrar a menor distância absoluta entre qualquer elemento de um array e qualquer elemento do outro array. A distância é calculada como a diferença absoluta entre dois números.

## Resolução

A solução para o desafio envolve as seguintes etapas:

1. **Ordenação dos Arrays**:
   - Utiliza-se o algoritmo de ordenação **Insertion Sort** para ordenar ambos os arrays. Este algoritmo é eficiente para arrays pequenos e simples, facilitando a ordenação.

2. **Comparação dos Arrays**:
   - Após a ordenação, os arrays são comparados para encontrar a menor distância entre os elementos. A comparação é feita de forma a garantir que a menor distância possível entre qualquer par de elementos de diferentes arrays seja encontrada.

