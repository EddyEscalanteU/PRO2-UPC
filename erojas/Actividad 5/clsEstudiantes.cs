public class clsEstudiantes{
    public string Grupo;
    public string Materia;
    public string Docente;
    public string Periodo;
    public string DiasClase;
    public string Horarios;
    public clsEstudiantes()
    {
        Grupo = " ";
        Materia = " ";
        Docente = " ";
        Periodo = " ";
        DiasClase = " ";
        Horarios = " ";

    }
    public void clase(string pGrupo, string pMateria, string pDocente, string pPeriodo, string pDiasClase, string pHoraios){
        Grupo = pGrupo;
        Materia = pMateria;
        Docente = pDocente;
        Periodo = pPeriodo;
        DiasClase = pDiasClase;
        Horarios = pHoraios;

    }
    
}