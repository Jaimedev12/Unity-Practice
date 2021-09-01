using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextoTerminal : MonoBehaviour
{
    // Contraseñas
    string[] contraseñasNivel_1 = { "Libro", "Estante", "Tarjeta", "Contraseña", "Shhh", "Separador", "Novela", "Ficción", "Capítulo", "Wikipedia" };
    string[] contraseñasNivel_2 = { "Patrulla", "Policía", "Municipales", "Barandilla", "Fianza", "Mordida", "Sirena", "Uniforme", "Esposas" };


    //Aquí van las variables públicas.
    string ascii = @"
   ,_       
 ,'  `\,_       Bien hecho!
 |_,-'_) 
 /##c '\  (     Completaste
' |'  -{.  )    el nivel!
  /\__-' \[]
 /`-_`\     
 '     \   
                    ";
    string indicacionIrAMenu = "Escribe 'menu' para regresar al menú   principal.";
    int nivel;
    string pista;
    string contraseña;
    enum Pantalla {MenuPrincipal, Contraseña, Ganaste};
    Pantalla pantallaActual = Pantalla.MenuPrincipal;

    // Funciones.
    void AsignarContraseña(string input)
    {
        switch (input)
        {
            case "1":
                nivel = 1;
                contraseña = contraseñasNivel_1[Random.Range(0, contraseñasNivel_1.Length)];
                pista = contraseña.Anagram();
                break;
            case "2":
                nivel = 2;
                contraseña = contraseñasNivel_2[Random.Range(0, contraseñasNivel_2.Length)];
                pista = contraseña.Anagram();
                break;
            default:
                Debug.LogError("Esto no debería de pasar, nivel inválido");
                break;

        }
    }
    void EnseñarMenuPrincipal()
    {
        pantallaActual = Pantalla.MenuPrincipal;
        Terminal.ClearScreen();

        Terminal.WriteLine("Qué onda.");
        Terminal.WriteLine("Vamos a hackear unas cosas.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Te voy a dar unas palabras que no      tienen sentido y tú tienes que");
        Terminal.WriteLine("cambiarle el orden a las letras, así escomo se hackea.");
        Terminal.WriteLine("Lo aprendí en el Scratch ;].");

        Terminal.WriteLine("");

        Terminal.WriteLine("Da click para continuar");

    }
    void EnseñarMenuElegirNivel()
    {
        Terminal.WriteLine("Elige qué quieres hackear primero:");
        Terminal.WriteLine("");
        Terminal.WriteLine("Presiona '1' para hackear la librería.");
        Terminal.WriteLine("Presiona '2' para hackear a los");
        Terminal.WriteLine("municipales.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Escribe 'menu' para volver atrás");
        Terminal.WriteLine("");
        Terminal.WriteLine("Tu respuesta:");
    }
    void EnseñarPantallaContraseña()
    {
        pantallaActual = Pantalla.Contraseña;
        Terminal.WriteLine(indicacionIrAMenu);
        Terminal.WriteLine("");
        Terminal.WriteLine("Empezando el nivel " + nivel);
        Terminal.WriteLine("Pista: " + pista);
        Terminal.WriteLine("");
        Terminal.WriteLine("Escribe tu contraseña: ");
    }
    void EnseñarPantallaGanaste()
    {
        pantallaActual = Pantalla.Ganaste;
        Terminal.ClearScreen();
        Terminal.WriteLine(ascii);
        Terminal.WriteLine(indicacionIrAMenu);
    }

    // Funciones para usar los menús
    void UsarMenuPrincipal(string input)
    {
        Terminal.ClearScreen();
        switch (input)
        {
            case "1":
                nivel = 1;
                AsignarContraseña(input);
                EnseñarPantallaContraseña();
                break;
            case "2":
                nivel = 2;
                AsignarContraseña(input);
                EnseñarPantallaContraseña();
                break;
            case "chinga tu madre":
                Terminal.WriteLine("La tuya, elige un buen nivel");
                break;
            case "Chinga tu madre":
                Terminal.WriteLine("La tuya, elige un buen nivel");
                break;
            case "menu":
                Terminal.ClearScreen();
                EnseñarMenuPrincipal();
                break;
            default:
                Terminal.WriteLine("Nivel inválido");
                Terminal.WriteLine("");
                Terminal.WriteLine(indicacionIrAMenu);
                break;
        }
    }
    void UsarPantallaContraseña(string input)
    {
        if (contraseña == input)
        {
            EnseñarPantallaGanaste();

        } else {
            Terminal.ClearScreen();
            Terminal.WriteLine("Nivel " + nivel + ":    Pista: " + pista);
            Terminal.WriteLine("");
            Terminal.WriteLine("Contraseña incorrecta.");
            Terminal.WriteLine("Inténtalo otra vez: ");
        }
    }


    //---------------------------------------------------------------------------------------------------------------------

    void Start()
    {
        EnseñarMenuPrincipal();
    }

    void OnUserInput(string input) //Para llegar al jugador a la pantalla correcta.
    {
        if (input == "menu")
        {
            EnseñarMenuPrincipal();
        } else if (pantallaActual == Pantalla.MenuPrincipal)
        {
            UsarMenuPrincipal(input);
        } else if (pantallaActual == Pantalla.Contraseña)
        {
            UsarPantallaContraseña(input);
        }

    }

    void Update() //Para ir a la segunda parte del menú principal.
    {
        if (Input.GetMouseButtonDown(0) && pantallaActual == Pantalla.MenuPrincipal)
        {
            Terminal.ClearScreen();
            EnseñarMenuElegirNivel();
        }
    } 

}
