## Patrón Prototype (Patrón de contrucción)

El objetivo de  este patrón  es la  creación de nuevos objetos mediante duplicación de objetos  existentes llamados prototipos que disponen de la capacidad de clonación.

### Patrón de contrucción
	- Los patrones de construcción tienen la vocación de abstraer los mecanismos de creación de objetos. Un sistema que utilice  estos  patrones  se  vuelve  independiente  de  la  forma  en  que  se  crean  los  objetos,  en  particular,  de  los mecanismos de instanciación de las clases concretas.

### Casos de uso
	- Si necesitas hacer un objeto complejo que involucra varios pasos del proceso de construcción y, al mismo tiempo, los productos deben ser inmutables.

### Ventajas
	- Dirige al constructor para que construya los objetos paso a paso y promueve la encapsulación al ocultar los detalles del complejo proceso de construcción. 
	- Usando este patrón, el mismo proceso de construcción puede producir diferentes productos.
	- También puede variar la representación interna de los productos.
	- Principio de responsabilidad única. Puedes aislar un código de construcción complejo de la lógica de negocio del producto.








