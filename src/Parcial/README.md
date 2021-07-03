**Parcial Brian Sosa**

El patrón utilizado es el *Strategy*

Básicamente lo elégi porque hay que cambiar el comportamiento de un componente dependiendo un tipo.

La elección de este tipo sería la estrategia por el cuál se debe comprimir el archivo.

Al usar este patrón tenemos la ventaja que el componente siempre podría ser el mismo y lo único que tenemos que hacer para crear nuevos compresores son las estrategias. Por lo cuál abstraemos primero la lógica al Cliente que solo conoce el Método **Comprimir** del componente, y luego al mismo componente con las "estrategias".

Utilizando este patrón no generamos un acoplamiento entre el componente y las estragias al mismo tiempo que lo hacemos extensible.

Info extra parcial:

Si se quiere, se puede correr el código usando docker utilizando los comandos:
- docker build -t builder-image -f Dockerfile .
- docker run --rm builder-image

**El diagrama se encuentra en la carpeta *doc***
