Algoritmo Operaciones
	Escribir "===OPCIONES MATEMATICAS==="
	Escribir "1. = SUMA"
	Escribir "2. = RESTA"
	Escribir "3. = MULTIPLICAR"
	Escribir "4. = DIVIDIR"
	Definir num1, num2, opc Como Entero
	Escribir "Ingresa un numero: "
	leer num1
	Escribir "Ingresa otro numero: "
	leer num2
	Escribir "Ingresa una opcion del 1 al 4"
	leer opc
	Segun opc Hacer
		1:
			opc=num1+num2
			Escribir "SUMA = Resultado es de: ", opc
		2:
			opc=num1-num2
			Escribir "RESTA = Resultado es de: ", opc
		3:
			opc=num1*num2
			Escribir "MULTIPLICAR = Resultado es de: ", opc
		4: 
			opc=num1/num2
			Escribir "DIVIDIR = Resultado es de:  ", opc
		De Otro Modo:
			Escribir "OPCION INCORRECTA DIGITE UNA CORRECTAAA"
	Fin Segun
FinAlgoritmo