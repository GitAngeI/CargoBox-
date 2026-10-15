# CargoBox - Diseño Arquitectónico (Unidad 3)

## Integrantes del Equipo
* Angel de Jesus Ordaz Gonzalez
* Carlos Miguel Chávez Arredondo 
* 

## Contexto del Proyecto
CargoBox es una empresa de envíos logísticos nacionales. En este repositorio se implementa una propuesta de arquitectura de software basada en **Domain-Driven Design (DDD)** para resolver los cuellos de botella operativos (trazabilidad, cálculo de tarifas e invariantes de entrega).

## Instrucciones de Revisión (Estructura del Repositorio)
Para revisar el cumplimiento de la rúbrica, navegue por los siguientes directorios:

* `/docs`: Contiene el informe final en PDF, matriz de trazabilidad, Registros de Decisiones Arquitectónicas (ADR) y la bitácora de IA.
* `/diagrams`: Diagramas UML de Dominio, Clases y Secuencia.
* `/src`: Código base (Boilerplate) que demuestra la separación de responsabilidades:
  * **CargoBox.Domain**: Contiene el *Domain Model* (ej. Entidad `Paquete.cs` que protege la invariante de entrega).
  * **CargoBox.Application**: Contiene los *Application Services* que coordinan los casos de uso.
  * **CargoBox.Infrastructure**: Implementaciones de persistencia y *Unit of Work*.

## Patrón de Lógica Seleccionado
Se seleccionó **Domain Model** debido a la necesidad de proteger invariantes complejas durante los cambios de estado logísticos (Ej. restricción de entrega sin evidencia, o límite de segundos intentos).