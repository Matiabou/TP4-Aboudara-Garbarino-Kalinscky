static class Equipos
{
    public static List<string> ListaEquipos { get; private set; } = new List<string>{"Boca", "River", "Racing", "San Lorenzo", "Independiente", "Aldosivi", "Barcelona", "Real Madrid", "Liverpool", "Chelsea"};
    public static List<string> ListaMedias { get; private set; } = new List<string>{"Media_1.jpg", "Media_2.jpg", "Media_3.jpg", "Media_4.jpg", "Media_5.jpg", "Media_6.jpg", "Media_7.jpg", "Media_8.jpg", "Media_9.jpg", "Media_10.jpg"};
    public static List<string> ListaPantalones { get; private set; } = new List<string>{"Pantalon_1.jpg", "Pantalon_2.jpg", "Pantalon_3.jpg", "Pantalon_4.jpg", "Pantalon_5.jpg", "Pantalon_6.jpg", "Pantalon_7.jpg", "Pantalon_8.jpg", "Pantalon_9.jpg", "Pantalon_10.jpg"};
    public static List<string> ListaRemeras { get; private set; } = new List<string>{"Remera_1.jpg", "Remera_2.jpg", "Remera_3.jpg", "Remera_4.jpg", "Remera_5.jpg", "Remera_6.jpg", "Remera_7.jpg", "Remera_8.jpg", "Remera_9.jpg", "Remera_10.jpg"};
    public static Dictionary<string, Indumentaria> EquiposIndumentaria {get; private set;} = new Dictionary<string, Indumentaria>();

    public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria item){
        if (EquiposIndumentaria.ContainsKey(EquipoSeleccionado))
            return false;
        EquiposIndumentaria[EquipoSeleccionado] = item;
        return true;
    }

    public static void quitarEquipoDeLaLista(string Equipo) {
        ListaEquipos.Remove(Equipo);
    }
}