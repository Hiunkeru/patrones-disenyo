## Patrón Prototype (Patrón de construcción)

El objetivo de  este patrón  es la  creación de nuevos objetos mediante duplicación de objetos  existentes llamados prototipos que disponen de la capacidad de clonación.

### Casos de uso
	- Un sistema de objetos debe crear instancias sin conocer la jerarquía de clases que las describe
	- Un sistema de objetos debe crear instancias de clases dinámicamente
	- El sistema de objetos debe permanecer simple y no incluir una jerarquía paralela de clases de fabricación.

### Patrón de contrucción
	- Los patrones de construcción tienen la vocación de abstraer los mecanismos de creación de objetos. Un sistema que utilice  estos  patrones  se  vuelve  independiente  de  la  forma  en  que  se  crean  los  objetos,  en  particular,  de  los mecanismos de instanciación de las clases concretas.

### Ventajas
	- No desea modificar el objeto existente y experimentar con eso.
	- Puede incluir o descartar productos en tiempo de ejecución.
	- En algunos contextos, puede crear nuevas instancias a un costo menor.
	- Puede centrarse en las actividades clave en lugar de centrarse en procesos complicados de creación de instancias. Por ejemplo, una vez que ignora los complejos procesos de creación de objetos, puede simplemente comenzar con la clonación o copia de objetos e implementar las partes restantes.
	- Desea tener una idea del comportamiento del nuevo objeto antes de implementarlo por completo.







