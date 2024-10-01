# Estágio - Target
- Neste repositório se encontra a solução com os projetos solicitados no teste técnico, bem como, as respostas para as perguntas do teste.

## Questão 1
	• 1) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma 
 	dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na 
  	linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne 
   	uma mensagem avisando se o número informado pertence ou não a sequência.

	• IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou 
 	pode ser previamente definido no código;
***Solução:***

	• A resolução para essa questão se encontra no projeto Fibonacci. 
 	• Optei por utilizar o calculo através de função recursiva, pela simplicidade da implementação.
	• Foram feitos testes unitários com diversos cenários para dar confiabilidade a lógica implementada.

## Questão 2
	• 2) Escreva um programa que verifique, em uma string, a existência da letra ‘a’, seja maiúscula 
 	ou minúscula, além de informar a quantidade de vezes em que ela ocorre.

	• IMPORTANTE: Essa string pode ser informada através de qualquer entrada de sua preferência ou 
 	pode ser previamente definida no código;
***Solução:***

	• A resolução para essa questão se encontra no projeto ContadorDeLetras. 
 	• Optei por utilizar Regex pela simples implementação e excelente desempenho.
	• Foram feitos testes unitários com diversos cenários para dar confiabilidade a lógica implementada.

## Questão 3
	• 3) Observe o trecho de código abaixo: 
		int INDICE = 12, SOMA = 0, K = 1; 
		enquanto K < INDICE faça 
		{ 
		    K = K + 1; 
		    SOMA = SOMA + K; 
		} 
		imprimir(SOMA);

	• Ao final do processamento, qual será o valor da variável SOMA?
***Solução:***
	
	• Realizando um total de 11 execuções e fazendo a seguinte soma: 
 		(2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10 + 11 + 12) 
	• Ao final do processamento o valor da variável SOMA será: 77

## Questão 4
	• 4) Descubra a lógica e complete o próximo elemento:
		a) 1, 3, 5, 7, ___
		b) 2, 4, 8, 16, 32, 64, ____
		c) 0, 1, 4, 9, 16, 25, 36, ____
		d) 4, 16, 36, 64, ____
		e) 1, 1, 2, 3, 5, 8, ____
		f) 2,10, 12, 16, 17, 18, 19, ____
***Solução:***
	
		a) 1, 3, 5, 7, 9. (Numeros ímpares)
		b) 2, 4, 8, 16, 32, 64, 128. (2 elevado a n)
		c) 0, 1, 4, 9, 16, 25, 36, 49. (n²)
		d) 4, 16, 36, 64, 100. (numero par elevado ao quadrado)
		e) 1, 1, 2, 3, 5, 8, 13. (Sequencia de Fibonacci)
		f) 2,10, 12, 16, 17, 18, 19, ____ (Não consegui descobrir a lógica.)

## Questão 5
	• 5) Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em salas 
 	diferentes. Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os 
  	interruptores quantas vezes quiser. Seu objetivo é descobrir qual interruptor controla qual 
   	lâmpada. Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, 
    	qual interruptor controla cada lâmpada?  
***Solução:***
	
	• Ligue o interruptor 1 e deixe-o ligado por um tempo

	• Após esse tempo, desligue o Interruptor 1 e ligue o Interruptor 2.

	• Vá até uma das salas.

	• Caso a sala estiver com a lâmpada acessa, está ligada ao Interruptor 2.
	• Caso a sala estiver com a lâmpada apagada e fria, está ligada ao Interruptor 3.
	• Caso a sala estiver com a lâmpada apagada e quente, está ligada ao Interruptor 1.

	• Vá até outra sala.

	• Veja qual é o caso da lâmpada em questão, seguindo as regras da primeira sala.

	• Com isso, a última sala pode ser deduzida com a alternativa restante.
		
