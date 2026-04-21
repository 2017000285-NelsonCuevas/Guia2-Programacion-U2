Algoritmo Conversor_Medidas
	Definir opc, resultado Como Real
	Definir medidas Como Entero
	Escribir "===CONVERSOR DE MEDIDAS==="
	Escribir "Escriba un valor: "
	Leer opc
	Escribir "1 = METROS"
	Escribir "2 = PIES"
	Escribir "3 = CENTIMETROS"
	Escribir "4 = PULGADAS"
	Escribir "Elija una medida de conversion: "
	Leer medidas
	Segun medidas Hacer
		1:
			resultado = opc
			Escribir "Metros: ", resultado, " metros"
		2:
			resultado = opc * 3.28084
			Escribir "Metros: ", resultado, " pies"
		3:
			resultado = opc * 100
			Escribir "Metros: ", resultado, " centimetros"
		4:
			resultado = opc * 39.3701
			Escribir "Metros: ", resultado, " pulgadas"
		De Otro Modo:
			Escribir "ERROR, DIGITE UNA CONVERSION CORRECTA"
	Fin Segun
FinAlgoritmo