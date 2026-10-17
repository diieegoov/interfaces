# Práctica 4: Delegados y Eventos en Unity

## Ejercicio 1. Delegados, eventos y callbacks

Se creó una escena con esferas de dos tipos, un cubo y un cilindro. Al producirse una colisión entre el cubo y el cilindro, se emite un evento al que están suscritas las esferas, provocando distintos movimientos según su grupo.

**Aprendizaje:** creación de eventos, suscripción mediante delegados y ejecución de funciones callback.

![Ejercicio 1](https://github.com/user-attachments/assets/a6db532b-7935-43b4-9247-c429c47f75af)

## Ejercicio 2. Incorporación de humanoides

Se sustituyeron las esferas por modelos 3D de Footman y Lich, conservando las mecánicas de movimiento y comunicación mediante eventos.

**Aprendizaje:** importación de assets, configuración de modelos 3D y reutilización de scripts.

## Ejercicio 3. Interacción entre humanoides y escudos

Se implementaron eventos de colisión entre el jugador y los humanoides. Según el grupo con el que colisiona, los personajes se desplazan hacia distintos escudos. También se incorporó el cambio de color al contactar con determinados escudos.

**Aprendizaje:** gestión de colisiones, comunicación entre objetos mediante eventos y modificación de materiales.

![Ejercicios 2 y 3](https://github.com/user-attachments/assets/0822d7ae-38c9-4d12-bfe8-205f4b5893c3)

## Ejercicio 4. Teletransporte y orientación

Se implementó la detección de proximidad para activar un evento que teletransporta a los humanoides del grupo 1 hacia un escudo y orienta a los del grupo 2 hacia un objeto de referencia.

**Aprendizaje:** detección de distancias, teletransporte y rotación de objetos mediante transformaciones.

![Ejercicio 4](https://github.com/user-attachments/assets/ec945053-30f8-4f12-a61f-26d99861974a)

## Ejercicio 5. Sistema de puntuación

Se desarrolló un sistema de recolección de escudos mediante colisiones. Los escudos de tipo 1 suman 5 puntos y los de tipo 2 suman 10, mostrando la puntuación en la consola.

**Aprendizaje:** identificación de objetos mediante etiquetas (`Tags`), detección de colisiones y actualización de variables.

![Ejercicio 5](https://github.com/user-attachments/assets/f195b54d-0475-4de4-bd19-1b2db8a4aac2)

## Ejercicio 6. Interfaz de usuario

Se creó una interfaz con Canvas y TextMeshPro para mostrar la puntuación del jugador y actualizarla durante la partida.

**Aprendizaje:** creación de interfaces UI y conexión entre scripts y elementos visuales.

## Ejercicio 7. Sistema de recompensas

Se amplió el sistema de puntuación para otorgar una recompensa por cada 100 puntos acumulados, mostrando el total de recompensas en la interfaz.

**Aprendizaje:** implementación de condiciones, control de puntuaciones y actualización dinámica de la UI.

![Ejercicio 7](https://github.com/user-attachments/assets/a9bbe024-6be5-43b6-b1bb-c35165716b60)

## Ejercicio 8. Escenario final

Se importó un escenario medieval y modelos 3D, elementos decorativos y las mecánicas desarrolladas en los ejercicios anteriores.

**Aprendizaje:** diseño de escenarios, integración de assets y organización de objetos y componentes en Unity.

## Ejercicio 9. Colisiones con objetos físicos

Se adaptó el ejercicio 3 para que el jugador utilizara un Rigidbody físico, manteniendo las interacciones con los humanoides y los escudos.

**Aprendizaje:** diferencias entre objetos cinemáticos y dinámicos, movimiento mediante Rigidbody y detección de colisiones físicas.

![Ejercicio 8](https://github.com/user-attachments/assets/014a3fda-0171-43d3-9a92-0888d52eb3c3)
