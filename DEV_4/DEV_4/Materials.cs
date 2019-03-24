namespace DEV_4
{
    using System.Collections.Generic;

    public abstract class Materials
    {
        private GUID id;
    }

    public class Lection : Materials
    {
        private string lectionText;

        private PresentationMaterial materials;
    }

    public class PresentationMaterial : Materials
    {
        private string URI;

        private string[] fileFormatsList = new string[2];
    }

    public class Seminar : Materials
    {
        private List<string> taskList;

        private List<string> answersList;
    }

    public class LaboratoryWork : Materials
    {
        private List<string> taskList;

        private string instruction;
    }
}