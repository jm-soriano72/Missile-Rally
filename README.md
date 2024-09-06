# Missile Rally
Este proyecto es un acercamiento a su videojuego predecesor con el mismo nombre, centrándose en el apartado multijugador. Está diseñado para 2 hasta 4 jugadores.
Las tecnologías que utiliza para el apartado multijugador son "NetCode para GameObjects", el sistema de "Lobbys" de Unity y "Unity Relay" para la creación de partidas con jugadores desde distintos puntos.
Implementa una arquitectura Listen Server, en la que el jugador que cree la sala actuará a la vez como cliente y servidor. Este servidor se caracteriza por ser autoritativo, dejando toda la lógica fuera de los clientes para brindarle robustez al juego.
