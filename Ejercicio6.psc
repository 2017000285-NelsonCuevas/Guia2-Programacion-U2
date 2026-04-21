Algoritmo Estadio
	Escribir "===ESTADIO DOROTEO GUAMUCH FLORES==="
	Escribir "1 = Palco: Q300.00"
	Escribir "2 = Tribuna: Q100.00 - Q125.00"
    Escribir "3 = Preferencia: Q50.00 - Q75.00"
    Escribir "4 = Generales: Q30.00 - Q50.00" 
	Definir sector, entradas Como Entero
	Definir total Como Real
	Escribir "Escribe en que sector deseas ver el partido: "
	Leer sector
	Escribir "Cuantas entradas quieres para ver el partido: "
	Leer entradas
	Segun sector Hacer
		1:
			total =  300 * entradas
			Escribir "Total para Palco seria: Q.", total
		2:
			total = 125 * entradas
			Escribir "Total para Tribuna seria: Q.", total
		3:
			total = 75 * entradas
			Escribir "Total para Preferencia seria: Q.", total
		4:
			total = 50 * entradas
			Escribir "Total para General seria: Q.", total
		De Otro Modo:
			Escribir "ERROR, Escriba un sector valido"
	Fin Segun
FinAlgoritmo