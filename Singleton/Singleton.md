## Patrón Singleton (Patrón de contrucción)

### Patrón de contrucción
	- Los patrones de construcción tienen la vocación de abstraer los mecanismos de creación de objetos. Un sistema que utilice  estos  patrones  se  vuelve  independiente  de  la  forma  en  que  se  crean  los  objetos,  en  particular,  de  los mecanismos de instanciación de las clases concretas.

### Proposito
	- Asegúrese de que una clase tenga solo una instancia y proporcione un punto global de acceso a ella.
	- Restringe el uso de new y garantiza que no tenga más de una instancia de la clase.
	- Este patrón dice que una clase debe tener solo una instancia. Puede crear una instancia si no está disponible, de lo contrario, debe utilizar una instancia existente para satisfacer sus necesidades. Siguiendo este enfoque, puede evitar la creación de objetos innecesarios.

### Cuando usarlo
	- Solo debe existir una única instacia de una clase
	- Esta instancia sólo debe estar accesible mediante un método de clase
	- Cuando se trabaja con un sistema centralizado (por ejemplo una base de datos)
	- Cuando se utiliza un Log comun
	- Cuando se utiliza un pool de hilos en un entorno multihilos
	- Cuando se implementa un sistema de cache local.

#### Ejemplo
	- Puedes querer mantener un unico sistema de archivos para poder usarlo de forma centralizada, esto puede ayudar a implementar un mecanismo de almacenamiento en cache de forma eficaz.
