using System;
namespace FaceBookUISample.Models
{
    public class PrincipalComents
    {
        public string UserIcon       { get; set; }
        public string PictureComment { get; set; }
        public string Name           { get; set; }
        public string Date           { get; set; }
        public string Comment        { get; set; }
        public bool Like             { get; set; }
        public bool Love             { get; set; }
        public bool Funny            { get; set; }
        public string TotalComents   { get; set; }
    }
}
