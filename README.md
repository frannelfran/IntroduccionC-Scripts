# IntroduccionC-Scripts
Ejercicios relacionados con la **segunda práctica** de Interfaces Inteligentes 👨🏻‍💻

1. Crea un script asociado a un objeto en la escena que inicialice un vector de 3 posiciones con valores entre 0.0 y 1.0, para tomarlo como un vector de color (Color). Cada 120 frames se debe cambiar el valor de una posición aleatoria y asignar el nuevo color al objeto. Parametrizar la cantidad de frames de espera para poderlo cambiar desde el inspector.

https://github.com/user-attachments/assets/f84d09e4-162b-4c96-8e67-e5d2ac3dc65a

**Script relacionado** -> [randomColor.cs](./scripts/randomColor.cs)

2. Crea un script asociado a la esfera con dos variables Vector3 públicas. Dale valor a cada componente de los vectores desde el inspector. Muestra en la consola:

- **Magnitud de cada vector:** Muestra la magnitud de ambos vectores.
- **Ángulo entre los vectores:** Calcula y muestra el ángulo que forman.
- **Distancia entre los vectores:** Indica la distancia entre ambos.
- **Comparación de altura:** Muestra un mensaje indicando cuál de los dos vectores tiene una componente Y (altura) mayor.

https://github.com/user-attachments/assets/25b1e7b5-2733-4473-bb53-646211cfab31

**Script relacionado** -> [vector3.cs](./scripts/vector3.cs)

3. Muestra en pantalla el vector con la posición de la esfera.

https://github.com/user-attachments/assets/634ebe29-ed5c-4ef5-8c6d-6c95eed820c1

**Script relacionado** -> [posicionEsfera.cs](./scripts/posicionEsfera.cs)

4. Crea un script para la esfera que muestre en consola la distancia a la que están el cubo y el cilindro.

![Distancia](./images/distanciaCuboCilindro.png)

**Script relacionado** -> [distanciaCuboCilindro.cs](./scripts/distanciaCuboCilidro.cs)

5. Selecciona tres posiciones en tu escena a través de un objeto invisible (marcador) que incluya 3 vectores numéricos para configurar posiciones en las que quieres ubicar los objetos en respuesta a pulsar la barra espaciadora. Estos vectores representan un desplazamiento respecto a la posición original de cada objeto. Crea un script que ubique en las posiciones configuradas cuando el usuario pulse la barra espaciadora.

https://github.com/user-attachments/assets/f372c8d3-dcc2-4d11-8935-719c86b4813a

**Script relacionado** -> [moverAPosicion.cs](./scripts/moverAPosicion.cs)

