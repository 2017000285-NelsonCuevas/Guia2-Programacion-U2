Algoritmo Calculadora
    Definir grados, radianes, resultado Como Real
    Definir opc Como Entero
    
    Escribir "Ingrese el ?ngulo en grados:"
    Leer grados
    // Convertimos grados a radianes
    radianes=grados * (PI / 180)
    
    Escribir "Elija una opcion:"
	Escribir "LISTA DE FUNCIONES TRIGONOMETRICAS"
    Escribir "1- SENO"
    Escribir "2- COSENO"
    Escribir "3- TANGENTE"
    Leer opc
    
    Segun opc Hacer
        1:
            resultado=Sen(radianes)
            Escribir "El Seno de ", grados, "? es: ", resultado
        2:
            resultado=Cos(radianes)
            Escribir "El Coseno de ", grados, "? es: ", resultado
        3:
            resultado=Tan(radianes)
            Escribir "La Tangente de ", grados, "? es: ", resultado
        De Otro Modo:
            Escribir "OPCION NO VALIDA"
    Fin Segun
FinAlgoritmo