Algoritmo ClasificadorCaracteres
    Definir car Como Caracter
    
    Escribir "Ingrese un caracter (letra o numero):"
    Leer car
    
    car=Mayusculas(car)
    
    Segun car Hacer
        "A", "E", "I", "O", "U":
            Escribir "El caracter es una VOCAL"
        "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10":
            Escribir "El caracter es un DIGITO"
        De Otro Modo:
            Escribir "El caracter no es ni vocal ni digito"
			Escribir "INGRESE UNO VALIDO"
    Fin Segun
FinAlgoritmo