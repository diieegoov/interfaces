# Práctica de Cardboard

## Descripción
Escena de realidad virtual creada con Unity y Google Cardboard para Android. Incluye un terreno, dos cubos recolectables, una esfera recuperadora y un objeto de la Asset Store.

<img width="692" height="388" alt="download (1)" src="https://github.com/user-attachments/assets/eeeb0fa3-923c-4cc1-af03-be7d1c77a515" />

## Controles
- Mirar hacia abajo para avanzar y levantar la mirada para detenerse.
- Mirar un cubo durante 1,2 segundos, a menos de 3 metros, para recogerlo.
- Mirar la esfera durante 1,2 segundos, a menos de 6 metros, para que los cubos recogidos vuelvan hacia el jugador.
- En el editor, mantener el botón derecho del ratón para orientar la cámara.

## Scripts
- `PracticaVR.cs`: movimiento e interacción con la mirada.
- `Coleccionable.cs`: recogida y desplazamiento de los cubos.
- `Recuperador.cs`: recuperación de los cubos recogidos.

## Recursos utilizados
Paquete de Asset Store: Low poly trees - free nature pack (https://assetstore.unity.com/packages/3d/vegetation/trees/low-poly-trees-free-nature-pack-300824).
