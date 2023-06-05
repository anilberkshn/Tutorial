namespace Tutorial.CodeExample
{
    public class HwDepartman
    {
        public string isim { get; set; }
        public int id { get; set; }
        // İndexer tanımlaması 
        private string[] _isimler = new string[5];
       
        public string this [int index]
        {
            get => _isimler[index];
            set => _isimler[index] = value;
        }
    }
}