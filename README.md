Pendiente:
  - Rebote perfecto en los border
  - Evitar caida infinita del sprite del jugador
  - Revisar sistema de "Apagado de Scripts"
  - Hacer pantalla GameOver
  - Cambiar los sprites por unos mejores (Idea, modelos 2D prerenderizados)
  - Limpiar scripts y comentar
  - Hacer que los números random se adquieran de un scriptableObject
  - Corutinas ¿?
  - Visual Scripting Script machine +State Machine



 GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemigo");

        foreach (GameObject enemy in enemies)
        {
            // Desactiva el GameObject del enemigo para detener su comportamiento
            enemy.SetActive(false);
        }