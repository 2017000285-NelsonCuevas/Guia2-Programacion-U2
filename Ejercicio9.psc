Algoritmo EjercicioIVA
	Escribir "EMPRESA T&S, S.A de C.A"
	Definir impresoras, pago Como Entero
	Definir PsinIVA, PconIVA, subtotal, descuento, total Como Real
	Definir nombrepago Como Cadena
	PsinIVA=650
	PconIVA=PsinIVA*1.12
	Escribir "Escriba la cantidad de impresoras que desee comprar: "
	Leer impresoras
	Escribir "Elija la forma de pago:"
	Escribir " 1 - Efectivo (10% descuento)"
	Escribir " 2 - Tarjeta credito (5% descuento)"
	Escribir " 3 - Vale de regalo (15% descuento)"
	Leer pago
	subtotal= PconIVA * impresoras
	Segun pago Hacer
		1:
			descuento = subtotal * 0.10
			nombrepago = "EFECTIVO"
			Escribir "Forma de Pago: EFECTIVO"
	    2:
			descuento = subtotal * 0.05
			nombrepago= "TARJETA DE CREDITO"
			Escribir "Forma de Pago: TARJETA DE CREDITO"
		3:
			descuento = subtotal * 0.15
			nombrepago = "VALE DE REGALO"
			Escribir "Forma de Pago: VALE DE REGALO"
		De Otro Modo:
			nombrepago = "NO VALIDO"
			Escribir "FORMA DE PAGO NO VALIDA!!!"
	Fin Segun
	total=subtotal-descuento
	Escribir "===DETALLES==="
	Escribir "Cantidad de Impresoras compradas: ", impresoras
	Escribir "El precio unitario de la impresora (con IVA): Q.", PconIVA
	Escribir "El total sin descuento: Q.", subtotal
	Escribir "La forma de pago: ", nombrepago
	Escribir "El descuento realizado: Q.", descuento
	Escribir "El total a pagar Considere que todos los descuentos se realizan sobre el precio CON IVA: Q.", total
FinAlgoritmo